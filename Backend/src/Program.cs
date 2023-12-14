using System;
//Elke attribuut moet een property hebben (get;set;) en we moeten dat annotaties maken.
//We moeten werken met EFCore --> les met ORM legt uit hoe we dit moeten doen.
//Database seeden (toevoegen van gegevens) --> Les met ORM --> Slide 28, Modelbuilder.
//Gebruik maken van Lazyloading --> Microsoft.EntityFrameworkCore.Proxies --> UseLazyLoadingProxies() aanroepen --> Kan veranderd zijn.

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("De applicatie wordt nu gestart");
    }
}