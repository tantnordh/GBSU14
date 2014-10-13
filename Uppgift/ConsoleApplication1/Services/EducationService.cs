using ConsoleApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Services
{
	class EducationService
	{
		public List<Education> Educations { get; set; }

		public EducationService()
		{
			Educations = GenerateEducations();
		}

		public List<Education> GetAllEducationsInAlphabeticalOrder()
		{
			//return Educations.OrderBy(e => e.EducationName).ToList();
			var eduList =
				from e in Educations
				orderby e.EducationName
				select e;

			return eduList.ToList();
		}

		public List<Education> GetAllEducationsInPointOrder()
		{
			//return Educations.OrderBy(e => e.Points).ToList();
			var eduList =
				from e in Educations
				orderby e.Points
				select e;

			return eduList.ToList();
		}

		public List<Education> GetAllEducationsInAlphOrderMoreThan150Points()
		{
			//return Educations.Where(e => e.Points > 150).OrderBy(e => e.EducationName).ToList();
			var eduList =
				from e in Educations
				where e.Points > 150
				orderby e.EducationName
				select e;

			return eduList.ToList();
		}

		public List<Education> GetAllEducationsInAlphOrderMoreThan210Points()
		{
			//return Educations.Where(e => e.Points > 210).OrderBy(e => e.EducationName).ToList();
			var eduList =
				from e in Educations
				where e.Points > 210
				orderby e.EducationName
				select e;

			return eduList.ToList();
		}

		public List<Education> GetAllHiddenEducations()
		{
			//return Educations.Where(e => e.EducationStarts.Any(eStart => !eStart.Visible)).ToList();
			var eduList =
				from e in Educations
				from eStart in e.EducationStarts
				where eStart.Visible == false
				select e;

			return eduList.ToList();
		}

		public List<Education> GetAllEducationsInACity()
		{
			int input = GetUserInput();

			if (input == 1)
			{
				//return Educations.Where(e => e.EducationStarts.Any(eStart => eStart.City == "Stockholm")).ToList();
				var ediList =
					from e in Educations
					from eStart in e.EducationStarts
					where eStart.City == "Stockholm"
					select e;

				return ediList.Distinct().ToList();
			}
			else if (input == 2)
			{
				//return Educations.Where(e => e.EducationStarts.Any(eStart => eStart.City == "Göteborg")).ToList();
				var ediList =
					from e in Educations
					from eStart in e.EducationStarts
					where eStart.City == "Göteborg"
					select e;

				return ediList.Distinct().ToList();
			}
			else if (input == 3)
			{
				//return Educations.Where(e => e.EducationStarts.Any(eStart => eStart.City == "Malmö")).ToList();
				var ediList =
					from e in Educations
					from eStart in e.EducationStarts
					where eStart.City == "Malmö"
					select e;

				return ediList.Distinct().ToList();
			}
			else
			{
				//return Educations.Where(e => e.EducationStarts.Any(eStart => eStart.City == "Karlstad")).ToList();
				var ediList =
					from e in Educations
					from eStart in e.EducationStarts
					where eStart.City == "Karlstad"
					select e;

				return ediList.Distinct().ToList();
			}
		}

		public List<Education> GetAllEducationsThatHaveStarted()
		{
			//return Educations.Where(e => e.EducationStarts.Any(eStart => eStart.Startdate < DateTime.Now)).ToList();
			var ediList =
				from e in Educations
				from eStart in e.EducationStarts
				where eStart.Startdate < DateTime.Now
				select e;

			return ediList.Distinct().ToList();
		}

		public List<Education> GetAllEducationsBetweenTwoDates()
		{
			List<DateTime> dates = GetDates();
			//return Educations.Where(e => e.EducationStarts.Any(eStart => eStart.Startdate >= dates[0] && eStart.Enddate <= dates[1])).ToList();
			var ediList =
				from e in Educations
				from eStart in e.EducationStarts
				where eStart.Startdate >= dates[0] && eStart.Enddate <= dates[1]
				select e;

			return ediList.Distinct().ToList();
		}

		public List<Education> GetAllVisibleEducationsStartingIn2015()
		{
			DateTime date1 = new DateTime(2015-01-01);
			DateTime date2 = new DateTime(2016-01-01);
			//return Educations.Where(e => e.EducationStarts.Any(eStart => eStart.Startdate.Year == 2015)).ToList();
			var ediList =
				from e in Educations
				from eStart in e.EducationStarts
				where eStart.Startdate.Year == 2015
				select e;

			return ediList.Distinct().ToList();
		}

		private List<DateTime> GetDates()
		{
			Console.WriteLine("Ange ett fråndatum på formatet ÅÅÅÅ-MM-DD: ");
			DateTime date1 = DateTime.Parse(Console.ReadLine());
			Console.WriteLine("Ange ett tilldatum på formatet ÅÅÅÅ-MM-DD: ");
			DateTime date2 = DateTime.Parse(Console.ReadLine());

			return new List<DateTime> { date1, date2 };
		}

		private int GetUserInput()
		{
			Console.Clear();
			Console.WriteLine("STÄDER");
			Console.WriteLine("(1) Stockholm");
			Console.WriteLine("(2) Göteborg");
			Console.WriteLine("(3) Malmö");
			Console.WriteLine("(4) Karlstad");

			var input = 0;
			while (!int.TryParse(Console.ReadLine(), out input) || input < 1 || input > 4)
			{
				Console.WriteLine("Försök med ett heltal 1-4.");
			}

			return input;
		}

		public List<Education> GenerateEducations()
		{
			// SYSTEMUTVECKLARE .NET
			var educationStart1 = new EducationStart
			{
				City = "Göteborg",
				Enddate = new DateTime(2016, 09, 10),
				Startdate = new DateTime(2015, 07, 11),
				Visible = true
			};

			var educationStart2 = new EducationStart
			{
				City = "Göteborg",
				Enddate = new DateTime(2015, 08, 01),
				Startdate = new DateTime(2013, 06, 01),
				Visible = false
			};

			var educationStart3 = new EducationStart
			{
				City = "Malmö",
				Enddate = new DateTime(2014, 08, 02),
				Startdate = new DateTime(2012, 06, 02),
				Visible = true
			};


			var educationStartList1 = new List<EducationStart>();
			educationStartList1.Add(educationStart1);
			educationStartList1.Add(educationStart2);
			educationStartList1.Add(educationStart3);

			var education1 = new Education
			{
				EducationName = "Systemutvecklare .NET",
				Description = "Innefattar C# .NET, wpf, web, mvc, sql, ep1cs etc",
				Points = 100,
				EducationStarts = educationStartList1
			};


			// TANDSKÖTERSKA
			var educationStart5 = new EducationStart
			{
				City = "Stockholm",
				Enddate = new DateTime(2014, 05, 12),
				Startdate = new DateTime(2012, 04, 13),
				Visible = true
			};

			var educationStart6 = new EducationStart
			{
				City = "Stockholm",
				Enddate = new DateTime(2016, 09, 05),
				Startdate = new DateTime(2014, 06, 01),
				Visible = false
			};

			var educationStart7 = new EducationStart
			{
				City = "Göteborg",
				Enddate = new DateTime(2014, 06, 30),
				Startdate = new DateTime(2012, 06, 16),
				Visible = true
			};


			var educationStartList2 = new List<EducationStart>();
			educationStartList2.Add(educationStart5);
			educationStartList2.Add(educationStart6);
			educationStartList2.Add(educationStart7);

			var education2 = new Education
			{
				EducationName = "Tandsköterska",
				Description = "Innefattar tandvård, borrning av tänder och annat kul",
				Points = 300,
				EducationStarts = educationStartList2
			};


			// JAVAUTVECKLARE
			var educationStart9 = new EducationStart
			{
				City = "Malmö",
				Enddate = new DateTime(2014, 08, 05),
				Startdate = new DateTime(2012, 06, 09),
				Visible = true
			};

			var educationStart10 = new EducationStart
			{
				City = "Malmö",
				Enddate = new DateTime(2016, 08, 16),
				Startdate = new DateTime(2014, 06, 01),
				Visible = false
			};

			var educationStart11 = new EducationStart
			{
				City = "Göteborg",
				Enddate = new DateTime(2014, 09, 01),
				Startdate = new DateTime(2012, 06, 01),
				Visible = true
			};

			var educationStartList3 = new List<EducationStart>();
			educationStartList3.Add(educationStart9); // Lades i ursprunglig version till i educationStartList2, tandsköterskornas lista...
			educationStartList3.Add(educationStart10);
			educationStartList3.Add(educationStart11);


			var education3 = new Education
			{
				EducationName = "Javautvecklare",
				Description = "Innefattar javautveckling i eclipse som är jättebra och super-användarvänligt (eller inte)",
				Points = 200,
				EducationStarts = educationStartList3
			};


			// DIPLOMERAD NINJA
			var educationStart13 = new EducationStart
			{
				City = "Karlstad",
				Enddate = new DateTime(2014, 08, 05),
				Startdate = new DateTime(2012, 06, 09),
				Visible = true
			};

			var educationStart14 = new EducationStart
			{
				City = "Malmö",
				Enddate = new DateTime(2016, 08, 16),
				Startdate = new DateTime(2014, 06, 01),
				Visible = true
			};

			var educationStart15 = new EducationStart
			{
				City = "Malmö",
				Enddate = new DateTime(2014, 09, 01),
				Startdate = new DateTime(2012, 06, 01),
				Visible = true
			};

			var educationStartList4 = new List<EducationStart>();
			educationStartList4.Add(educationStart13);
			educationStartList4.Add(educationStart14);
			educationStartList4.Add(educationStart15);


			var education4 = new Education
			{
				EducationName = "Diplomerad ninja",
				Description = "Innefattar karate och väggspringning",
				Points = 350,
				EducationStarts = educationStartList4
			};

			var educationList = new List<Education>();
			educationList.Add(education1);
			educationList.Add(education2);
			educationList.Add(education3);
			educationList.Add(education4);

			return educationList;
		}
	}
}
