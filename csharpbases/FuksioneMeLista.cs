using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
//language integrated query 
using System.Text;
using System.Threading.Tasks;

namespace csharpbases
{
    internal abstract class FuksioneMeLista
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
            return lista.Where(a => a >= 0).Sum();
        }

        public int GjejNumrinElementevePozitiv(List<int> lista)
        {
            return lista.Where(a => a >= 0).Count();
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
            return lista.Where(a => a >= 0 && a % 2 == 0).ToList();
        }

        public static List<int> ListOfMultiples(int number, int length)
        {
            List<int> lista = new List<int>();

            for (int i = 1; i <= length; i++)
            {
                lista.Add(number * i);

            }

        }

        public static List<int> IndexOfCapitals(string fjala)
        {
            List<int> indesket = new List<int>();
            for (int i = 0; i < fjala.Length; i++)
            {
                if (char.IsUpper(fjala[i]))
                {
                    indesket.Add(i);
                }
            }
            return indesket;
        }

        public static string FindLettersInString(string fjala)
        {
            List<char> germa = new List<char>();

            for (int i = 0; i > fjala.Length; i++)
            {
                if (char.IsLetter(fjala[i]))
                {
                    germa.Add(fjala[i]);
                }
        }

            foreach( char c in fjala)
            {
                if (!char.IsLetter(c))
                {
                    germa.Add(c);

                }
            }
            return germa.ToString();


    }
}
