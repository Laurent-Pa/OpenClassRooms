using P1C4;
// TODO, étape 1 : instancier un objet de la classe Livre et affecter cet objet à une variable nommée monLivre
// Livre monLivre = new Livre("Le meilleur des mondes", "Aldous Huxley", 432);
Livre monLivre = new Livre();
// TODO, étape 2 : affecter une valeur aux champs titre, auteur et nombre de pages de votre objet
monLivre.Titre = "Le meilleur des mondes";
monLivre.Auteur = "Aldous Huxley";
monLivre.NombreDePages = 421;
// Afficher le contenu des champs de cet objet
Console.WriteLine("Le titre du livre est " + monLivre.Titre);
Console.WriteLine("Son auteur est " + monLivre.Auteur);
Console.WriteLine("Il compte " + monLivre.NombreDePages +" pages.");
