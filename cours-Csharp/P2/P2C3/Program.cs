//TODO : Créer une boucle for et while qui affiche à 5 reprises la phrase, « Je m'amuse comme un fou ! ».

// Boucle for
for(int i = 0; i<5; i++)
{
    Console.WriteLine("Je m'amuse comme un fou avec les boucles for");
    if (i == 4)
    { continue; }
}

int y = 0;
// Boucle while
while (y<5)
{
    Console.WriteLine("Je m'amuse comme un fou avec les boucles while");
    y += 1;
}

// Itération d'une liste
string[] listUsers = new string[] { "Laurent", "Karine", "Kaponk", "Edna" };

foreach (var user in listUsers)
{
    Console.WriteLine("Bonjour " + user);
}