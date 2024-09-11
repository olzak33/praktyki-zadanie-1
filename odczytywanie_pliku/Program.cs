using System;
using System.IO;
using System.Text;
using System.Globalization;

class main
{
    static void Main(string[] args) //main jest pierwszą wywoływaną metodą
    {
        string filePath = "C:/test/test_ale_zaw.txt"; //scieżka do pliku staje sie "filePath"

        try //try sluzy do testowania kodu podczas jego wykonywania 
        {
            string zawartosc = File.ReadAllText(filePath); //ta linijka czyta zawartisc filePath
            Console.WriteLine("zawartosc pliku: "); // wyswietla zawartosc pliku    
            Console.WriteLine(zawartosc);   // wyswietla zawartosc pliku

            int liczbaA = 0; //ustawia początkową wartosc dla "liczbaA" na 0
            foreach (char C in zawartosc) //foreach daje instrukcje dla danego bloku
            {
                if (C == 'a') // fukcja if ktora dziala w sposob ze zlicza litery 'a' w pliku i dodaje do sumy czyli "liczbaA" dodaje pojedynczo dzieki 2 plusom na konu
                {
                    liczbaA++;
                }
            }

            Console.WriteLine($"\nliczba liter 'a' w pliku {liczbaA}"); // najpierw wypisuje podane zdanie: "liczba liter 'a '..." potem dodaje do tego zdania sume "liczbaA"
        }

        catch (Exception e) //catch sluzy do zdefinowania akcji jaka zostanie wykonana jesli "try" wykreje blad 
        {
            Console.WriteLine("wystąpil błąd podczas odczytu pliku "); 
            Console.WriteLine(e.Message); // jesli try wykryje blad to catch wyswietli ta wiadomosc
        }

    }
}