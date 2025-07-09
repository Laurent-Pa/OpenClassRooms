int numerateur = 10;
int denominateur = 4;

// TODO : modifier l'instruction ci-dessous pour que la réponse prenne une valeur décimale
double reponse = numerateur / (double) denominateur;

// Afficher le résultat
Console.WriteLine(numerateur + " / " + denominateur + " = " + reponse);


// concatenation de chaînes de caractère
string premiereVillePreferee = "New York";
string secondeVillePreferee = "Buenos Aires";

string favoris = premiereVillePreferee + " " + secondeVillePreferee;
// -> «·New YorkBuenos Aires·»
Console.WriteLine(favoris);

// On peut déclarer une variable sans lui donner de type --> var = "" ou 3
// le compilateur va déduire s'il s'agit d'une string ou int
