

// Uppgift 1 - slå ihop för- och efternamn.
//

using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using static System.Runtime.InteropServices.JavaScript.JSType;

static void PrintName(string firstName, string lastName)
{
    Console.WriteLine(firstName + " " + lastName);
}

PrintName("Amanda", "Westerlind");


// Uppgift 2 - Slå ihop för- och efternamn - returnera

static string ReturnName(string firstName, string lastName)
{
    return firstName + " " + lastName;
}

string fullName = ReturnName("Amanda", "Westerlind");
Console.WriteLine(fullName);
string fullName2 = ReturnName("Joakim", "Nordström");
Console.WriteLine(fullName2);

// Uppgift 3 - Kolla om strängen är längre än ett givet antal tecken

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

// Uppgift 4 - Omvandla Celsius till Fahrenheit
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


// Uppgift 5 - Lägg in bindesträck mellan tecken i en sträng

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


// Uppgift 6 - Egen version av String.Join();

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


//BÄTTRE LÖSNING AV UPPGIFT 6
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


// Uppgift 7 - Beräkna medelvärde av int-array
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

// Uppgift 8 - Siffror till text
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


// Uppgift 9 - Heltal till text

Console.Write("Ange ett tal: ");
ushort input = ushort.Parse(Console.ReadLine());

Console.WriteLine(IntegerToText(input));


static string IntegerToText(ushort input)
{
    string writtenInteger;
    string[] ones = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    string[] tens = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};

    int restSum;

    int checksum = (input / 1000);

    

    return writtenInteger;
}
