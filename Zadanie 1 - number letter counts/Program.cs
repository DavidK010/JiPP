// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int liczba = 0;
Console.Write("Podaj swoją liczbę: "); 


try //blok kodu do sprawdzenia
{
    liczba = Convert.ToInt32(Console.ReadLine());//próba przekonwertowania inputu usera na liczbe
}
catch //blok kodu w przypadku wystąpienia błędu w try
{
    Console.WriteLine("Nieprawidłowe dane wejściowe");
    return;
}

if (liczba == 0)
{
    Console.WriteLine("Zero!");
    return; 
}
if(liczba == 1000)
{
    Console.WriteLine("Tysiąc!");
    return;
}
else if (liczba < 0)
{
    Console.WriteLine("Minus " + NaPolski(Math.Abs(liczba)));
}    


Console.WriteLine(NaPolski(liczba)); //wywołanie metody NaPolski na ekran


static string NaPolski(int liczba)
{

    //Tablica elementów string do tłumaczenia zmiennej liczba na jezyk polski
    string[] jednostki = { "", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };
    string[] nastki = { "dziesięć", "jedenaście", "dwanaście", "trzynaście", "czternaście", "piętnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewiętnaście" };
    string[] dziesiatki = { "", "dziesięć", "dwadzieścia", "trzydzieści", "czterdzieści", "pięćdziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt" };
    string[] setki = { "", "sto", "dwieście", "trzysta", "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset" };

    string wynik = "";//zmienna do przechowywania wyniku tlumaczenia
    if ((liczba / 100) > 0)
    {
        wynik += setki[liczba / 100] + " ";
        liczba %= 100;
    }

    if (liczba >= 10 && liczba <= 19)
    {
        wynik += nastki[liczba - 10] + " ";
        liczba = 0;
    }
    else if (liczba >= 20)
    {
        wynik += dziesiatki[liczba / 10] + " ";
        liczba %= 10;
    }

    if (liczba > 0)
    {
        wynik += jednostki[liczba] + " ";
    }


    return wynik;
}