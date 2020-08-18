using System;
using System.Linq;

namespace Tutorial7InheritancePolymorphism
{
    public class Animal
    {
        private string name;
        protected string sound;
        protected AnimalIdInfo_ animalIdInfo = new AnimalIdInfo_();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIdInfo.IDNum = idNum;
            animalIdInfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIdInfo.IDNum} and it is owned by {animalIdInfo.Owner}");
        }
        
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
        
        public Animal(): this("Noname", "No sound"){}

        public Animal(string name):this(name, "No sound"){}

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No name";
                }

                name = value;
            }
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No sound";
                }
                
                sound = value;
            }
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if((calc>= .18) && (calc <=.27))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}