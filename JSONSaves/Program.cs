

using System.Text.Json;
using JSONSaves;


User? user = null;
try
{
    string save = File.ReadAllText("./save.json");
    Console.WriteLine($"Fichier : {save}");
    user = JsonSerializer.Deserialize<User>(save);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

if (user is null)
{
    Console.WriteLine("Entrez votre nom");
    
    string name = Console.ReadLine();
    
    Console.WriteLine("Entrez votre Prenom");
    
    string firstname = Console.ReadLine();
    
    Console.WriteLine("Entrez votre id");
    
    int id = Int32.Parse(Console.ReadLine());

    user = new User(id, name, firstname);

    string jsonUser = JsonSerializer.Serialize(user);
    
    
    
    File.WriteAllText("./save.json", jsonUser );
}

Console.WriteLine($"Bonjour {user.Prenom} {user.Nom}, votre id est le {user.id}");