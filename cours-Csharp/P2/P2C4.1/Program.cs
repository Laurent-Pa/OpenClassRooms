using System;
using System.Collections.Generic;

using P2C4._1;

// Le programme affiche la température moyenne à partir des valeurs fournies comme arguments en ligne de commande

List<int> temperaturesEnregistreDegresCelcius = new List<int>();

// Remplir la liste à partir des valeurs fournies comme arguments en ligne de commande
foreach (string stringRepresentationTemperature in args)
{
    int temperature = int.Parse(stringRepresentationTemperature);
    temperaturesEnregistreDegresCelcius.Add(temperature);
}

// Gérer une liste vide
if (temperaturesEnregistreDegresCelcius.Count == 0)
{
    Console.WriteLine("Impossible de calculer la moyenne avec une liste vide !");
}
else
{
    // Calculer et afficher la température moyenne
    int temperatureMoyenne =
        MathSimple.CalculMoyenne(temperaturesEnregistreDegresCelcius);
    Console.WriteLine("La température moyenne est " + temperatureMoyenne);
}
