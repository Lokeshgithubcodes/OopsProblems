using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsProblems
{
     class InheritanceAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

    }
      public class Dog : InheritanceAnimal
    {
        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

}
