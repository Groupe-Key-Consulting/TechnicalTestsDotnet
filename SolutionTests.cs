using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;


namespace TechnicalTests.UnitTests.LevelOne
{
    [TestFixture]
    internal class SolutionTests
    {

        #region Test of method GetMagicNumber with different file

        // TO DO ADD TEST WITH ANOTHER CHAR

        [Test]
        public void GetMagicNumber_Should_Return_Correct_Value_With_Input()
        {
            var listForTest = new List<char>();
            listForTest.Add('k');
            listForTest.Add('c');
            var solution = new Solution.LevelOne(listForTest);


            var result = solution.GetMagicNumber("C:\\Users\\Mehdi\\Source\\Repos\\TechnicalTestsDotnet\\TechnicalTests\\TechnicalTests.UnitTests\\LevelOne\\input.txt");
            result.Should().Be(78576);
        }


        [Test]
        public void GetMagicNumber_Should_Return_Correct_Value_With_Input2()
        {
            var listForTest = new List<char>();
            listForTest.Add('k');
            listForTest.Add('c');
            var solution = new Solution.LevelOne(listForTest);

            var result = solution.GetMagicNumber("C:\\Users\\Mehdi\\Source\\Repos\\TechnicalTestsDotnet\\TechnicalTests\\TechnicalTests.UnitTests\\LevelOne\\input2.txt");
            result.Should().Be(1845);

        }

        [Test]
        public void GetMagicNumber_Should_Return_Correct_Value_With_Input3()
        {
            var listForTest = new List<char>();
            listForTest.Add('k');
            listForTest.Add('c');
            var solution = new Solution.LevelOne(listForTest);

            var result =  solution.GetMagicNumber("C:\\Users\\Mehdi\\Source\\Repos\\TechnicalTestsDotnet\\TechnicalTests\\TechnicalTests.UnitTests\\LevelOne\\input3.txt");
            result.Should().Be(3063);

        }


        [Test]
        public void GetMagicNumber_Should_Return_Correct_Value_With_InputEmpty()
        {
            var listForTest = new List<char>();
            listForTest.Add('k');
            listForTest.Add('c');
            var solution = new Solution.LevelOne(listForTest);

            var result = solution.GetMagicNumber("C:\\Users\\Mehdi\\Source\\Repos\\TechnicalTestsDotnet\\TechnicalTests\\TechnicalTests.UnitTests\\LevelOne\\inputEmpty.txt");
            result.Should().Be(0);
        }
        #endregion



        [Test]
        public void GetSuperMagicNumber_Should_Return_Correct_Value_With_Input()
        {
            var listForTest = new List<char>();
            listForTest.Add('k');
            listForTest.Add('c');
            var solution = new Solution.LevelOne(listForTest);


            var result = solution.GetSuperMagicNumber("C:\\Users\\Mehdi\\Source\\Repos\\TechnicalTestsDotnet\\TechnicalTests\\TechnicalTests.UnitTests\\LevelOne\\input.txt");
            result.Should().Be(3902304);
        }


        [Test]
        public void GetSuperMagicNumber_Should_Return_Correct_Value_With_Input2()
        {
            var listForTest = new List<char>();
            listForTest.Add('k');
            listForTest.Add('c');
            var solution = new Solution.LevelOne(listForTest);

            var result = solution.GetSuperMagicNumber("C:\\Users\\Mehdi\\Source\\Repos\\TechnicalTestsDotnet\\TechnicalTests\\TechnicalTests.UnitTests\\LevelOne\\input2.txt");
            result.Should().Be(5490);

        }

        [Test]
        public void GetSuperMagicNumber_Should_Return_Correct_Value_With_Input3()
        {
            var listForTest = new List<char>();
            listForTest.Add('k');
            listForTest.Add('c');
            var solution = new Solution.LevelOne(listForTest);

            var result = solution.GetSuperMagicNumber("C:\\Users\\Mehdi\\Source\\Repos\\TechnicalTestsDotnet\\TechnicalTests\\TechnicalTests.UnitTests\\LevelOne\\input3.txt");
            result.Should().Be(60126);

        }


        [Test]
        public void GetSuperMagicNumber_Should_Return_Correct_Value_With_InputEmpty()
        {
            var listForTest = new List<char>();
            listForTest.Add('k');
            listForTest.Add('c');
            var solution = new Solution.LevelOne(listForTest);

            var result = solution.GetSuperMagicNumber("C:\\Users\\Mehdi\\Source\\Repos\\TechnicalTestsDotnet\\TechnicalTests\\TechnicalTests.UnitTests\\LevelOne\\inputEmpty.txt");
            result.Should().Be(0);
        }
 
    }
}
