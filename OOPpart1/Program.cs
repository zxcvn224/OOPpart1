using System;

namespace OOPpart1
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog (string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} with {spots} spots has been created");
            }

            public string Name
            {
                get { return name; }
            }

            public int Spots
            {
                get { return spots; }
            }

            public double Happiness
            {
                get { return happiness; }
            }

            public void Madis()
            {
                Console.WriteLine("Woof-woof!");
                happiness += 0.2; //happiness = happiness + 0.2
            }

            public void WagTail()
            {
                Console.WriteLine("Wiggle-Wiggle");
            }

            public void Rename(string newName)
            {
                name = newName;
            }



        }




        static void Main(string[] args)
        {
            Dog myDog = new Dog("Madis", 15);
            // myDog.happiness = 10;
            // myDog.name = "Good Boy";

            while(myDog.Happiness !=1)
            {
                myDog.Madis();
            }

            myDog.WagTail();

            Console.WriteLine("Rename your dog:");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);

            Console.WriteLine($"{myDog.Name}");
            Console.WriteLine($"Level of happiness: {myDog.Happiness}");
        }
    }
}
