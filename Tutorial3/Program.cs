using System;

namespace Tutorial3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 2;

            bool canDrive = age >= 16 ? true : false;
            Console.WriteLine("CanDrive {0} ", canDrive);
            
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Goto elementary school");
                    break;
                case 17:
                    Console.WriteLine("Goto Highschool");
                    break;
                default:
                    Console.WriteLine("go to another school");
                    goto OtherSchool;  
                    // goto is useful to get out a really nester for loop
                    
            }
            
            OtherSchool:
            Console.WriteLine("Elementary, Middle, High School");
            string name = "Derek";
            string name2 = "Derek";

            if (name.Equals(name2, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are equal");
            }

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;

            // do
            // {
            //     Console.WriteLine("Enter a number berween 1 and 10: ");
            //     numberGuessed = Convert.ToInt32(Console.ReadLine());
            // } while (secretNumber != numberGuessed);
            //

            double num1 = 5;
            double num2 = 5;

            try
            {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cant divide by 0");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occur");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Cleaning up");
            }
            

            Console.ReadLine();
        }

        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }

            return x / y;
        }
    }
}