using System;

namespace OOPCat
{
    class Program
    { 
        class Car
        {
            string name;
            string color;
            double hungriness;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungriness = 0;
            }
            public string Name
            {
                get { return name; }
            }
            public string color
            {
                get { return color; }
            }
            public double hungriness
            {
                get { return hungriness; }
            }
            public void Spleeps()
            {
                Console.WriteLine("Z-Z-Z-Zz-z-z-z-z");
                hungriness += 0.2;
            }
        }
         public void Meow()
         {
            Console.WriteLine("Meowwww");
         }
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Garfield", "ginger");
            while(myCat.hungriness !=1)
            {
                myCat.Spleeps();
            }
            myCat.Meow();
        }
    }
}
