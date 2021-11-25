using System;

namespace ooPart1
{
    class Program
    {
        string name;
        int spots
        double happiness;

        public Dog(sring _name, int _spots)
        {
            name = _name;
            spots = _spots;
            happiness = 0;
            Console.WriteLine($"The dog {name} with {spots} spots has been created.");
        }

        public string Name
        {
            get { return name; }
        }
        public int Spots
        {
            get { return spots; }
        }
        public double Happines
        {
            get { return Happines; }
        }
        public void Barks()
        {
            Console.WriteLine("woof woof");
            happiness += 0.2;
        }
    }
    public void WagTail()
    {
        Console.WriteLine("wiggle-Wiggle");
    }
    static void Main(string[] args)
    {
        Dog myDog = new Dog("koer", 15);
        while(myDog.happiness != 1)
        {
            myDog.Barks();
        }
        myDog.WagTail();
        Console.WriteLine("rename your dog");
        string userInput = Console.ReadLine();
        myDog.Rename(userInput);

        Console.WriteLine($"Name{myDog.}");
        Console.WriteLine($"Level of happines {myDog.happiness} ");

    }

}
