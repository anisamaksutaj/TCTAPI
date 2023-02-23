using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbases.Models
{
    internal class Animal
    {
        public Animal(int age, string name, string sound, string place )
        {
            Age = age;
            Name = name;
            Sound = sound;
           Place  = place;
           
        }
        public Animal()
        {

        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Sound  { get; set; }
        public string Place { get; set; }
        





    }
}
