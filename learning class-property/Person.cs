using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerning_Class_Property
{
    public class Person
    {
        public string? Name { get; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("===error=== age can not be negative");
                _age = value;
            }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Greet() => Console.WriteLine($"My name is {Name} - {Age}");

    }
}

