//Uppgift 1 - En bokstav på varje rad
/*
Console.Write("Skriv en textrad:");
string text = Console.ReadLine();
var lista = text.ToCharArray();

for (int i = 0; i < lista.Length; i++)
{
    Console.WriteLine(lista[i]);
}*/

//Uppgift 2 - Siffror till text *Extra utmaning: Användaren kan mata in en sträng med fritt antal siffror, om man skriver in t.ex 432 så svarar programmet: “fyra-tre-två”.*

string[] siffror =  {"noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"};

Console.WriteLine("Skriv en siffra:");
string sifferinmatning = Console.ReadLine();

int[] input = new int[sifferinmatning.Length];

for (int i = 0; i < input.Length; i++)
{
    input[i] = sifferinmatning[i] - '0';
}

for (int i = 0; i < input.Length; i++)
{
    Console.Write(siffror[input[i]]+ ", "); 
}

//int input = Int32.Parse(Console.ReadLine());
//Console.WriteLine(siffror[input]);