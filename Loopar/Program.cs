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

Console.WriteLine("Ange höjd:");
int height = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ange bredd:");
int width = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= height; i++)
{
    
    for (int j = 1; j <= width; j++)
    {
        if (j % 2 == 0)
        {
            Console.Write("O");
        }
        else
        {
            Console.Write("X");
        }

    }
    Console.WriteLine();
}


//Uppgift 9, rutig box

Console.WriteLine("Ange höjd:");
int height = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ange bredd:");
int width = Int32.Parse(Console.ReadLine());


for (int i = 1; i <= height; i++) //yttre loopen upprepas lika många gånger som höjden
{

    for (int j = 1; j <= width; j++) //inre loopen upprepas lika många gånger som bredden
    {
        if (i % 2 == 0) //om raden är jämn
        {
            if (j % 2 == 0)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }

        }
        else //om raden är udda
        {
            if (j % 2 == 0)
            {
                Console.Write("O");
            }
            else
            {
                Console.Write("X");
            }
        }
    }

    Console.WriteLine(); //efter varje rad är klart görs en radbrytning och den inre loopen börjar om tills höjden är uppnådd
}

//Uppgift 10, Ihålig box

Console.WriteLine("Ange höjd:");
int height = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ange bredd:");
int width = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= width; i++)
{
    Console.Write("X");
}

Console.WriteLine();

int count = 0;

while (count < height - 2)
{
    Console.Write("X");

    for (int i = 1; i <= width - 2; i++)
    {
        Console.Write(" ");
    }

    Console.WriteLine("X");
    count++;
}

for (int i = 1; i <= width; i++)
{
    Console.Write("X");
}


//Uppgift 11, Sifferpyramid


Console.WriteLine();

for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

//Uppgift 12

using System.Collections.Specialized;

Console.WriteLine();

for (int i = 1; i <= 9; i++)
{
    for (int k = 1; k <= i; k++)
    {
        for (int j = 1; j <= k; j++)
        {

            Console.Write(j);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/

//Uppgift 13 - Primtal

/*
bool isPrime = false;
int number = 1;

for (int prints = 0; prints < 20;)
{
    int testSuccessCounter = 0;
    int testCounter = 0;

    for (int i = 1; i < number; i++)
    {
        bool primeTest = number % i != 0;

        if (primeTest)
        {
            testSuccessCounter++;
        }

        testCounter++;
    }

    isPrime = testSuccessCounter == testCounter - 1;

    if (isPrime)
    {
        Console.WriteLine(number);
        prints++;
    }

    number++;
    isPrime = false;
}
*/

//Uppgift 14 - Gissa talet
/*
Random rnd = new Random();
int number = rnd.Next(1, 100); 
int guess = 0;


while (guess != number)
{
    Console.WriteLine("\nGissa det hemliga talet:");
    guess = Int32.Parse(Console.ReadLine());

    if (guess == number)
    {
        Console.WriteLine("\nGrattis! Du gissade rätt.");
    }
    else if (guess < number)
    {
        Console.WriteLine("Du gissade för lågt. Försök igen.");
    }
    else if (guess > number)
    {
        Console.WriteLine("Du gissade för högt. Försök igen.");
    }
    else
    {
        Console.WriteLine("Något gick fel. Försök igen.");
    }
}
*/

// Uppgift 15 - sten sax påse


string[] list = { "sten", "sax", "påse" };
int playerWins = 0;
int computerWins = 0;
bool keepPlaying = true;
Random rnd = new Random();

while (keepPlaying)
{
    Console.WriteLine("\nSten, sax eller påse?");
    string playerChoice = Console.ReadLine().ToLower();

    if(playerChoice != list[0] && playerChoice != list[1] && playerChoice != list[2])
    {
        keepPlaying = false;
        break;
    }

    int computerRndChoice = rnd.Next(0, list.Length);

    string computerChoice = list[computerRndChoice];
    Console.WriteLine($"Datorn väljer:\n{computerChoice}");
  
    if (playerChoice == computerChoice)
    {
        Console.WriteLine("Oavgjort");
    }  
    else if (playerChoice == "sten" && computerChoice == "sax")
    {
        Console.WriteLine("Spelaren vinner.");
        playerWins++;
    }
    else if (playerChoice == "sten" && computerChoice == "påse")
    {
        Console.WriteLine("Datorn vinner.");
        computerWins++;
    }
    else if (playerChoice == "sax" && computerChoice == "sten")
    {
        Console.WriteLine("Datorn vinner.");
        computerWins++;
    }
    else if (playerChoice == "sax" && computerChoice == "påse")
    {
        Console.WriteLine("Spelaren vinner.");
        playerWins++;
    }
    else if (playerChoice == "påse" && computerChoice == "sten")
    {
        Console.WriteLine("Spelaren vinner.");
        playerWins++;
    }
    else if (playerChoice == "påse" && computerChoice == "sax")
    {
        Console.WriteLine("Datorn vinner.");
        computerWins++;
    }
}

Console.WriteLine($"\nTack för att du spelade. Vinster: \nSpelare {playerWins} \nDator {computerWins}");