using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace ASC_ASSIGNMENT_01
{
    class Program
    {
        static void Main(string[] args)
        {

            /* DEMONSTRATIA SOLUTIEI:
             * Daca in prezent avem o putere de calcul egala cu x, si la fiecare 18 luni aceasta se inmulteste cu 2,
             * inseamna ca peste un an jumate ( 1,5 ani ) vom avea o putere de calcul egala cu x * 2, iar peste 3 ani vom avea
             * o putere de calcul egala cu x * 2 * 2, care este egala cu x * 2^2, si asa mai departe. De aici obtinem ca puterea de calcul
             * va fi egala cu x * 2^(y/1.5) peste y ani. Folosind inversul functiei putere, adica logaritmul, putem afla in cati ani                                                                                                                          * 
             * vom ajunge la acea putere. De aici, rezultatul nostru: puterea noastra va fi de n ori mai mare in log2(n) * 1.5 ani.
             * */

            /*
             * Q.A. rezultatul probabil nu e corect!! 
             */
            Console.WriteLine("GOOD JOOB MISTER TEPES ALEXANDRU! You're an awesome and smart boy!");
            Console.WriteLine(" ");
            Console.WriteLine("Legea lui Moore indica faptul ca puterea de calcul se dubleaza la fiecare 18 luni.");
            Console.WriteLine("Acest program permite aflarea timpului ramas pana cand puterea de calcul va fi de n ori mai mare decat cea din prezent.");
            Console.Write("Introdu o valoare pentru n: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                
                int luni = Convert.ToInt32(Math.Floor((Math.Log(n, 2)) * 18f));
                int ani = luni / 12;
               
                luni = luni % 12;
                Console.Write($"Raspuns: Puterea de calcuc va fi de {n} ori mai mare in {ani} ani si {luni} luni, ");

                DateTime thisDay = DateTime.Now;
                Console.WriteLine($"pe data de {thisDay.AddYears(ani).AddMonths(luni).ToString("dd/MM/yyyy")}.");

            } catch (Exception e)
            {
                Console.WriteLine("Va rog sa introduceti un numar natural.");
            }


            Console.ReadKey();
        }
    }
}
