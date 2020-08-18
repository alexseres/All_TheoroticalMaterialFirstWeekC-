using System;

namespace Tutorial5ClassesOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length = 100;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());
            
            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;


            Console.WriteLine("rect2.length : {0}", rect2.length);

            Animal fox = new Animal()
            {
                name = "red",
                sound = "Rawww"
            };
            fox.name = "Joszi";
            
            fox.MakeSound();
            Console.WriteLine("# of Animals: {0}", Animal.GetNumAnimals());



            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("Rectangle", 5, 6));


            int? randNum = null;
            if (randNum == null)
            {
                Console.WriteLine("randnum is null");
            }
            if(!randNum.HasValue)
            {
                Console.WriteLine("randnum is null");
            }

        


            Console.ReadLine();
        }
        
        //struct : user defined type allowed to contain multiple fields as well as methods
        //struct can be used to hold small data values that do not require inheritance, e.g. coordinate points
        
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
        
    }
}