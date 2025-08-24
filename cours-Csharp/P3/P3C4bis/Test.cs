using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P3C4bis.Models;

namespace P3C4bis
{
    public class Test
    {
        // TODO : créer deux méthodes de test correspondant à la méthode Test en respectant la convention de nommage appropriée
        public void TestFeedAnimal(Animal mon_chat)
            {
                Console.WriteLine("Test de la method Feed de la class Animal");
                mon_chat.isHungry = true;
                Console.WriteLine($"{mon_chat.Name} a faim");
                mon_chat.Feed();

                if (!mon_chat.isHungry)
                {
                    Console.WriteLine($"Test réussi : {mon_chat.Name} n'a plus faim après avoir été nourri");
                }
                else
                {
                    Console.WriteLine($"Test échoué : {mon_chat.Name} a encore faim");
                }
        }

        public void TestPetAnimal(Animal mon_chat)
        {
            Console.WriteLine("Test de la method Pet de la class Animal");
            mon_chat.isHappy = false;
            Console.WriteLine($"{mon_chat.Name} est triste");
            mon_chat.Pet();

            if (mon_chat.isHappy)
            {
                Console.WriteLine($"Test réussi : {mon_chat.Name} a reçu des carresses, c'est le bonheur.");
            }
            else
            {
                Console.WriteLine($"Test échoué : {mon_chat.Name} n'a pas eu de caresses.");
            }
        }
    }
}
