namespace JSONSaves;

public class User
{

    public int id;

    public User()
    {
        
    }
    public User(int id, string nom, string prenom)
    {
        this.id = id;
        Nom = nom;
        Prenom = prenom;
    }

    public string Nom { get; set; }

    public string Prenom { get; set; }
    
    
}