using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3C2
{
    public class Animal
    {
        //TODO. Il manque un mot-clé ici (static) pour pouvoir appeler la methode sur la classe Animal
        private static int total = 0;

        // Constructeur - appelé automatiquement à chaque création d'instance
        public Animal()
        {
            Incrementer(); // Appel automatique à chaque nouvelle instance
        }

        public void Incrementer()
        {
            Animal.total += 1;
        }

        public static void AfficherNom()
        {
            string nom = "Rocky";
            Console.WriteLine(nom);
        }

        public static void AfficherTotal() {
            Console.WriteLine("Nombre d'animaux créés " + total);
        }
    }
}
