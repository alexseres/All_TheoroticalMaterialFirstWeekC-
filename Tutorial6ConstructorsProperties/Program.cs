using System;

namespace Tutorial6ConstructorsProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            
            cat.SetName("Whiskers");
            cat.Sound = "Meow";
            Console.WriteLine("The cat is named {0} and say {1}",cat.GetName(), cat.Sound);


            Animal fox = new Animal();
            
            
            
            
            cat.Owner = "Derek";
            Console.WriteLine("{0} owner is {1} ", cat.GetName(), cat.Owner   );
            Console.WriteLine("{0} shelter is {1} ", cat.GetName(), cat.idNum   );
            Console.WriteLine("#Animals : {0} ", Animal.NumOfAnimals   );
            
            

        }
    }
}