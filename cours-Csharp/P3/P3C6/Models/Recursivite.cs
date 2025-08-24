using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3C6.Models
{
    public class CalculRecursif
    {
        public static int Factorielle(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int resultat = n * Factorielle(n - 1);
                Console.WriteLine($"Voici la valeur de n: {n}");
                Console.WriteLine($"Le résultat courant est: {resultat}");
                return resultat;
            }
        }
    }
}
