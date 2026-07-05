using System.ComponentModel.DataAnnotations;

namespace AuthenticationData;

public class Login(string vorname, string name, string email, DateTime geburtsdatum, int postleitzahl, string ort)
{
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Der Vorname muss zwischen 3 und 100 Zeichen lang sein.")]
    public string Vorname { get; set; } = vorname;

    [StringLength(100, MinimumLength = 3, ErrorMessage = "Der Name muss zwischen 3 und 100 Zeichen lang sein.")]
    public string Name { get; set; } = name;

    [EmailAddress(ErrorMessage = "Bitte geben Sie eine gültige E-Mail-Adresse ein.")]
    public string Email { get; set; } = email;

    public DateTime Geburtsdatum { get; set; } = geburtsdatum;

    public int Postleitzahl { get; set; } = postleitzahl;

    [StringLength(100, MinimumLength = 6, ErrorMessage = "Das Passwort muss zwischen 6 und 100 Zeichen lang sein.")]
    public string Ort { get; set; } = ort;
}
