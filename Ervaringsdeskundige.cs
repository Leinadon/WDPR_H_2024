using System;
using System.Globalization;
using System.Linq.Expressions;


public class Ervaringsdeskundige : Gebruiker
{
    private string? Benaderingsvoorkeur {get; set;}
    private DateTime? Beschikbaarheid { get; set; }
    private bool? BenaderingCommercielePartijen {get; set;}
    private bool? HeeftVoogd {get; set;}
    private List<Onderzoek> Onderzoeken = new List<Onderzoek>();
    public Ervaringsdeskundige(string voornaam, string achternaam, string postcode, string email, string? telefoonnummer, string? benaderingsvoorkeur, DateTime?  beschikbaarheid, bool? BenaderingCommercielePartijen, bool? heeftVoogd)
    {   
        this.Voornaam = voornaam;
        this.Achternaam = achternaam;
        this.Postcode = postcode;
        this.Email = email;
        this.Telefoonnummer = telefoonnummer;
        this.Rol = "Ervaringsdeskundige";
        this.ID = GetNextID();
        this.Created = setDateTimeNow();
        this.LastUpdate = setDateTimeNow();
        this.Benaderingsvoorkeur = benaderingsvoorkeur;
        this.Beschikbaarheid = beschikbaarheid;
        this.BenaderingCommercielePartijen = BenaderingCommercielePartijen;
        this.HeeftVoogd = heeftVoogd;
    }

    public void addNewOnderzoek(Onderzoek onderzoek){
        Onderzoeken.Add(onderzoek);
    }
}
    






