// Définir l'URL à laquelle se connecter
using P2C5._2;
using System.Net.Http;


string chaineUrl = DonneeUtilisateur.DemanderUneUrl();

// on n'affiche plus le contenu en console
//string resultat = await RecupererContenu(chaineUrl);
// Console.WriteLine(resultat); 

var contenu = await RecupererContenu(chaineUrl);

try
{
    EcrireFichier.Ecrire(contenu, "output.txt");
}
catch (IOException e)
{
    Console.WriteLine("Impossible d'écrire dans le fichier - " + e.ToString());
}

/// <summary>
/// Retourner le contenu de l'URL
/// </summary>
/// <param name="url">L'adresse Web dont le contenu sera renvoyé</param>
async Task <string> RecupererContenu(string url)
{
    string contenu = "";
    try
    {
        using (HttpClient client = new HttpClient())
        {
            contenu = await client.GetStringAsync(url);
        }
    }
    catch (HttpRequestException e)
    {
        Console.WriteLine("Impossible d'établir une connexion - " + e.ToString());
    }

    return contenu;

}
