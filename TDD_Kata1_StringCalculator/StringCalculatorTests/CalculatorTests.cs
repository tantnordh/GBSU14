using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculatorTests
{
	[TestClass]
	public class CalculatorTests
	{
		private static Calculator _calc;

		public CalculatorTests ()
		{
			_calc = new Calculator();
		}

		[TestMethod]
		public void AddMethodExists()
		{
			_calc.Add("5");
		}

		[TestMethod]
		public void EmptyStringReturnsZero()
		{
			var result = _calc.Add("");
			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void StringWithOneNumberReturnsNumber()
		{
			var result = _calc.Add("5");
			Assert.AreEqual(5, result);
		}

		[TestMethod]
		public void StringWithOneAndTwoReturnsThree()
		{
			var result = _calc.Add("1,2");
			Assert.AreEqual(3, result);
		}

		[TestMethod]
		public void TestTemplate()
		{
			// Arrange
			// var _calc = new Calculator();
			var result = _calc.Add("1,2");
			// Assert
			Assert.AreEqual(3, result);
		}

		[TestMethod]
		public void TestTemplate2()
		{
			// Given - A calculator should add two numbers, 1 and 2.
			// var _calc = new Calculator();
			// int number 1 = 1;
			// int number2 = 2;

			// When
			//var result = _calc.Add(number1, number2);
			
			// Then
			//Assert.AreEqual(3, result);
		}
	}
}
