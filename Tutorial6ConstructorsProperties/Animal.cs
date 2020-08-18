using System;
using System.Linq;

namespace Tutorial6ConstructorsProperties
{
    public class Animal
    {
        private string name;
        private string sound;
        public const string SHELTER = "DEREKS HOME FOR ANIMALS";
        public readonly int idNum;

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound );
        }

        public Animal() : this("No name", "No sound "){}
        
        public Animal(string name): this(name, "No Sound"){}

        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            NumOfAnimals = 1;

            Random random = new Random();
            idNum = random.Next(1, 23333333);
        }

        public void SetName(string name)
        {
            //it is going to check any char if it is an int
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No name";
                Console.WriteLine("Name cant contain numbers");
            }
        }


        public string GetName()
        {
            return name;
        }

        public string Sound
        {
            get { return sound;}
            set
            {
                if (value.Length > 10)
                {
                    sound = "No sound";
                    Console.WriteLine("Sound is tooo long");
                }
                sound = value;
            } 
        }

        public string Owner { get; set; } = "No owner";
        
        public static int numOfAnimals = 0;

        public static int NumOfAnimals
        {
            get { return numOfAnimals;}
            set { numOfAnimals += value; }
        }
    }
}