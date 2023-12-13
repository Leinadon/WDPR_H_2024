using System;
using System.Globalization;
using System.Linq.Expressions;


public class Ervaringsdeskundige : Gebruiker
{
    public string? Benaderingsvoorkeur {get; set;}
    public DateTime? Beschikbaarheid { get; set; }
    public bool? BenaderingCommercielePartijen {get; set;}
    public bool? HeeftVoogd {get; set;}
    public List<Onderzoek> Onderzoeken = new List<Onderzoek>();
    public Ervaringsdeskundige(string voornaam, string achternaam, string postcode, string email, string? telefoonnummer, string? benaderingsvoorkeur, DateTime?  beschikbaarheid, bool? BenaderingCommercielePartijen, bool? heeftVoogd)
    {   
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        this.Postcode = postcode;
        this.Email = email;
        this.Telefoonnummer = telefoonnummer;
        this.Rol = "Ervaringsdeskundige";
        this.ID = GetNextID();
        this.Benaderingsvoorkeur = benaderingsvoorkeur;
        this.Beschikbaarheid = beschikbaarheid;
        this.BenaderingCommercielePartijen = BenaderingCommercielePartijen;
        this.HeeftVoogd = heeftVoogd;
    }

    public void VoegNieuweOnderzoekToe(Onderzoek onderzoek){
        Onderzoeken.Add(onderzoek);
    }
}
    






