
using BonjourConditionnel;

/// <summary>
/// Ce programme affiche :
/// - un message Bonjour personnalisé si un argument a été envoyé lors de l'exécution du programme
/// - le traditionnel message "Bonjour le monde" si ce n'est pas le cas
/// </summary>
/// <remarks>Créé par l'équipe éducative d'OpenClassrooms</remarks>

// Code with if,  else if, else condition
//if (args.Count() == 1)
//{
//    Salutation.DireBonjour(args[0]);
//}
//else if (args.Length == 2)
//{
//    Salutation.DireBonjour(args[0] + "-" + args[1]);
//}
//else
//{
//    Salutation.DireBonjour("world");
//}

// Code with switch condition
switch (args.Length)
{
    case 0: // Aucun argument n'a été envoyé
        Salutation.DireBonjour("World");
        break;
    case 1: // L'utilisateur a fourni un argument dans le terminal
        Salutation.DireBonjour(args[0]);
        break;
    case 2: // L'utilisateur a fourni 2 arguments
        Salutation.DireBonjour(args[0] + "-" + args[1]);
        break;
    default: // L'utilisateur a fourni plus d'arguments que nous ne pouvons en gérer·!
        Console.WriteLine("Désolé, je ne sais pas comment gérer plus de deux prénoms·!");
        break;
}