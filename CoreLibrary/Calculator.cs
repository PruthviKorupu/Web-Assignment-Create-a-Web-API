using System;

namespace RESTAPILibrary
{
    public class Calculator
    {
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        
        public static double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                return -1; //avoid division by 0 error
                
            }
            else
            {
                return num1 / num2;
            }
        }
    }
}
