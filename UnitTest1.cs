using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static FileDetails.Program;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string input = "-v C:/test.txt";
            var expectedOutput = "1"; // expected version number of the file

            // test function
            string actualOutput = InputConverter.GetResult(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string input = "--v C:/test.txt";
            string expectedOutput = "1"; //expected version number of the file
            // test function
            string actualOutput = InputConverter.GetResult(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            string input = "/v C:/test.txt";
            string expectedOutput = "1";//expected version number of the file
            // test function
            string actualOutput = InputConverter.GetResult(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            string input = "--version C:/test.txt";
            string expectedOutput = "1";//expected version number of the file
            // test function
            string actualOutput = InputConverter.GetResult(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            string input = "-s C:/test.txt";
            string expectedOutput = "2"; //expected size of the file 

            // test function
            string actualOutput = InputConverter.GetResult(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            string input = "--s C:/test.txt";
            string expectedOutput = "2";//expected size of the file
            // test function
            string actualOutput = InputConverter.GetResult(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod7()
        {
            // Arrange
            string input = "/s C:/test.txt";
            string expectedOutput = "2";//expected size of the file
            // test function
            string actualOutput = InputConverter.GetResult(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestMethod8()
        {
            // Arrange
            string input = "--size C:/test.txt";
            string expectedOutput = "2";//expected size of the file
            // test function
            string actualOutput = InputConverter.GetResult(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
