using System.ComponentModel.DataAnnotations;

namespace Authentication_Data;

public class Login
{
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Der Vorname muss zwischen 3 und 100 Zeichen lang sein.")]
    public required string Vorname { get; set; }

    [StringLength(100, MinimumLength = 3, ErrorMessage = "Der Name muss zwischen 3 und 100 Zeichen lang sein.")]
    public required string Name { get; set; }

    [EmailAddress(ErrorMessage = "Bitte geben Sie eine gültige E-Mail-Adresse ein.")]
    public required string Email { get; set; }

    public DateTime Geburtsdatum { get; set; }

    public int Postleitzahl { get; set; }

    [StringLength(100, MinimumLength = 6, ErrorMessage = "Das Passwort muss zwischen 6 und 100 Zeichen lang sein.")]
    public required string Ort { get; set; }

}
