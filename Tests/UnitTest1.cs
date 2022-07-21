using RESTAPILibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CalculatorUnitTest
{
    [TestClass]
    public class Tests
    {
       
//addition tests

        [TestMethod]
        public void additiontest1()
        {
            double no1 = 77; double no2 = 5; double expected = 82;

            double actualResult = Calculator.Addition(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void additiontest2()
        {
            double no1 = 88;  double no2 = 11;  double expected = 99;

            double actualResult = Calculator.Addition(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void additiontest3()
        {
            double no1 = 10; double no2 = 5; double expected = 15;

            double actualResult = Calculator.Addition(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void additiontest4()
        {
            double no1 = 21;  double no2 = 22;  double expected = 43;

            double actualResult = Calculator.Addition(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }       
        [TestMethod]
        public void additiontest5()
        {
            double no1 = 43; double no2 = 47; double expected = 90;

            double actualResult = Calculator.Addition(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void additiontest6()
        {
            double no1 = 33;  double no2 = 26;  double expected = 59;

            double actualResult = Calculator.Addition(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void additiontest7()
        {
            double no1 = 100; double no2 = 137; double expected = 237;

            double actualResult = Calculator.Addition(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void additiontest8()
        {
            double no1 = 76;  double no2 = 12;  double expected = 88;

            double actualResult = Calculator.Addition(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }  
        [TestMethod]
        public void additiontest9()
        {
            double no1 = 1030; double no2 = 67; double expected = 1097;

            double actualResult = Calculator.Addition(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void additiontest10()
        {
            double no1 = 1085;  double no2 = 12;  double expected = 1097;

            double actualResult = Calculator.Addition(no1, no2);

            Assert.AreEqual(expected, actualResult);
        } 

//subtraction tests
 
      [TestMethod]
        public void subtractiontest1()
        {
            double no1 = 77; double no2 = 5; double expected = 72;

            double actualResult = Calculator.Subtraction(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void subtractiontest2()
        {
            double no1 = 88;  double no2 = 11;  double expected = 77;

            double actualResult = Calculator.Subtraction(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void subtractiontest3()
        {
            double no1 = 10; double no2 = 5; double expected = 5;

            double actualResult = Calculator.Subtraction(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void subtractiontest4()
        {
            double no1 = 21;  double no2 = 22;  double expected = -1;

            double actualResult = Calculator.Subtraction(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }       
        [TestMethod]
        public void subtractiontest5()
        {
            double no1 = 43; double no2 = 47; double expected = -4;

            double actualResult = Calculator.Subtraction(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void subtractiontest6()
        {
            double no1 = 33;  double no2 = 26;  double expected = -7;

            double actualResult = Calculator.Subtraction(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void subtractiontest7()
        {
            double no1 = 100; double no2 = 137; double expected = -37;

            double actualResult = Calculator.Subtraction(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void subtractiontest8()
        {
            double no1 = 76;  double no2 = 12;  double expected = 64;

            double actualResult = Calculator.Subtraction(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }  
        [TestMethod]
        public void subtractiontest9()
        {
            double no1 = 1030; double no2 = 67; double expected = 963;

            double actualResult = Calculator.Subtraction(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void subtractiontest10()
        {
            double no1 = 1085;  double no2 = 12;  double expected = 1073;

            double actualResult = Calculator.Subtraction(no1, no2);

            Assert.AreEqual(expected, actualResult);
        } 


//multiplication tests
      
        

      
        [TestMethod]
        public void multiplicationtest1()
        {
            double no1 = 77; double no2 = 5; double expected = 385;

            double actualResult = Calculator.Multiplication(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void multiplicationtest2()
        {
            double no1 = 88;  double no2 = 11;  double expected = 968;

            double actualResult = Calculator.Multiplication(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void multiplicationtest3()
        {
            double no1 = 10; double no2 = 5; double expected = 50;

            double actualResult = Calculator.Multiplication(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void multiplicationtest4()
        {
            double no1 = 21;  double no2 = 22;  double expected = 462;

            double actualResult = Calculator.Multiplication(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }       
        [TestMethod]
        public void multiplicationtest5()
        {
            double no1 = 43; double no2 = 47; double expected = 2021;

            double actualResult = Calculator.Multiplication(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void multiplicationtest6()
        {
            double no1 = 33;  double no2 = 26;  double expected = 858;

            double actualResult = Calculator.Multiplication(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void multiplicationtest7()
        {
            double no1 = 100; double no2 = 137; double expected = 13700;

            double actualResult = Calculator.Multiplication(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void multiplicationtest8()
        {
            double no1 = 76;  double no2 = 12;  double expected = 912;

            double actualResult = Calculator.Multiplication(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }  
        [TestMethod]
        public void multiplicationtest9()
        {
            double no1 = 1030; double no2 = 67; double expected = 69010;

            double actualResult = Calculator.Multiplication(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void multiplicationtest10()
        {
            double no1 = 1085;  double no2 = 12;  double expected = 13020;

            double actualResult = Calculator.Multiplication(no1, no2);

            Assert.AreEqual(expected, actualResult);
        } 



//division tests
        [TestMethod]
        public void divisiontest1()
        {
            double no1 = 70; double no2 = 10; double expected = 7;

            double actualResult = Calculator.Division(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void divisiontest2()
        {
            double no1 = 88;  double no2 = 11;  double expected = 8;

            double actualResult = Calculator.Division(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void divisiontest3()
        {
            double no1 = 10; double no2 = 5; double expected = 2;

            double actualResult = Calculator.Division(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void divisiontest4()
        {
            double no1 = 21;  double no2 = 3;  double expected = 7;

            double actualResult = Calculator.Division(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }       
        [TestMethod]
        public void divisiontest5()
        {
            double no1 = 20; double no2 = 2.5; double expected = 8;

            double actualResult = Calculator.Division(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void divisiontest6()
        {
            double no1 = 49;  double no2 = 7;  double expected = 7;

            double actualResult = Calculator.Division(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void divisiontest7()
        {
            double no1 = 132; double no2 = 12; double expected = 11;

            double actualResult = Calculator.Division(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void divisiontest8()
        {
            double no1 = 72;  double no2 = 8;  double expected = 9;

            double actualResult = Calculator.Division(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }  
        [TestMethod]
        public void divisiontest9()
        {
            double no1 = 965; double no2 = 193; double expected = 5;

            double actualResult = Calculator.Division(no1, no2);

            Assert.AreEqual(expected, actualResult);
        }


        [TestMethod]
        public void divisiontest10()
        {
            double no1 = 1020;  double no2 = 12;  double expected = 85;

            double actualResult = Calculator.Division(no1, no2);

            Assert.AreEqual(expected, actualResult);
        } 

    }
}
