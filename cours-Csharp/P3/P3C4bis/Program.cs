using P3C4bis;
using P3C4bis.Models;
using System.ComponentModel;


// TODO : créer deux instances d'Animal 
Animal kaponk = new Animal("Kaponk", "Karine", "Blanc & roux", "chat");
Animal edna = new Animal("Edna", "Laurent", "Noire", "chat");

Console.WriteLine($"{kaponk.Name} appartient à {kaponk.Owner}");
Console.WriteLine($"{edna.Name} appartient à {edna.Owner}");

// TODO : afficher le resultat de ces deux méthodes ici
if ( kaponk.isHungry )
{
    Console.WriteLine($"{kaponk.Name} a faim, il faut le nourrir!");
    kaponk.Feed();
}

if ( !edna.isHappy )
{
    Console.WriteLine($"{edna.Name} est un peu ronchon, il faut la caresser!");
    edna.Pet();
}



// TODO : exécuter les méthodes de test pour les deux méthodes de la classe Program.cs

Test test = new Test();
test.TestFeedEdna(kaponk);
test.TestFeedEdna(edna);