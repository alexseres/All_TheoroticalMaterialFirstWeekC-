using System;
using System.Threading.Channels;

namespace Tutorial5ClassesOOP
{
    public class Animal
    {
        public string name;
        public string sound;

        public Animal()
        {
            name = "NO name";
            sound = "No sound";
            numOfAnimals++;
        }

        public Animal(string name = "No name", string sound = "No sound")
        {
            this.name = name;
            this.sound = "No sound";
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound );
        }
        
        //static method belong to the class not for the objects for the class, has same value of all object of the animal type
        private static int numOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }
}