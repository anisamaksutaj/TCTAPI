using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbases.Models
{
    internal class Person
    {
        public Person(int age, string name, string surname, string address, int phone)
        {
            Age = age;
            Name = name;
            Surname = surname;
            Address = address;
            Phone = phone;
        }
        public Person()
        {

        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }






    }
}
