using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbases.Models
{

    internal class Teacher : Person
    {
        public Teacher(string teachingSubject ,int age, string name, string surname, string address, int phone) :
            base( age,name,surname,address,phone  )
        {
            TeachingSubject = teachingSubject;
        }


        public string TeachingSubject { get; set; }
    }
}
