using System;

// Klasa bazowa zwierzę, która reprezentuje ogolną koncepcję zwierzęcia
public class Zwierze
{
    //virtual oznacza, że metoda może zostać przesłonięta w klasach potomnych
    public virtual void WydajDzwiek()
    {
        Console.WriteLine("Nieznany dźwięk");
    }
}

// Klasa potomna pies, która dziedziczy po klasie Zwierze. Klasa Pies jest 'rodzajem' zwierzęcia
public class Pies : Zwierze
{
   
    public override void WydajDzwiek() //przesłonięta metoda public virtual void WydajDzwiek() w klasie Pies
    {
        Console.WriteLine("Hau Hau! HAUHAUHAU!!!!");
    }
}

// Klasa potomna kot
public class Kot : Zwierze
{
    public override void WydajDzwiek()
    {
        Console.WriteLine("Miau Miau Miauuuuuuuu!");
    }
}

// Klasa potomna królik
public class Krolik : Zwierze
{
    public override void WydajDzwiek()
    {
        Console.WriteLine("KrrKrrrrr!");
    }
}

// Klasa potomna ptak
public class Ptak : Zwierze
{
    public override void WydajDzwiek()
    {
        Console.WriteLine("CzyCzy!");
    }
}

// Klasa potomna wąż
public class Waz : Zwierze
{
    public override void WydajDzwiek()
    {
        Console.WriteLine("Sssssss!");
    }
}

class Program
{
    //Tworzymy tablice zwierzeta, ktora zawiera obiekty naszych typów zwierząt
    static void Main(string[] args)
    {
        Zwierze[] zwierzeta = new Zwierze[]
        {
            new Pies(),
            new Kot(),
            new Krolik(),
            new Ptak(),
            new Waz()
        };
        //pętla iteruje każdy obiekt z tablicy zwierzeta
        foreach (Zwierze zwierze in zwierzeta)
        {
            Console.Write(zwierze + " wydaje dźwięk: "); 
            zwierze.WydajDzwiek();
            //wywołujemy metodę WydajDzwiek() na obiekcie zwierze.
            //Dzieki polimorfizmowi, wywoałamy właściwą implementację metody dla danego rodzaju zwierzaka.
            //W przypadku obiektu klasy Pies, wywołamy implementację WydajDzwiek(), ktora jest zdefiniowana w klasie Pies
        }
    }
}