
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
Console.WriteLine();

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


// UPPGIFT 5 - dubbla med grön färg

for (int i = 0; i < helloWorld.Length; i++)
{
    if (i < helloWorld.Length - 1)
    {
        if (helloWorld[i] == helloWorld[i + 1])
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(helloWorld[i]);
            Console.Write(helloWorld[i + 1]);
            Console.ResetColor();
            i++;
        }
        else
        {
            Console.Write(helloWorld[i]);
        }
    }

    else
    {
        Console.Write(helloWorld[i]);
    }


}
Console.WriteLine();

// UPPGIFT 6 - Bokstav för bokstav - grön substring
// OBS GÖR BÄTTRE... använd stringbuilder??

string woodChuckString = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string shortstring = "oo";

for (int i = 0; i < woodChuckString.Length; i++)
{
    if (i < woodChuckString.Length - 1)
    {
        if (woodChuckString[i] == shortstring[0] && woodChuckString[i + 1] == shortstring[1])
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(woodChuckString[i]);
            Console.Write(woodChuckString[i + 1]);
            Console.ResetColor();
            i++;
        }
        else
        {
            Console.Write(woodChuckString[i]);
        }
    }

    else
    {
        Console.Write(woodChuckString[i]);
    }


}
Console.WriteLine();

// UPPGIFT 7 - grön substring 2
// Samma som uppgift 6, men den mindre strängen är "chuck" istället för "oo". D.v.s. alla gånger "chuck" förekommer i den längre strängen skrivs dessa med grön text.

string shortChuck = "chuck";

int index = 0;

while (index < woodChuckString.Length)
{
    int found = woodChuckString.IndexOf(shortChuck, index, StringComparison.CurrentCultureIgnoreCase);
    if (found == -1)
    {
        Console.Write(woodChuckString.Substring(index));
        break;
    }
    
    Console.Write(woodChuckString.Substring(index, found - index));

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(woodChuckString.Substring(found, shortChuck.Length));
    Console.ResetColor();

    index = found + shortChuck.Length;
}

Console.WriteLine();


// UPPGIFT 8 - Bokstav för bokstav - grön substring 3
// Samma som uppgift 6 igen, men denna gången kan användaren mata in den kortare strängen, alltså valfri text som ska sökas (färgas grön) i den längre texten.


Console.WriteLine("Skriv in den text som ska bli grön:");
string convertToGreen = Console.ReadLine();

int j = 0;

while (j < woodChuckString.Length)
{
    int found = woodChuckString.IndexOf(convertToGreen, j, StringComparison.CurrentCultureIgnoreCase);
    if (found == -1)
    {
        Console.Write(woodChuckString.Substring(j));
        break;
    }

    Console.Write(woodChuckString.Substring(j, found - j));

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(woodChuckString.Substring(found, convertToGreen.Length));
    Console.ResetColor();

    j = found + convertToGreen.Length;
}

Console.WriteLine();

// Uppgift 9 - Bokstavspyramid
// Utgå från strängen "Hello world!". Gör ett program som skriver ut första bokstaven en gång på första raden. 
// Andra bokstaven 2 gånger på andra raden. Tredje 3 gånger på nästa rad osv. 

