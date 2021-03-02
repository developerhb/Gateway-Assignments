using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Testing_Final_Assignment_2;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestInverseMethod()
        {
            //Arrange
            string input = "hEllo WORld";
            string operation = "inverse";
            string expected = "HeLLO worLD";

            //Act
            string output = input.StringExtension(operation);

            //Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestWordCount()
        {
            //Arrange
            string input = "This is Unit Test Project";
            string operation = "words";
            string expected = "5";

            //Act
            string output = input.StringExtension(operation);

            //Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestIsLowerCase_Valid_Input()
        {
            //Arrange
            string input = "hello world";
            string operation = "isLowerCase";
            string expected = "yes";

            //Act
            string output = input.StringExtension(operation);

            //Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestIsLowerCase_Invalid_Input()
        {
            //Arrange
            string input = "HellO WOrld";
            string operation = "isLowerCase";
            string expected = "no";

            //Act
            string output = input.StringExtension(operation);

            //Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestIsUpperCase_Valid_Input()
        {
            //Arrange
            string input = "HELLO WORLD";
            string operation = "isUpperCase";
            string expected = "yes";

            //Act
            string output = input.StringExtension(operation);

            //Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestIsUpperCase_Invalid_Input()
        {
            //Arrange
            string input = "hello WOLRD";
            string operation = "isUpperCase";
            string expected = "no";

            //Act
            string output = input.StringExtension(operation);

            //Assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestIsNumeric_Valid_Input()
        {
            //Arrange
            string input = "43";
            string operation = "isNumeric";
            string expected = "yes";

            //Act
            string ouput = input.StringExtension(operation);

            //Assert
            Assert.AreEqual(expected, ouput);
        }

        [TestMethod]
        public void TestIsNumeric_Invalid_Input()
        {
            //Arrange
            string input = "4 3";
            string operation = "isNumeric";
            string expected = "no";

            //Act
            string output = input.StringExtension(operation);

            //Assert
            Assert.AreEqual(expected, output);
        }
    }
}
