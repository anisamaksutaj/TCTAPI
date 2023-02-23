using System;
using System.Collections.Generic;
using System.Linq;
//language integrated query 
using System.Text;
using System.Threading.Tasks;

namespace csharpbases
{
    internal class FuksioneMeLista
    {
        /// <summary>
        /// Pret nje liste me  Integer
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>kthen numrin me te madh te listes </returns>
        public int GjejMeTeMadhinNeListe(List<int> lista) 
        {
            return lista.Max();
        }
        
        /// <summary>
        /// Pret nje liste me Integer
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Pret shume e elementeve te listes </returns>
        public int GjejShumenEListes(List<int> lista)
        {
            return lista.Sum();
        }
        public int GjejShumenCiftNeListe(List<int> lista)
        {
            // lambda expresion eshte fuksion 
            return lista.Where(a => a % 2 == 0).Sum(); 
            // a(a e pare )----- krijohet referenca e elementit ne liste
            //=>  ---------> ku 
            // a( e dyte ) -----> vet elementi te cilit i referohemi

            //ndertoni nje funksion qe merr si input nje liste dhe kthen numrin e elementeve 

 

         }
        //ndertoni nje funksion qe merr si input nje liste dhe kthen numrin e elementeve 
          public int GjejShumenENumravePozitiv(List<int> lista)
        {
            return lista.Where( a =>  a>=0).Sum();
        }

        public int GjejNumrinElementevePozitiv (List<int> lista)
        {
            return lista.Where( a=>  a>=0).Count();
        }

        // ktheni nje liste me elementet tek qe jane ne nje liste 

        /// <summary>
        /// Merr nje liste me integer
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>Kthen vetem elementet tek </returns>
        public List<int> KtheElementetTek(List<int> lista)
        {
            return lista.Where(a => a % 2 == 1).ToList();
        }

        public List<string> KonvertToUpperCase(List<string> lista)
        { 
             return lista.Select(a => a.ToUpper()).ToList();
        }
        public int KtheShumenEELementeveNegativ(List<int> lista)
        {
            return lista.Where(a => a < 0).Sum();
        }
        public List<int> KtheListeMeNrPozitivDheCift(List<int> lista)
        {
            return lista.Where(a => a>=0 && a%2 == 0).ToList();
        }
    }
}
