using csharpbases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbases.Helpers
{
    internal class PersonalHelper
    {
        /// <summary>
        /// Merr si input Nje liste me persona 
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Personat e renditur suoas moshes , emrit , mbiemrit, adreses </returns>
        public List<Person> RenditPersonatSipasMoshes(List<Person> persons) {  
            return persons.OrderBy( a => a.Age).ThenBy(b => b.Name).ThenBy(b => b.Surname).ToList();
        }


        /// <summary>
        /// Merr si input nje liste me persona 
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Khen moshen mesate te personave</returns>
        public double GjejMoshenMesatare(List<Person> persons)
        {
            return persons.Average(a => a.Age);
        }

        /// <summary>
        /// Merr si inout nje liste 
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Kthen Personin me Moshe me te Madhe</returns>
        public Person  KthePersoninMeMoshenMeTeMAdhe(List<Person> persons)
        {
            return persons.MaxBy(a => a.Age);
           
        }
           
    }
}
