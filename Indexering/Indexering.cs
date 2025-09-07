//Uppgift 1 - En bokstav på varje rad
/*
Console.Write("Skriv en textrad:");
string text = Console.ReadLine();
var lista = text.ToCharArray();

for (int i = 0; i < lista.Length; i++)
{
    Console.WriteLine(lista[i]);
}*/

// Uppgift 2 - Siffror till text *Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror, om man skriver in t.ex 432 så svarar programmet: “fyra-tre-två”.*

using System.Xml;

string[] siffror =  {"noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"};

Console.WriteLine("Skriv ett valfritt antal siffror:");
string sifferinmatning = Console.ReadLine();

int[] input = new int[sifferinmatning.Length];

for (int i = 0; i < input.Length; i++)
{
    input[i] = sifferinmatning[i] - '0';
}

for (int i = 0; i < input.Length; i++)
{
    Console.Write(siffror[input[i]]);
    if (i < input.Length - 1)
    {
        Console.Write("-");
    }
}
Console.WriteLine();
Console.WriteLine();

// Uppgift 3 - Baklänges

Console.WriteLine("Skriv något:");
string textrad = Console.ReadLine();

var letters = textrad.ToCharArray(); // den inmatade texten görs om till en array av typen char

for (int i = letters.Length-1;  i >= 0; i--) // loopen kommer köras lika många gånger som arrayen har bokstäver.
                                             // letters.Length = antal bokstäver i arrayen, måste ta -1 eftersom index börjar på 0.
{
    Console.Write(letters[i]); // använder Console.Write för att ingen radbrytning ska göras. All text hamnar på samma rad.
}
Console.WriteLine();
Console.WriteLine("End");

// Uppgift 4 - Dölj vokaler

char[] vokaler = { 'a', 'i', 'e', 'u', 'o', 'y', 'å', 'ä', 'ö' };

Console.WriteLine("\nSkriv en mening:");
string sentence = Console.ReadLine().ToLower();

var myLetters = sentence.ToCharArray();

for (int i = 0; i < sentence.Length; i++)
{
    foreach (char vokal in vokaler)
    {
        if (vokal==myLetters[i])
        {
            myLetters[i] = '*';
        }
    }
}

Console.WriteLine();

foreach (char letter in myLetters)
{
    Console.Write(letter);
}