using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpbases
{
    internal class funkione_me_array_dhe_lista
    {
        public int GjejMeTeMadhin(int[] array)
        {

            int max = 0;

            foreach(int item in array)
            {
                if(item > max) max = item;
            }

            return max;

        }
        public int GjejShumenEArray(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                if(item > sum) sum = item;

            }
           
            return sum;

        }
        public int GjejShumeNrCift(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                if (item % 2 == 0)
                {
                    sum=sum+item;
                }
            }
          
            return sum;
        }
        
}
