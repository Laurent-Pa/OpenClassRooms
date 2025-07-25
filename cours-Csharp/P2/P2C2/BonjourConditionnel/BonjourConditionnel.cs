﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonjourConditionnel
{
    public class Salutation
    {
        /// <summary>
        /// Affiche un message de bonjour au destinataire qui a été renseigné
        /// </summary>
        /// <param name="destinataire">Personne à qui on dit bonjour</param>
        public static void DireBonjour(string destinataire)
        {
            Console.WriteLine("Bonjour " + destinataire + "!");
        }
    }
}
