using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbases.Models
{
    internal class Dog : Animal
    {
        public Dog(bool DoesBite , int age, string name, string sound, string place) : base(age, name, sound, place)
        {
        }
        public bool DoesBite { get; set; }

    }
}
