using System;
using System.Collections.Generic;

//Console.WriteLine("zzzz");

Ksiazka ksiazka1 = new Ksiazka("Ksiazka1", "Autor1", 1763, "Wydawca1", "ISBN1", "Gatunek1", 3);
Ksiazka ksiazka2 = new Ksiazka("Ksiazka2", "Autor2", 1963, "Wydawca2", "ISBN2", "Gatunek2", 14);

Biblioteka biblioteka = new Biblioteka();
biblioteka.dodajKsiazke(ksiazka1);
biblioteka.dodajKsiazke(ksiazka2);


List<Ksiazka> szukaj = biblioteka.poTytule("Autor1");
foreach (Ksiazka ksiazka in szukaj)
{
    Console.WriteLine("Tytul: " + ksiazka.Tytul);
    Console.WriteLine("Autor: " + ksiazka.Autor);
}




//Klasa reprezentująca książkę
public class Ksiazka
{
    public string Tytul { get; set; }
    public string Autor { get; set; }
    public int RokWydania { get; set; }
    public string Wydawca { get; set; }
    public string ISBN { get; set; }
    public string Gatunek { get; set; }
    public int DostepneEgz { get; set; }


    public Ksiazka(string tytul, string autor, int rokwydania, string wydawca, string isbn, string gatunek, int dostepneegz)
    //Konstruktor klasy Ksiazka, który inicjalizuje obiekt Ksiazka
    {
        Tytul = tytul;
        Autor = autor;
        RokWydania = rokwydania;
        Wydawca = wydawca;
        ISBN = isbn;
        Gatunek = gatunek;
        DostepneEgz = dostepneegz;
    }

}

//Klasa reprezentujaca biblioteke
public class Biblioteka
{
    private List<Ksiazka> ksiazkiLista;//Lista przechowujaca ksiazki

    public Biblioteka()
    {
        ksiazkiLista = new List<Ksiazka>();
    }

    public void dodajKsiazke(Ksiazka ksiazka)
    {
        ksiazkiLista.Add(ksiazka);
    }

   

    public List<Ksiazka> poTytule(string tytul)
    {
        return ksiazkiLista.FindAll(b => b.Tytul.Contains(tytul));
        //b przyjmuje postac obiektu typu Ksiazka, b.tytul.contains(tytul) sprawdza, czy tytul znajduje sie w tytule ksiazki b
    }

}

