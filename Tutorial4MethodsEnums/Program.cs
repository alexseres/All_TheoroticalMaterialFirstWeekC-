﻿using System;

namespace Tutorial4MethodsEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = 4;

            Console.WriteLine("5 + 4 = {0}", GetSum(x,y));
            Console.WriteLine("x = {0} ", x);

            
            
            int solution;
            DoubleIt(15, out solution);
            // out keyword is used to pass arguments to the method as a reference type
            //define variable inside in the method
            
            Console.WriteLine("15 * 2 = {0}", solution);


            int num1 = 10;
            int num2 = 20;

            Console.WriteLine("Before Swap num1 : {0} num2 : {1}", num1, num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("After Swap num1 : {0} num2 : {1}", num1, num2);
            
            
            
            Console.Write("1 + 2 + 3 = {0}", GetSumMore(1,2,3));
            
            
            PrintInfo(zipCode: 15147, name: "Derek Banas");


            Console.WriteLine("5.0 + 4.5 = {0}", GetSum(5.0, 4.5));
            
            //method overload
            Console.WriteLine("5.0 + 4.5 = {0}", GetSum("5.0", "4.5"));


            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
            
            
            
            Console.ReadLine();
        }

        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        }

        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted {0} with the code {1}",cc,(int)cc);
        }
        
        
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}",name, zipCode);
        }
        
        
        public static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }

            return sum;
        }

        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        
        
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
        
        
        
        static double GetSum(double x = 1, double y = 1)
        {
            double temp = x;
            x = y;
            y = temp;

            return x + y;
        }
        static double GetSum(string x = "1", string y = "2")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
        }
    }
}