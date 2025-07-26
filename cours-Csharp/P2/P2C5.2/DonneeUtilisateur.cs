using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2C5._2
{
    //TODO
    //Ajoutez les lignes manquantes à ce fichier pour pouvoir y accéder depuis une autre classe.
    class DonneeUtilisateur
    {
        public static string DemanderUneUrl()
        {
            /// <summary>
            /// Demande à l'utilisateur de saisir une URL
            /// </summary>
            /// <returns>Une représentation sous forme de chaîne de caractères de l'URL saisie par l'utilisateur</returns>.
            string url;
            do
            {
                Console.WriteLine("Veuillez saisir une URL valide");
                url = Console.ReadLine() ?? "";  // Chaîne vide si null avec les ??
                if (!URLValide(url))
                {
                    Console.WriteLine("❌ URL invalide ! Exemple : https://www.google.com");
                    Console.WriteLine("Veuillez réessayer :");
                }
            }
            while (!URLValide(url)); // Répète la demande de saisie tant que l'URL n'est pas valide
            return url;
         }

        /// <summary>
        /// Vérifier le formatage d'une URL
        /// </summary>
        /// <param name="chaineUrl"></param>
        /// <returns>vrai si le format correspond a une URL, sinon faux</returns>
        private static bool URLValide(string chaineUrl)
        {
            // Vérifier que ce n'est pas vide
            if (string.IsNullOrWhiteSpace(chaineUrl))
                return false;

            // Vérifier que le format est HTTP/HTTPS
            if (Uri.IsWellFormedUriString(chaineUrl, UriKind.Absolute))
            {
                Uri uri = new Uri(chaineUrl);
                return uri.Scheme == "http" || uri.Scheme == "https";
            }
             // Si le format saisi n'est pas une URL         
             return false;
           
        }

    }
    
}
