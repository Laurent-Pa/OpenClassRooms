
using BonjourConditionnel;

/// <summary>
/// Ce programme affiche :
/// - un message Bonjour personnalisé si un argument a été envoyé lors de l'exécution du programme
/// - le traditionnel message "Bonjour le monde" si ce n'est pas le cas
/// </summary>
/// <remarks>Créé par l'équipe éducative d'OpenClassrooms</remarks>

if (args.Count() == 1)
{
    Salutation.DireBonjour(args[0]);
}
else if (args.Length == 2)
{
    Salutation.DireBonjour(args[0] + "-" + args[1]);
}
else
{
    Salutation.DireBonjour("world");
}
