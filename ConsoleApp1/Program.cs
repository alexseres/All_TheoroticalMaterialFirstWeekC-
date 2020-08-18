using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
           
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Args{0} : {1}", i, args[i]);
            }

            string[] myArgs = Environment.GetCommandLineArgs();
            Console.WriteLine(string.Join(", ", myArgs));
            
            SayHello();

            
            
            decimal decPival = 3.141592653589793238462643383M;
            decimal decBigNum = 3.00000001M;
            Console.WriteLine("DEC : PI + BigNum = {0}", decPival + decBigNum);
            
              
            Console.WriteLine("Biggest Long: {0}",long.MaxValue );
            Console.WriteLine("Biggest Long: {0}",long.MinValue );

            Console.WriteLine("Biggest Integer: {0}",int.MaxValue );
            Console.WriteLine("Biggest Integer: {0}",int.MinValue );

            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.234");
            
      
            
            DateTime awesomeDate = new DateTime(1974, 12, 21);
            Console.WriteLine("Day of Week: {0}", awesomeDate.DayOfWeek);

            awesomeDate = awesomeDate.AddDays(4);
            awesomeDate = awesomeDate.AddMonths(1);
            awesomeDate = awesomeDate.AddYears(2);
            Console.WriteLine("New Date : {0} ", awesomeDate.Date);
            
            TimeSpan lunchTime = new TimeSpan(12,30,0);
            lunchTime = lunchTime.Subtract(new TimeSpan(0, 15, 0));
            lunchTime = lunchTime.Add(new TimeSpan(1, 0, 0));
            
            Console.WriteLine("New time: {0}", lunchTime.ToString() );
            Console.WriteLine("Currency: {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d8}", 23);

            string randString = "This is a string";
            Console.WriteLine("A= a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad LEft : {0}", randString.PadLeft(20, '.'));
            Console.WriteLine("Pad Right : {0}", randString.PadRight(20, '.'));
            Console.WriteLine("Trim : {0}", randString.Trim());
            Console.WriteLine("String lengtj : {0}", randString.Length);
            Console.WriteLine("String contains : {0}", randString.Contains("is")); Console.WriteLine("Index of is: {0}", randString.IndexOf("is"));
            Console.WriteLine("Remove String: {0}", randString.Remove(0,6));
            Console.WriteLine("Insert String : {0}", randString.Insert(10, "short"));
            Console.WriteLine("Replace String : {0}", randString.Replace("string", "sentence"));
            Console.WriteLine("Compare A to C : {0}", String.Compare("A", "C", StringComparison.OrdinalIgnoreCase));

            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
            Console.WriteLine(@" Exactly what i typed '");
            
            Console.ReadLine();
        }

        private static void SayHello()
        {
            // string name = " ";
            // Console.Write("What is your name: ");
            // name = Console.ReadLine();
            // Console.WriteLine("Hello{0}", name);
        }
    }
}    