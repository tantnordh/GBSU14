using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculatorTests
{
	[TestClass]
	public class CalculatorTests
	{
		private readonly Calculator _calc;
		public CalculatorTests()
		{
			_calc = new Calculator();
		}

		[TestMethod]
		public void AddMethodExists()
		{
			int result = _calc.Add("5");
		}

		[TestMethod]
		public void AddReturnsZeroForEmptyString()
		{
			var result = _calc.Add("");

			Assert.AreEqual(0, result);
		}
		
		[TestMethod]
		public void AddReturnsNumberForStringWithOneNumber()
		{
			var result = _calc.Add("5");

			Assert.AreEqual(5, result);
		}

		[TestMethod]
		public void AddReturnsSumForStringWithTwoNumbers()
		{
			var result = _calc.Add("1,2");
			
			Assert.AreEqual(3, result);
		}

		[TestMethod]
		public void AddReturnsSumForStringWithMultipleNumbers()
		{
			var result = _calc.Add("1,2,3,4,5");

			Assert.AreEqual(15, result);
		}

		[TestMethod]
		public void AddReturnsSumForStringSplittedOnCommaOrNewLine()
		{
			var result = _calc.Add("1,2\n3");

			Assert.AreEqual(6, result);
		}

		[TestMethod]
		public void AddSupportsDifferentDelimiters()
		{
			var result = _calc.Add("//;\n1;2");

			Assert.AreEqual(3, result);
		}

		[TestMethod]
		public void AddIgnoresNumbersGreaterThanOneThousand()
		{
			var result = _calc.Add("1,1001");

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void AddSupportsDelimitersOfAnyLength()
		{
			var result = _calc.Add("//[***]\n1***2***3");

			Assert.AreEqual(6, result);
		}
	}
}
