// Nettoyer le code en utilisant des méthodes pour les éléments qui sont répétés

//Code à factoriser pour l'exercice -> mis en commentaire sinon s'execute à la place du reste du code

//Console.WriteLine("Essayons une addition !");
//int x = 1;
//int y = 2;
//int z = x + y;
//Console.WriteLine("La somme est de " + z);

//Console.WriteLine("Essayons une addition !");
//int i = 3;
//int j = 4;
//int k = i + j;
//Console.WriteLine("La somme est de " + k);

//Console.WriteLine("Essayons une addition !");
//int var1 = 5;
//int var2 = 6;
//int var3 = var1 + var2;
//Console.WriteLine("La somme est de " + var3);


public class Calculs
{
    // Si la méthode Additionner n'est pas statique, il faut créer une instance dans Main
    public void Additionner(int x,  int y)
    {
        Console.WriteLine("Essayons une addition !");
        int z = x + y;
        Console.WriteLine("La somme est de " + z);
    }


    // Si la méthode Additionner est statique, pas besoin d'une instance dans Main
    public static void AdditionnerStatic(int x, int y)
    {
        Console.WriteLine("Essayons une addition statique!");
        int z = x + y;
        Console.WriteLine("La somme est de " + z);
    }


    public static void Main(string[] args) // Il ne peut y avoir qu'une seule fonction main
    {
        // Appel de la méthode non statique
        Calculs calc = new Calculs();
        calc.Additionner(1,2);
        calc.Additionner(3,4);
        calc.Additionner(5,6);

        // Appel de la méthode statique
        AdditionnerStatic(1, 2);
        AdditionnerStatic(3, 4);
        AdditionnerStatic(54, 6);
    }
}
