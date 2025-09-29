// BASIC OOP - Uppgift 1-9
//
//Skriv en klass som representerar en person. Klassen ska ha två publika fält (fields): firstName, lastName.
//Skapa två instanser av personer med olika för och efternamn, och använd sedan dessa för att printa ut (hela) namnen på de olika personerna.


Person person2 = new Person { firstName = "Kira", lastName = "Fransdotter" };
Person person3 = new Person { firstName = "Tony", lastName = "Matyshson" };
Person person1 = new Person { firstName = "Ellie", lastName = "Tonydotter", pappa = person3 };

Console.WriteLine(person1.GetFullName());
Console.WriteLine(person2.GetFullName());

Console.WriteLine(person1.GetFullNameReversed());
Console.WriteLine(person2.GetFullName("Miss"));

Console.WriteLine(person1.pappa.GetFullName());

Console.WriteLine(person1.GetSelfAndParents());

person1.SetLength(172);
Console.WriteLine(person1.firstName + " är " + person1.GetLength() + " cm lång.");
person1.SetWeight(66);
Console.WriteLine(person1.GetBMI());


class Person()
{
    public string firstName;
    public string lastName;

    private double _length;
    private double _weight;

    public Person mamma;
    public Person pappa;

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
        for (int i = fullName.Length - 1; i >= 0; i--)
        {
            reversed += fullName[i];
        }
        return reversed;
    }

    public string GetSelfAndParents()
    {
        string fullName = GetFullName();
        if (this.pappa == null && this.mamma == null)
        {
            return fullName + " Mamma: Okänd" + " Pappa: Okänd";
        }
        else if (this.pappa == null)
        {
            return fullName + " Mamma: " + this.mamma.GetFullName() + " Pappa: Okänd";
        }
        else if (this.mamma == null)
        {
            return fullName + " Mamma: Okänd " + " Pappa: " + this.pappa.GetFullName();
        }
        else
        {
            return fullName + ", Mamma: " + this.mamma.GetFullName() + ", Pappa: " + this.pappa.GetFullName();
        }
    }

    public void SetLength(double length)
    {
        this._length = length;
    }

    public double GetLength()
    {
        return this._length;
    }

    public void SetWeight(double weight)
    {
        this._weight = weight;
    }

    public double GetWeight()
    {
        return this._weight;
    }

    public double GetBMI()
    {
        double bmi = _weight / ((_length/100) * (_length/100));
        return Math.Round(bmi, 1);
    }
}
