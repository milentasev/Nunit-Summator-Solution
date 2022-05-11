using NUnit.Framework;
using System;

namespace Summator.Tests
{
	[TestFixture]
	public class SummatorTestes
	{

		private Summator summator;

		[OneTimeSetUp]
		public void OneTimeSetUp()
		{
			TestContext.Progress.WriteLine("All tests started " + DateTime.Now);
		}

		[SetUp]
		public void Setup()
		{
			summator = new Summator();
			Console.WriteLine("Test started " + DateTime.Now);
		}

		[Test]
		public void Test_Sum_OnePositiveNumber()
		{
			long actual = summator.Sum(new int[] { 5 });
			int expected = 5;

			Assert.That(expected == actual);
		}

		[Test]
		public void Test_Sum_TwoPositiveNumbers()
		{
			long actual = summator.Sum(new int[] { 5, 7 });
			int expected = 12;

			Assert.That(expected == actual);
		}

		[Test]
		[Category("Critical")]
		public void Test_Sum_MultiplePositiveNumbers()
		{
			long actual = summator.Sum(new int[] { 5, 7, 8, 9, 10 });
			int expected = 39;

			Assert.That(expected == actual);
		}

		[Test]
		[Category ("AAA Testing Pattern")]
		public void Test_Sum_One_NegativeNumber() 
		{
			//Arrange
			int[] values = new int[] {-5 };
			int expected = -5;
			
			//Act
			long actual = summator.Sum(values);

			//Assert
			Assert.AreEqual(expected, actual);

		}

		[Test]
		public void Test_Sum_TwoNegativeNumbers()
		{
		
			long actual = summator.Sum(new int[] { -7, -9 });
			int expected = -16;

			Assert.That(expected == actual);
		}

		[Test]
		public void Test_Sum_Multiple_NegativeNumbers()
		{
			long actual = summator.Sum(new int[] {-1, -5, -11, -22 });
			
			Assert.AreEqual(-39, actual);
		}

		[Test]
		public void Test_Sum_PositiveAndNegativeNumber()
		{
			long actual = summator.Sum(new int[] {-1, 5 });
			int expected = 4;
			
			Assert.That(expected, Is.EqualTo(actual));
		}

		[Test]
		public void Test_Sum_EmptyArray()
		{
			long actual = summator.Sum(new int[] { });
			int expected = 0;

			Assert.That(expected == actual);
		}

		[Test]
		public void Test_Sum_BigValues()
		{
			long actual = summator.Sum(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 });

			Assert.AreEqual(8000000000, actual);
		}

		[Test]
		[Category ("AAA Testing Pattern")]
		public void Test_Sum_TwoPositiveNumbersAAA()
		{
			//Arrange
			var values = new int[] { 5, 7 };
			int expected = 12;

			//Act
			long actual = summator.Sum(values);

			//Assert
			Assert.That(expected == actual);
		}

		[Test]
		public void Test_If_Sum_IsPositive()
		{
			var values = new int[] { -12, -1, 5, 5, 5 };

			long actual = summator.Sum(values);

			Assert.That(actual, Is.GreaterThan(0));
		}

		[Test]
		public void Test_If_Sum_IsNegative()
		{
			var values = new int[] { -12, -1, 5 };

			long actual = summator.Sum(values);

			Assert.That(actual, Is.LessThan(0));
		}

		[Test]
		public void Test_If_Sum_IsEven()
		{
			int[] values = new int[] { 2, 4, 6 };

			long actual = summator.Sum(values);
			bool expected = actual % 2 == 0;

			Assert.AreEqual(expected, true);
		}

		[Test]
		public void Test_If_Sum_IsOdd()
		{
			int[] values = new int[] { 1, 4, 6 };

			long actual = summator.Sum(values);
			bool expected = actual % 2 != 0;

			Assert.AreEqual(expected, true);
		}

		[Test]
		public void Test_If_Sum_IsDigit()
		{
			var actual = summator.Sum(new int[] { -1, 8 });
			bool isDigit = actual > 0 && actual < 10;
			Assert.AreEqual(isDigit, true);
		}

		[Test]
		public void Test_Avarage_TwoPositiveNumbers()
		{
			double actual = summator.Avarage(new double[] { 5, 6 });

			Assert.AreEqual(5.5, actual);
		}

		[Test]
		public void Test_Avarage_TwoNegativeNumbers()
		{
			double actual = summator.Avarage(new double[] { -1, -6 });

			Assert.AreEqual(-3.5, actual);
		}

		[Test]
		public void Test_Avarge_MultiplePositiveNumbers()
		{
			double actual = summator.Avarage(new double[] {1, 4, 6, 11, 18 });
			Assert.AreEqual(8, actual);

		}

		[Test]
		public void Test_Avarge_MultipleNegativeNumbers()
		{
			double actual = summator.Avarage(new double[] { -1, -4, -6, -11, -18 });
			Assert.AreEqual(-8, actual);

		}

		[Test]
		public void Test_Assertions()
		{
			var values = new int[] { 5, 7 };
			int expected = 12;
			long actual = summator.Sum(values);

			Assert.That(expected, Is.EqualTo(actual));
			Assert.AreEqual(expected, actual);

			double percentage = 99.95;
			Assert.That(percentage, Is.InRange(80, 100));

			int[] arr = new int[] { 10, 20, 30, 50, 100 };
			Assert.That(arr, Is.All.InRange(0, 100));

			Assert.That("QA are great", Is.EqualTo ("QA are great"));
			Assert.That("QA are great", Does.Contain ("are great"));

		}

		[TearDown]
		public void TearDown()
		{
			summator = null;
			Console.WriteLine("Test ended  " + DateTime.Now);
		}

		[OneTimeTearDown]
		public void OneTimeTearDown()
		{
			TestContext.Progress.WriteLine("All tests ended " + DateTime.Now);
		}
	}
}