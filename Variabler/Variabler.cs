
/*
//Uppgift 1
Console.WriteLine("Vänligen ange ditt namn:");
string namn = Console.ReadLine();   
Console.WriteLine($"Hej {namn}, välkommen till C#!");

//Uppgift 2
Console.WriteLine("\nSkriv ett tal:");
int x = Int32.Parse(Console.ReadLine());
Console.WriteLine("Skriv ett tal till:");
int y = Int32.Parse(Console.ReadLine());
Console.WriteLine($"{x} * {y} blir {x*y}");

//Uppgift 3, verifiera lösenord

string password = "lkj123!";

Console.WriteLine("\nAnge lösenord:");
if (Console.ReadLine() == password)
{
    Console.WriteLine("Lösenordet är korrekt!");
}
else
{
    Console.WriteLine("Fel lösenord!");
}

//Uppgift 4, jämför tal

Console.WriteLine("\nSkriv ett tal:");
int a = Int32.Parse(Console.ReadLine());

if (a > 100)
{
    Console.WriteLine("Ditt tal är större än 100.");
}
else if (a < 100)
{
    Console.WriteLine("Ditt tal är mindre än 100.");
}
else
{
    Console.WriteLine("Ditt tal är exakt 100.");
}


//Uppgift 5, dubblera och halvera tal

Console.WriteLine("Skriv ett tal:");
int b = Int32.Parse(Console.ReadLine());

Console.WriteLine($"{b*2} är dubbelt så stort som ditt tal. {b/2.0} är hälften så stort som ditt tal.");


//Uppgift 6, miniräknare

Console.WriteLine("Ange ett tal:");
double num1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Välj operator: +, -, * eller /");
string op = Console.ReadLine();
Console.WriteLine("Ange ett tal till:");
double num2 = Double.Parse(Console.ReadLine());

if (op == "+")
{
    Console.WriteLine($"{num1} + {num2} = {num1+num2}");
}
else if (op == "-")
{
    Console.WriteLine($"{num1} - {num2} = {num1-num2}");
}
else if (op == "*")
{
    Console.WriteLine($"{num1} * {num2} = {num1*num2}");
}
else if (op == "/")
{
    if (num2 != 0)
    {
        Console.WriteLine($"{num1} / {num2} = {num1/num2}");
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

*/

//Uppgift 7, summa och medelvärde

bool inputIsANumber = true;

int x = 0;
int count = 0;

while (inputIsANumber)
{
    Console.WriteLine("\nAnge ett tal:");
    inputIsANumber = Int32.TryParse(Console.ReadLine(), out int number);

    x += number;
    count++;

    Console.WriteLine($"Totalen är {x}");
}   

Console.WriteLine($"Medelvärdet av angivna tal är {(double)x/count}");
