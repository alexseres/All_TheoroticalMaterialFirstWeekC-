using System;

namespace Tutorial7InheritancePolymorphism
{
    public class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrrr";

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
        
        // we call base to call super class Animal constructor to have it handled (same as super in Java  
        public Dog(string name = "name", string sound = "No soumnd", string sound2 = "No sund 3") : base(name, sound)
        {
            Sound2 = sound2;
        }
        
    }
}