using ConsoleApplication1.Models;
using ConsoleApplication1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			var eduService = new EducationService();
			var educations = eduService.GenerateEducations();

			RunProgram(eduService, educations);
		}

		private static void RunProgram(EducationService eduService, List<Education> educations)
		{
			int input = 0;

			while (input != 11)
			{
				Console.WriteLine("MENY");
				Console.WriteLine("(1) Visa alla utbildningar i bokstavsordning");
				Console.WriteLine("(2) Visa alla utbildningar i poäng-ordning");
				Console.WriteLine("(3) Visa alla utbildningar i bokstavsordning som innefattar mer än 150 poäng");
				Console.WriteLine("(4) Visa alla utbildningar i poängordning som innefattar mer än 210 poäng");
				Console.WriteLine("(5) Visa alla utbildningar som har en utbildningsstart som är dold");
				Console.WriteLine("(6) Visa alla utbildningar på en ort");
				Console.WriteLine("(7) Visa alla utbildningar som har en utbildningsstart som redan har startat");
				Console.WriteLine("(8) Visa alla utbildningsstarter");
				Console.WriteLine("(9) Visa alla utbildningar mellan två datum"); // Det tolkar jag som utbildningar som startar och slutar inom den angivna perioden.
				Console.WriteLine("(10) Visa alla utbildningar på en ort som har\nutbildningsstarter som är visibile och som har startdatum någon gång 2015");
				Console.WriteLine();
				Console.WriteLine("(11) Avsluta");

				// När klar: Skriv om med from/where/select-formatet.

				try
				{
					input = int.Parse(Console.ReadLine());

					if (input == 1)
					{
						var result = eduService.GetAllEducationsInAlphabeticalOrder();
						PrintEduResult(result);
					}
					else if (input == 2)
					{
						var result = eduService.GetAllEducationsInPointOrder();
						PrintEduResult(result);
					}
					else if (input == 3)
					{
						var result = eduService.GetAllEducationsInAlphOrderMoreThan150Points();
						PrintEduResult(result);
					}
					else if (input == 4)
					{
						var result = eduService.GetAllEducationsInAlphOrderMoreThan210Points();
						PrintEduResult(result);
					}
					else if (input == 5)
					{
						var result = eduService.GetAllHiddenEducations();
						PrintEduResult(result);
					}
					else if (input == 6)
					{
						var result = eduService.GetAllEducationsInACity();
						PrintEduResult(result);
					}
					else if (input == 7)
					{
						var result = eduService.GetAllEducationsThatHaveStarted();
						PrintEduResult(result);
					}
					else if (input == 8)
					{
						var result = eduService.GetAllEducationsInAlphabeticalOrder();
						PrintEduStartsWithEduName(result);
					}
					else if (input == 9)
					{
						var result = eduService.GetAllEducationsBetweenTwoDates();
						PrintEduResult(result);
					}
					else if (input == 10)
					{
						var result = eduService.GetAllVisibleEducationsStartingIn2015();
						PrintEduResult(result);
					}
				}
				catch (Exception)
				{
					Console.Clear();
					Console.WriteLine("Försök med ett heltal 1-11.");
					RunProgram(eduService, educations);
				}
			}
		}

		private static void PrintEduStartsWithEduName(List<Education> educations)
		{
			Console.Clear();
			for (int i = 0; i < educations.Count; i++)
			{
				Console.WriteLine(educations[i].EducationName.ToUpper());
				for (int j = 0; j < educations[i].EducationStarts.Count; j++)
				{
					if (educations[i].EducationStarts[j].Visible)
					{
						Console.WriteLine("City: " + educations[i].EducationStarts[j].City);
						Console.WriteLine("Start date: " + educations[i].EducationStarts[j].Startdate);
						Console.WriteLine("End date: " + educations[i].EducationStarts[j].Enddate);
						Console.WriteLine();
					}
				}
				Console.WriteLine();
			}
		}

		static void PrintEduResult(List<Education> educations)
		{
			Console.Clear();
			foreach (var education in educations)
			{
				Console.WriteLine("Utbildningsnamn: " + education.EducationName);
				Console.WriteLine("Beskrivning: " + education.Description);
				Console.WriteLine("Poäng: " + education.Points);
				Console.WriteLine();
			}
		}

		static void PrintEduStartResult(List<EducationStart> educationStarts)
		{
			Console.Clear();
			foreach (var educationStart in educationStarts)
			{
				Console.WriteLine("Ort: " + educationStart.City);
				Console.WriteLine("Startdatum: " + educationStart.Startdate.ToShortDateString());
				Console.WriteLine("Slutdatum: " + educationStart.Enddate.ToShortDateString());
				Console.WriteLine();
			}
		}

	}
}
