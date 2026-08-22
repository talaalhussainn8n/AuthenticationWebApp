using System.Security.Cryptography;
using System.Text;

namespace AuthenticationData;

public class Login
{
    public string Password { get; set; }
    
    public string Username { get; set; }
    
    public string EmailAdresse { get; set; }

    public string Phonenummer { get; set; }

    public string Benutzer { get; set; }

    public Login(string name, string emailAdresse, string telephonenummer, string pasword, string benutzer)
    {
        this.Username = name;
        this.EmailAdresse = emailAdresse;
        this.Phonenummer = telephonenummer;
        this.Password = pasword;
        this.Benutzer = benutzer;
    }

    public static string GenerateHashedPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(hashedBytes);
    }
}
