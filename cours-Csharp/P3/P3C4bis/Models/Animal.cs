using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3C4bis.Models
{
    public class Animal
    {
        /* Créer deux animaux de type chat : Edna et Kaponk qui disposent du champs
         * - avoirfaim de type bool
         * 
         */
        // 1ère méthode : les nourrir : change l'état de avoirfaim à false
        // 2ème méthode : leur faire des caresses 

        public string Name { get; set; }
        public string Owner { get; set; }
        public string Color { get; set; }
        public string Race { get; set; }
        public bool isHungry { get; set; }
        public bool isHappy { get; set; }

        public Animal(string name, string owner, string color, string race)
        {
            Name = name;
            Owner = owner;
            Color = color;
            Race = race;
            isHungry = true;
            isHappy = false;
        }

        public void Feed()
        {
            if (isHungry)
            {
                isHungry = false;
                Console.WriteLine($"{this.Name} a été nourri avec succès.");
            }
            else { 
                Console.WriteLine($"{this.Name} avait suffisament mangé, ça fait beaucoup");
            }
        }

        public void Pet()
        {
            if (!isHappy)
            {
                isHappy = true;
                Console.WriteLine($"{this.Name} ronronne.");
            }
            else
            {
                Console.WriteLine($"{this.Name} ronronne encore plus.");
            }
        }
    }
}
