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

/*

using System.Xml;

string[] siffror = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

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

for (int i = letters.Length - 1; i >= 0; i--) // loopen kommer köras lika många gånger som arrayen har bokstäver.
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
        if (vokal == myLetters[i])
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
Console.WriteLine();
Console.WriteLine();

// Uppgift 5 - Palindrom

Console.Write("Skriv ett ord för att kolla om det är en palindrom: ");
string userInput = Console.ReadLine();

var inputChar = userInput.ToCharArray();

Array.Reverse(inputChar);

string reversed = new string(inputChar);

if (reversed.ToLower() == userInput.ToLower())
{
    Console.WriteLine("Ditt ord är en palindrom.");
}
else
{
    Console.WriteLine("Ditt ord är inte en palindrom");
}


// Uppgift 6 - Miniräknare

Console.Write("Vad vill du räkna ut? ");
string calculationInput = Console.ReadLine().Trim();

string[] partsOfCalculation = calculationInput.Split(' ');

int num1 = Int32.Parse(partsOfCalculation[0]);
string @operator = partsOfCalculation[1];
int num2 = Int32.Parse(partsOfCalculation[2]);


if (@operator == "+")
{
    Console.WriteLine($" = {num1 + num2}");
}
else if (@operator == "-")
{
    Console.WriteLine($" = {num1 - num2}");
}
else if (@operator == "*")
{
    Console.WriteLine($" = {num1 * num2}");
}
else if (@operator == "/")
{
    if (num2 != 0)
    {
        Console.WriteLine($" = {num1 / num2}");
    }
    else
    {
        Console.WriteLine("Fel: Division med noll är inte tillåtet.");
    }
}
else
{
    Console.WriteLine("Fel: Ogiltig operator.");
}


// Uppgift 7 - Omvänd ordning

string[] sevenWords = new string[7];

for (int i = 0; i < sevenWords.Length; i++)
{
    Console.Write("Skriv ett ord: ");
    sevenWords[i] = Console.ReadLine();
}

for (int i = sevenWords.Length - 1; i >= 0; i--)
{
    Console.WriteLine(sevenWords[i]);
}

// Uppgift 8 - Fördröjd utskrift
// SKapa ett program som ber användaren skriva in ett ord. Sedan ett till och ett till...
// TIPS: man kan använda modulus 10 istället för att skriva 


string[] words = new string[10];
int count = 0;


while (true)
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write("Skriv ett ord: ");
        words[i] = Console.ReadLine();

        if (count < 10)
        {
            Console.WriteLine("Du har inte skrivit 10 ord än");
            count++;
            continue;
        }
        if (i == 9)
        {
            Console.WriteLine(words[0]);
        }
        else
        {
            Console.WriteLine(words[i + 1]);
        }
        count++;
    }


}

*/
/*string[] words2 = new string[10];
int count2 = 0;

while (true)
{
    Console.WriteLine("Skriv något: ");
    string input2 = Console.ReadLine();
    words[count % 10] = input2;
}

// Uppgift 9 - Bokstavspyramid

string helloWorld = "Hello World!";

for (int i = 0; i < helloWorld.Length; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(helloWorld[j]);

    }
    Console.WriteLine();
}
Console.WriteLine();


// Uppgift 10 - Färgade bokstäver

Console.Write("Mata in en text: ");
string inmatning = Console.ReadLine();
Console.Write("Välj en bokstav: ");
char letter = Char.Parse(Console.ReadLine());

for (int i = 0; i < inmatning.Length; i++)
{
    if (inmatning[i] == letter)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(inmatning[i]);
        Console.ResetColor();

    }
    else
    {
        Console.Write(inmatning[i]);
    }
}

Console.WriteLine();
// Uppgift 11 - Start & Stop

Console.Write("Mata in en text: ");
string inmatning11 = Console.ReadLine();
Console.Write("Välj startindex: ");
int indexStart = Int32.Parse(Console.ReadLine());
Console.Write($"Välj stopindex som är lägre än {inmatning11.Length - 1}: ");
int indexStop = Int32.Parse(Console.ReadLine());

for (int i = 0; i < inmatning11.Length; i++)
{

    if (i < indexStart || i > indexStop)
    {
        Console.Write(inmatning11[i]);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(inmatning11[i]);
        Console.ResetColor();
    }
    /*
    if (i < indexStart)
    {
        Console.Write(inmatning11[i]);
    }
    else if (i >= indexStart && i <= indexStop)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(inmatning11[i]);
        Console.ResetColor();
    }
    else
    {
        Console.Write(inmatning11[i]);
    }
}
*/

Console.WriteLine();

// Uppgift 12 - Växla färg

Console.Write("Mata in en text: ");
string inmatning12 = Console.ReadLine();

Console.Write("Välj en bokstav: ");
char letter12 = Char.Parse(Console.ReadLine());

int count12 = 0;

for (int i = 0; i < inmatning12.Length; i++)
{
    if (inmatning12[i] == letter12)
    {
        if (count12 % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(inmatning12[i]);
            count12++;

        }
        else
        {
            Console.Write(inmatning12[i]);
            Console.ResetColor();
            count12++;
        }
    }
    else
    {
        Console.Write(inmatning12[i]);

    }
}