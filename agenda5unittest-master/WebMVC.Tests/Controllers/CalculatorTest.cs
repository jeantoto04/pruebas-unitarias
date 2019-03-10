using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVC.Tests.Controllers
{

    [TestClass]
    public class CalculatorTest
    {
        
        [TestInitialize]
        public void OnTestInitialize()
        {
            _SystemUnderTest = null;
        }

        private Calculator _SystemUnderTest;

        public Calculator SystemUnderTest
        {
            get
            {
                if(_SystemUnderTest == null)
                {
                    _SystemUnderTest = new Calculator();
                }
                return _SystemUnderTest;
            }


        }

 
        [TestMethod]
        //resta
        public void resta()
        {

            //Arrange (Organizar)
            int value1 = 4;
            int value2 = 3;
            int expected = 1;

            //Act (Actuar)

            int actual = SystemUnderTest.resta(value1,value2);

            //Assert (Afirmar)
            Assert.AreEqual<int>(expected, actual, "Error, valores no coinciden");

        }

        //suma
        [TestMethod]
        public void suma()
        {

            //Arrange (Organizar)
            int value11 = 2;
            int value22 = 3;
            int expected = 5;

            //Act (Actuar)
            
            int actual = SystemUnderTest.suma(value11, value22);

            //Assert (Afirmar)
            Assert.AreEqual<int>(expected, actual, "Error, valores no coinciden");

        }

        //multiplicacion
        [TestMethod]
        public void multiplicacion()
        {

            //Arrange (Organizar)
            int valor1 = 2;
            int valor2 = 3;
            int expected = 6;

            //Act (Actuar)


            int actual = SystemUnderTest.multiplicacion(valor1, valor2);

            //Assert (Afirmar)
            Assert.AreEqual<int>(expected, actual, "Error, valores no coinciden");

        }


        //division
        [TestMethod]
        public void division()
        {


            //Arrange (Organizar)
            int valor1 = 9;
            int valor2 = 3;
            int expected = 3;

            //Act (Actuar)


            int actual = SystemUnderTest.division(valor1, valor2);

            //Assert (Afirmar)
            Assert.AreEqual<int>(expected, actual, "Error, valores no coinciden");

        }

    }
}
