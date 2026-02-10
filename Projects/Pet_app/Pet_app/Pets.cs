using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Animals;

namespace Pet_app
{
    public class Fish : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("blub blub blub blub!");
        }

        public override void Eat()
        {
            Console.WriteLine($"You toss some of {name}'s favourite food*");
            base.Eat();
        }

        public override void Sleep()
        {
            Console.WriteLine($"{name} swims to their favourite spot and lays down*");
            base.Sleep();
        }

        public Fish(string Name, string Color, string FavFood) : base(Name, Color, FavFood)
        {
            Speak();
        }
    }
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"Speak {name}!");
            Console.WriteLine("Bark! Bark!");
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Sleep()
        {
            base.Sleep();
        }
        public Dog(string Name, string Color, string FavFood) : base(Name, Color, FavFood)
        {
            Speak();
        }
    }
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meoww!");
        }
        public Cat(string Name, string Color, string FavFood) : base(Name, Color, FavFood)
        {
            Speak();
        }
    }
}
