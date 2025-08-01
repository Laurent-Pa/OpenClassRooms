using System.ComponentModel;

using P3C4bis.Models;

// TODO : créer deux instances d'Animal 
Animal kaponk = new Animal("Kaponk", "Karine", "Blanc & roux", "chat");
Animal edna = new Animal("Edna", "Laurent", "Noire", "chat");

Console.WriteLine($"{kaponk.Name} appartient à {kaponk.Owner}");
Console.WriteLine($"{edna.Name} appartient à {edna.Owner}");

// TODO : afficher le resultat de ces deux méthodes ici


// TODO : exécuter les méthodes de test pour les deux méthodes de la classe Program.cs