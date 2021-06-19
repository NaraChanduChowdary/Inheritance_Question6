using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Inheritance
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog()
            {
                Name = "Jimmy",
                Age = 2
            };
            Console.WriteLine(dog.GetDescription());
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string GetDescription()
        {
            return "Name:" + Name + "Age:" + Age.ToString();
        }
    }
    public class Dog : Animal
    {
        public int Legs { get; set; }
    }
    public class Bird : Animal
    {
        public int Wingspan { get; set; }
    }
    public class Snake : Animal
    {
        public bool IsPoisonous { get; set; }
    }

}
