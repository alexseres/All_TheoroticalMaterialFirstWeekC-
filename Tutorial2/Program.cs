using System;
using System.Globalization;
using System.Text;


namespace Tutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            var intVal = 1234;
            Console.WriteLine("IntVal Type : {0}", intVal.GetType());

            int[] favNums = new int[3];
            favNums[2] = 24;
            Console.WriteLine("favNum 0 : {0}", favNums[2]);
            string[] customers = {"Bob", "Sally", "Sue"};
            var employees = new[] {"Sanyi", "Bela", "Rick"};
            object[] randomArray = {"Reaka", 45, 1.2344};
            Console.WriteLine("randomArray 0 : {0}", randomArray[0].GetType());

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array : {0} : Value : {1}", i, randomArray[i]);
            }

            string[,] custNames = new string[2, 2] {{"Bob", "Smioth"}, {"Sally", "Jenny"}};
            Console.WriteLine("MD Value : {0}", custNames.GetValue(1, 1));

            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.WriteLine("{0}",custNames[i,j]);
                }

                Console.WriteLine();
            }

            int[] randNums = {1, 4, 9, 2};
            Array.Sort(randNums);
            Array.Reverse(randNums);

            randNums.SetValue(0,1);
            PrintArray(randNums, "ForEach");

            int[] srcArray = {1, 2, 3};
            int[] destArray = new int[2];
            int startId = 0;
            int length = 2;
            
            Array.Copy(srcArray, startId, destArray, startId, length);
            PrintArray(destArray, "Copy");

            Console.WriteLine("OKKKKKK");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray,5 );

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0}",m);
            }



            int[] numArray = {1, 11, 22};
            Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));
            
            
            StringBuilder sb = new StringBuilder("Random Text");

            StringBuilder sb2 = new StringBuilder(" More staff that is important", 256);
            Console.WriteLine("Capacity : {0}", sb.Capacity);
            Console.WriteLine("Capacity : {0}", sb2.Capacity);

            sb2.AppendLine("\nMore important text");

            CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");

            string bestCust = "Bob Smith";
            sb2.AppendFormat(enUs, "Best Customer: {0}", bestCust);

            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random text");
            Console.WriteLine(sb.Equals(sb2));
            sb2.Insert(11, "that great");
            Console.WriteLine(sb2.ToString());

            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());
            
            

            long num1 = 1234;
            int num2 = (int)num1;
            Console.WriteLine("Original : {0} Cast : {1}", num1.GetType(), num2.GetType());
            Console.ReadLine();

        }

        static void PrintArray(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k );
            }
        }

        private static bool GT10(int val)
        {
            return val > 10;
        }
    }
}