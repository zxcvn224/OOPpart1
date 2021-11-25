using System;

namespace OOPcat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double deprivation_of_food;


            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                deprivation_of_food = 0;
                Console.WriteLine($"The {color} colored cat {name} has been created");
            }
            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }

            public double Deprivation_of_food
            {
                get { return deprivation_of_food; }
            }

            public void Sleep()
            {
                Console.WriteLine("<<<<<<>>>>>>");
                deprivation_of_food += 0.2;
            }

            public void mjäu()
            {
                Console.WriteLine("Mewo");
            }
        }
        static void Main(string[] args)
        {
            Cat myCat = new Cat("mjä'w", "White");

            while (myCat.Deprivation_of_food != 1)
            {
                myCat.Sleep();
            }
            myCat.mjäu();

            Console.WriteLine($"Level of hunger: {myCat.Deprivation_of_food}");
        }
    }
}
