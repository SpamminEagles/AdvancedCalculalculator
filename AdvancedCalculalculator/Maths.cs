using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
    public static class Maths
    {

        public static int Add(int a, int b)
        {
            return a+b;
        }
        public static double Add(double a, double b)
        {
            return a+b;        
        }
        public static float Add(float a, float b)
        {
            return a + b;
        }


        public static int Subtract(int a, int b)
        {
            return a-b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static float Subtract(float a, float b)
        {
            return a - b;
        }


        public static int Multiply(int a, int b)
        {
            return a*b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static float Multiply(float a, float b)
        {
            return a * b;
        }



        public static double Divide(double a, double b)
        {
            return a / b;
        }
        public static float Divide(float a, float b)
        {
            return a / b;
        }


        public static int Factorial(int a)
        {   
            if (a == 0)
                return 1;
            else
                return a * Factorial(a-1);
        }

        public static double Power(int a, int b) {
            double ans = 1;
            bool negative = b < 0 ? true : false;
            b = Abs(b);
            while (b != 0)
            {
                ans *= a;
                b--;
            }
            if(negative)
                return 1/ans;
            else
                return ans;
        }

        public static double Sqr(int a)
        {   
            double guess = 1;
            while (guess*guess <= a)
            {
                guess++;
            }
            guess--;
            for(int i = 0; i < 10; i++)
            {
                double f = guess*guess - a;
                double f_der = 2 * guess;
                guess = guess - (f/f_der);
            }   
            return guess;
        }

        public static int Abs(int a)
        {
            return a > 0 ? a : -a;
        }
        public static double Abs(double a)
        {
            return a > 0 ? a : -a;
        }
        public static float Abs(float a)
        {
            return a > 0 ? a : -a;
        }



        public static double Reciprocal(double a)
        {
            return 1 / a;
        }
        public static float Reciprocal(float a)
        {
            return 1 / a;
        }

    }
}
