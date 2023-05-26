// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int limit = 10000; //limit iteracji
int poczatek = 0; //początkowa liczba
int najdluzszy = 0; //najdłuższa sekwencja

for (int i = 1; i < limit; i++) // pętla iteracyjna od 1 do limitu
{
    //dla każdej liczby i: inicjalizuje zmienną 'cyfra' jako 'i'(aktualna liczba iteracji) oraz zmienna 'dlugoscLancucha' na 1
    int cyfra = i;
    int dlugoscLancucha = 1;
    while (cyfra != 1)
    {
        if (cyfra % 2 == 0)
            cyfra = cyfra / 2;
        else
            cyfra = 3 * cyfra + 1;

        dlugoscLancucha++;
    }
    //po wyjsciu z pętli mamy długość sekwencji Collatza dla liczby i


    if (dlugoscLancucha > najdluzszy)
    {
        najdluzszy = dlugoscLancucha;
        poczatek = i;
    }

}

Console.WriteLine("Cyfra posiadająca najdłuższy łańcuch Collatza to: " + poczatek);