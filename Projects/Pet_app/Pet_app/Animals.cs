using System;

namespace Animals
{

	public class Animal
	{
        //FIELDS
        public string name { get; set; }
        public string color { get; set; }
        public string favFood { get; set; }

        //METHODS
        public virtual void Eat()
        {
            Console.WriteLine($"{name} is eating {favFood}!");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{name} says, ");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{name} is sleeping.");
        }

        public Animal(string Name, string Color, string FavFood)
		{
            name = Name;
            color = Color;
            favFood = FavFood;

            Console.WriteLine("Your new pet has been made!");
            Console.WriteLine($"Say hi to {name}!");
        }
	}
}
