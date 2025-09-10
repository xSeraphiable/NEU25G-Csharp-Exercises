
// UPPGIFT 1 - Bokstav för bokstav - fram till space

using System;

string helloWorld = "Hello World!";

for (int i = 0; i < helloWorld.Length; i++)
{
    if (helloWorld[i] == ' ')
    {
        break;
    }

    Console.Write(helloWorld[i]);

}
Console.WriteLine();

// UPPGIFT 2 - Bokstav för bokstav - radbyte på space


string lotsOfWords = "Det här är bara en massa ord utan någon mening.";

for (int i = 0; i < lotsOfWords.Length; i++)
{
    if (lotsOfWords[i] == ' ')
    {
        Console.WriteLine();
        continue;
    }

    Console.Write(lotsOfWords[i]);

}

Console.WriteLine();
// UPPGIFT 3 - varannan stjärna

string uppgift3 = "Detta är uppgift 3.";

for (int i = 0; i < uppgift3.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(uppgift3[i]);
    }
    else
    {
      
         Console.Write("*");
       
    }

}

// UPPGIFT 4 - gröna o, röda l



for (int i = 0; i < helloWorld.Length; i++)
{
    if (helloWorld[i] == 'o')
    {
       Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(helloWorld[i]);
        Console.ResetColor();
    }
    else if (helloWorld[i] == 'l')
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(helloWorld[i]);
        Console.ResetColor();
    }
    else
    {
        Console.Write(helloWorld[i]);
    }

}
Console.WriteLine();