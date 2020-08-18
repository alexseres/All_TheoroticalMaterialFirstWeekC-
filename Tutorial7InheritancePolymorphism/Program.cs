using System;

namespace Tutorial7InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",

                Sound = "Meow"
            };
            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrrr"
            };

            grover.Sound = "WOOOOOFFFF";
            
            whiskers.MakeSound();
            grover.MakeSound();

            
            whiskers.SetAnimalIDInfo(12345,"Alex Seres");
            
            grover.SetAnimalIDInfo(12323, "Sanyi");
            
            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine("is my animal healthy {0}", getHealth.HealthyWeight(11,46));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "EEEE"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooof",
                Sound2 = "Geer"
            };
            monkey.MakeSound();
            spot.MakeSound();
        }
    }
}