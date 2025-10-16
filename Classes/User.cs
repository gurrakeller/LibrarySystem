namespace Librarysystem.Classes;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Adress { get; set; }

    public User(string name, string email, string adress)
    {
        Name = name;
        Email = email;
        Adress = adress;
    }
}