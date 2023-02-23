using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbases.Models
{
    internal class Cat : Animal
    {
        public Cat(string LifeGiven , int age, string name, string sound, string place) : base(age, name, sound, place)
        {
        }
        public string LifeGiven { get; set; }
    }
}
