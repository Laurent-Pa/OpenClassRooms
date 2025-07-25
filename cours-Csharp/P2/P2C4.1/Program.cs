using System;
using System.Collections.Generic;

using P2C4._1;

// Le programme affiche la température moyenne à partir des valeurs fournies comme arguments en ligne de commande

try
{
    List<int> temperaturesEnregistreDegresCelcius = new List<int>();

    // Remplir la liste à partir des valeurs fournies comme arguments en ligne de commande
    foreach (string stringRepresentationTemperature in args)
    {
        int temperature = int.Parse(stringRepresentationTemperature);
        temperaturesEnregistreDegresCelcius.Add(temperature);
    }

    // Calculer et afficher la température moyenne
    int temperatureMoyenne =
        MathSimple.CalculMoyenne(temperaturesEnregistreDegresCelcius);
    Console.WriteLine("La température moyenne est " + temperatureMoyenne);
}

catch (FormatException e)
{
    Console.WriteLine("Les températures fournies doivent être des nombres");
    // l'exercice propose Environment.Exit(-1) mais cela ferme directement le programme
    throw; // permet de remonter l'exception d'un niveau supérieur, finally pourra être executé
}

catch (DivideByZeroException e)
{
    Console.WriteLine("Vous devez fournir au moins une température");
    throw;
}

finally
{
    // Ce bloc s'exécute avec "throw" mais PAS avec "Environment.Exit(-1)"
    Console.WriteLine("Fin du programme");
}

