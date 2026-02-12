using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonApp
{
    public class Person
    {
        // FIELDS
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public bool isStudent { get; set; }

        // CONSTRUCTOR
        public Person(string name, int age, string email, bool isStudent)
        {
            this.name = name; // use "this" for the declaration NOT the set value
            this.age = age;
            this.email = email;
            this.isStudent = isStudent;
        }

        // Methods - Extra

        public void SayHi()
        {
            Console.WriteLine($"{name} said Hi!");
        }

        public void Greet(Person person)
        {
            Console.WriteLine($"{name}: Hello {person.name}! My name is {name}!");
        }
    }

    public static class PersonExtension
    {
        public static void PrettyPrintAll(this List<Person> people)
        {
            foreach (Person p in people)
            {
                Console.WriteLine($"Deserialized Person: \n" +
                $"\nName: {p.name}" +
                $"\nAge: {p.age}" +
                $"\nEmail: {p.email}" +
                $"\nIs Student: {p.isStudent}"
                );
            }
        }

        public static void SayHiToAll(this List<Person> people) // 'this' makes it so the variable calling the method is used
        {
            foreach (Person p in people)
            {
                p.SayHi();
            }
        }

        public static void GreetAll(this List<Person> people)
        {
            // Modulo so for does not exceed and instead greets alternatively
            for (int i = 0; i < people.Count; i++) // An algorithm with a complexity of O(n^2)
            {
                for (int j = 0; j < people.Count - 1; j++)
                {
                    people[i].Greet(people[j + 1]);
                }
            }
        }
    }
}
