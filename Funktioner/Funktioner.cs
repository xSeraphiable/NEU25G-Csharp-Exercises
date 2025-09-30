using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


Console.WriteLine("=== Uppgiftsmeny FUNKTIONER ===");
Console.WriteLine("Välj uppgift (1-13): ");

if (int.TryParse(Console.ReadLine(), out int choice))
{
    switch (choice)
    {
        case 1: Uppgift1.Run(); break;
        case 2: Uppgift2.Run(); break;
        case 3: Uppgift3.Run(); break;
        case 4: Uppgift4.Run(); break;
        case 5: Uppgift5.Run(); break;
        case 6: Uppgift6.Run(); break;
        case 7: Uppgift7.Run(); break;
        case 8: Uppgift8.Run(); break;
        case 9: Uppgift9.Run(); break;
        case 10: Uppgift10.Run(); break;
        case 11: Uppgift11.Run(); break;
        case 12: Uppgift12.Run(); break;
        case 13: Uppgift13.Run(); break;
        default:
            Console.WriteLine("Ogiltigt val.");
            break;
    }
}
else
{
    Console.WriteLine("Du måste skriva ett tal!");
}



// === Uppgifter ===

class Uppgift1
{
    public static void Run()
    {
        Console.WriteLine("Uppgift 1 - slå ihop för- och efternamn.");

        static void PrintName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        PrintName("Amanda", "Westerlind");

    }
}

class Uppgift2
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 2 - Slå ihop för- och efternamn - returnera\n");

        static string ReturnName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        string fullName = ReturnName("Amanda", "Westerlind");
        Console.WriteLine(fullName);
        string fullName2 = ReturnName("Joakim", "Fjäll");
        Console.WriteLine(fullName2);
    }
}

class Uppgift3
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 3 - Kolla om strängen är längre än ett givet antal tecken\n");


        static bool LongerThan(string word, int length)
        {
            if (word.Length > length)
            {
                return true;
            }
            return false;

        }

        bool isItLonger = LongerThan("amanda", 2);

        Console.WriteLine(isItLonger);
    }
}

class Uppgift4
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 4 - Omvandla Celsius till Fahrenheit\n");

        Console.WriteLine();
        static double CelsiusToFahrenheit(double celsius)
        {
            double farenheit = (celsius * 1.8) + 32;
            return farenheit;
        }

        Console.WriteLine("Ange en temperatur i Celsius:");
        double celsius = Double.Parse(Console.ReadLine());

        double farenheit = (CelsiusToFahrenheit(celsius));

        Console.WriteLine($"{celsius}°C blir {farenheit}°F");



    }
}

class Uppgift5
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 5 - Lägg in bindesträck mellan tecken i en sträng\n");

        Console.WriteLine();
        static string AddHyphen(string word)
        {
            char[] addedHyphen = new char[word.Length * 2 - 1];

            for (int i = 0; i < (addedHyphen.Length); i++)
            {
                if (i % 2 == 0)
                {
                    addedHyphen[i] = word[i / 2];
                }
                else
                {

                    addedHyphen[i] = '-';
                }

            }

            string retur = new string(addedHyphen);

            return retur;
        }

        string addedHyphen = (AddHyphen("Amanda"));
        Console.WriteLine(addedHyphen);
    }
}

class Uppgift6
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 6 - Egen version av String.Join();\n");

        Console.WriteLine();
        static string MyJoin(params string[] words)
        {
            string[] result = new string[(words.Length * 2 - 3)];
            int countIndex = 1;

            for (int i = 0; i < (result.Length); i++)
            {
                if (i % 2 != 0)
                {
                    result[i] = words[0];
                }
                else
                {
                    result[i] = words[countIndex];
                    countIndex++;
                }

            }

            var results = string.Empty;
            foreach (var item in result)
            {
                results += item;
            }

            return results;
        }

        string joinedText = (MyJoin("->", "Göteborg", "Sundsvall", "Stockholm", "Luleå", "Malmö", "Uppsala", "Halmstad"));
        Console.WriteLine(joinedText);

        RunBetter();
    }

    public static void RunBetter()
    {
        Console.WriteLine("Bättre lösning\n");
        static string MyJoin2(string separator, params string[] words)
        {

            string result = string.Empty;

            result = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                result += separator + words[i];
            }

            return result;

        }

        string joinedText2 = (MyJoin2("->", "Göteborg", "Sundsvall", "Stockholm", "Luleå", "Malmö"));
        Console.WriteLine(joinedText2);
    }


}

class Uppgift7
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 7 - Beräkna medelvärde av int-array\n");

        // 
        Console.WriteLine();
        static double medianValue(params int[] numbers)
        {

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double median = sum / numbers.Length;

            return median;
        }

        Console.WriteLine("Medianen blir: " + medianValue(1, 2, 5, 10, 6, 90, 135));
    }
}

class Uppgift8
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 8 - Siffror till text\n");
        // 
        Console.WriteLine();
        static string[] NumbersToWords(params int[] numbers)
        {
            string[] numbersInText = new string[numbers.Length];
            string[] siffror = { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersInText[i] = siffror[numbers[i]];
            }

            return numbersInText;
        }

        string[] numbersInText = (NumbersToWords(1, 2, 3, 4));

        foreach (var i in numbersInText)
        {
            Console.Write(i + " ");
        }

    }
}

class Uppgift9
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 9 - Heltal till text\n");

        Console.WriteLine();
        Console.Write("Ange ett tal: ");
        ushort input = ushort.Parse(Console.ReadLine());

        Console.WriteLine(IntegerToText(input));


        static string IntegerToText(ushort input)
        {
            string writtenInteger = "";
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };


            int checksum = (input / 1000);
            int restsum = input % 1000;

            if (checksum > 19)
            {

            }
            else if (checksum > 0)
            { writtenInteger += ones[checksum] + " thousand"; }

            checksum = (restsum / 100);
            restsum = restsum % 100;
            if (checksum > 0)
            { writtenInteger += " " + ones[checksum] + " hundred"; }

            checksum = restsum / 10;
            restsum = restsum % 10;
            if (checksum > 1)
            { writtenInteger += " " + tens[checksum - 2]; }
            else if (checksum > 0)
            {
                writtenInteger += " " + ones[checksum + 10];
            }

            if (restsum > 19)
            {
                writtenInteger += " " + ones[restsum];
            }


            return writtenInteger;
        }

    }
}

class Uppgift10
{
    public static void Run()
    {
        Console.WriteLine("Uppgift 10 är inte klar.");
    }
}

class Uppgift11
{
    public static void Run()
    {
        Console.WriteLine("Uppgift 11 är inte klar.");
    }
}

class Uppgift12
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 12 - Rita en box\nSkriv en funktion DrawBox(int width, int height).\nNär man anropar funktionen ska den skriva ut en rektangel där de yttre tecknen består av ‘#’ och de inre av ‘-’.\n");

        // Exempel: DrawBox(7, 4);

        // #######
        // #-----#
        // #-----#
        // #######

        // Extrauppgift: Uppdatera funktionen och lägg till parametrar left och top (för positionen på översta vänstra hörnet av boxen.
        // Skriv en loop som printar ut rektanglar med random storlek och position på skärmen.

        Console.Write("Ange bredd i heltal: ");
        int width = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Ange höjd i heltal: ");
        int height = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        DrawBox(width, height);

        static void DrawBox(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

            for (int i = 1; i < height - 1; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || j == width - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine();

            }

            for (int i = 0; i < width; i++)
            {
                Console.Write("#");
            }

            Console.WriteLine();

        }

    }
}


class Uppgift13
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 13 - Flytta runt ett @ med piltangenterna.\n");
        //
        //Låt oss skriva början till ett enkelt spel:

        //Använd DrawBox-funktionen i föregående uppgift för att rita en box på skärmen. Placera sedan ett @ i mitten av boxen.
        //Om man använder piltangenterna ska man kunna flytta runt @.
        //När den kommer till kanten av boxen så ska den inte kunna gå längre åt det hållet.

        //Tips: För att flytta @ behöver du skriva ‘-’ på dess tidigare position och ‘@’ på den nya positionen.
        //Spara bredd och höjd på boxen så du vet när den ska stanna.

        //Tips: Kolla upp Console.ReadKey(); och Console.KeyAvailable;

        Console.Write("Ange bredd i heltal: ");
        int width = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Ange höjd i heltal: ");
        int height = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        DrawBox(width, height);

        int x = width / 2;
        int y = height / 2;

        static void DrawBox(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

            for (int i = 1; i < height - 1; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || j == width - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }

                Console.WriteLine();

            }

            for (int i = 0; i < width; i++)
            {
                Console.Write("#");
            }

            Console.WriteLine();

        }

    }
}


    }
}


















