

// Uppgift 1 - slå ihop för- och efternamn.
//

using System;

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



// Uppgift 6 - Egen version av String.Join();
