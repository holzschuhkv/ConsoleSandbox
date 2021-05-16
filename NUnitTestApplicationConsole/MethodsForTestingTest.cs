using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework;
using System.Linq;
using TestApplicationConsole;

namespace NUnitTestApplicationConsole
{
    [TestFixture]
    public class MethodsForTestingTest
    {
        /// <summary>
        /// SetUp is run at first before each test, is for instancing objects
        /// </summary> 

        private SimpleMethods methodsForTesting = null;
       
        [SetUp]
        public void Setup()
        {
            methodsForTesting = new SimpleMethods();
        }

        /// <summary>
        /// 
        /// </summary>
        [TearDown]
        public void TeardDown()
        {
            methodsForTesting = null;
        }

        /// <summary>
        /// Rohkonstrukt eines Methodennamens
        /// </summary>
        [Test]
        public void MethodNameToBeTested_WhatWillBeTested_ExpectedResultOfTest()
        {
            // Arrange = Objects und Variablen erstellen
            // Act = Testüberprüfung starten
            // Assert = Abgleich mit dem erwarteten Wert

            Assert.Pass();
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void SimpleStringReturn_AdminUserTest_ReturnIsAdmin()
        {
            //Arrange
            var input = "Admin";

            //Act
            var result = methodsForTesting.SimpleStringReturn(input);

            //Assert
            Assert.That(result, Is.EqualTo("isAdmin"));
        }

        [Test, Category("Test")]
        [TestCase(2, 4, 6)]
        [TestCase(2, 1, 3)]
        [TestCase(3, -1, 2)]
        public void BasicCalculation_Calculation_ReturnRightCalculation(int value1, int value2, int expectedResult)
        {
            var returnValue = methodsForTesting.BasicCalculation(value1, value2);

            Assert.AreEqual(returnValue, expectedResult);
        }
        
        [Test]
        [TestCase("test", "TEST")]
        [TestCase("asDf", "ASDF")]
        [TestCase("123", "123")]
        public void InputStringToUpperCase_TestUpperCaseFunction_UpperCaseToInputString(string inputString, string expectedResult)
        {
            var returnString =  methodsForTesting.InputStringToUpperCase(inputString);

            Assert.That(returnString, Does.StartWith("UPPER_CASE"));
            Assert.That(returnString, Does.Contain(expectedResult));
            Assert.That(returnString, Does.EndWith("UPPER_CASE"));
            Assert.AreEqual(returnString, "UPPER_CASE" + expectedResult + "UPPER_CASE");
        }

        [Test]
        [TestCase(7, 7)]
        [TestCase(12, 12)]
        [TestCase(1200, 1200)]
        public void EnumerableIntegerOutput_TestingCollections_ReturnIsAnEnumerableOfInt(int testCase, int items)
        {
            var output = methodsForTesting.EnumerableIntegerOutput(testCase);

            Assert.That(output, Is.Not.Empty);
            Assert.That(output.Count(), Is.EqualTo(items));

            //Assert.That(output, Does.Contain(new[] { 0, 1, 2, 3 }));
            //Assert.That(output, Is.EquivalentTo(new[] { 1, 3, 5, 6 }));

            Assert.That(output, Is.Ordered);
            Assert.That(output, Is.Unique);
        }

        [Test]
        public void ReturnTypeTestObjectClass_TestingTheObjectReturnType_ReturnTypeTestObjectClass()
        {
            var returnValue = methodsForTesting.ReturnTypeTestObjectClass();

            Assert.That(returnValue, Is.TypeOf<TestObjectClass>()); //is exactly the compared object no derivates are checked
            Assert.That(returnValue, Is.InstanceOf<TestObjectClass>()); //checks also if its an derivate
        }
    }
}