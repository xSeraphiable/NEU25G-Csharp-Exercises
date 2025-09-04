/*

//Uppgift 1, skriv tal 20-30

int i = 20;

while (i <= 30)
{
    Console.WriteLine(i);
    i++;
}

//Uppgift 2, jämna tal

int i = 0;

while (i <= 30)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}


//Uppgift 3, vart tredje tal

int i = 0;

while (i <= 30)
{
    if (i % 3 != 0)
    {
        Console.WriteLine(i);
    }
    else
    {
        Console.WriteLine("Hej");
    }

    i++;

}


//Uppgift 4, Gångertabell

Console.WriteLine("Skriv ett tal:");
int num = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} * {i} = {num * i}");
}


// Uppgift 5, summa

int totalSum = 0;

for (int i = 1; i <= 1000; i++)
{
      totalSum += i; // totalSum = totalSum + i
}

Console.WriteLine($"Summan av talen 1-1000 är {totalSum}");


//Uppgift 6, riskorn på ett schackbräde

double antalRiskorn = 1;
double totalSum = 0;
int rutor = 64;

for (int i = 1; i <= rutor; i++)
{
    totalSum += antalRiskorn;
    antalRiskorn *= 2; // antalRiskorn = antalRiskorn * 2
    Console.WriteLine($"Ruta {i}: {antalRiskorn}");
}

*/

//Uppgift 7, Fylld box

Console.WriteLine("Ange höjd:");
int height = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ange bredd:");
int width = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= height; i++)
{
    for (int j = 1; j <= width; j++)
    {
        Console.Write("X");
    }
    Console.WriteLine();
}


//Uppgift 8, Randig box

