using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lerning_Class_Property
{
    public class Person
    {
       
     public string? name { get; }

        public Person() : this("ali") {  }
        public Person(string name)
        {
            this.name = name;
        }
        public void Greet() => Console.WriteLine($" NAME : {name}");
        public void wellcome() =>this.Greet();
    }
}

