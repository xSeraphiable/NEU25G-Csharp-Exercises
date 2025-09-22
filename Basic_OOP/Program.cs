// Uppgift 1 - Skriva ut namn på personer
//
//Skriv en klass som representerar en person. Klassen ska ha två publika fält (fields): firstName, lastName.
//Skapa två instanser av personer med olika för och efternamn, och använd sedan dessa för att printa ut (hela) namnen på de olika personerna.


Person person1 = new Person() { firstName = "Ellie", lastName = "Tonydotter"};
Person person2 = new Person() { firstName = "Kira", lastName = "Fransdotter" };

Console.WriteLine(person1.GetFullName());
Console.WriteLine(person2.GetFullName());

Console.WriteLine(person1.GetFullNameReversed());
Console.WriteLine(person2.GetFullName("Miss"));


class Person()
{
    public string firstName;    
    public string lastName;
    public string mamma;
    public string pappa;

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public string GetFullName(string title)
    {
        return title + " " + firstName + " " + lastName;
    }

    public string GetFullNameReversed()
    {
        string fullName = GetFullName();
        string reversed = "";
        for (int i = fullName.Length-1; i >= 0; i--)
        {
            reversed += fullName[i];
        }
       return reversed;
    }
}
