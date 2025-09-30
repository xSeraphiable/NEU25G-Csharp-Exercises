

using System;

Console.WriteLine("=== Uppgiftsmeny ===");
Console.WriteLine("Välj uppgift (1 eller 4-12): ");

if (int.TryParse(Console.ReadLine(), out int choice))
{
    switch (choice)
    {
        case 1: Uppgift123.Run(); break;
        case 4: Uppgift4.Run(); break;
        case 5: Uppgift5.Run(); break;
        case 6: Uppgift6.Run(); break;
        case 7: Uppgift7.Run(); break;
        case 8: Uppgift8.Run(); break;
        case 9: Uppgift9.Run(); break;
        case 10: Uppgift10.Run(); break;
        // case 11: Uppgift11.Run(); break;
        // case 12: Uppgift12.Run(); break;
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
class Uppgift123
{
    public static void Run()
    {
        //UPPGIFT 1 - 3 - Person

        Person person = new Person();

        person.FirstName = "Amanda";
        Console.WriteLine(person.FirstName);

        person.LastName = "Westerlind";

        Console.WriteLine(person.FullName);
    }
    class Person
    {
        private string _firstName;

        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        public string LastName { get; set; }

        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }

        }

    }

}


class Uppgift4
{
    public static void Run()
    {
        Console.WriteLine("\nUPPGIFT 4 - Stegräknare\nSkapa en klass som kan användas som stegräknare.\nDen ska ha en property \"Steps\" som bara går att läsa;\nen metod Step() som räknar upp Steps med 1 varje gång man anropar den;\noch en metod Reset() som nollställer räknaren.\nInstantiera klassen och skriv en loop som motsvarar att man går 1000 steg.\nSkriv ut värdet på Steps.\n");


        Stegräknare mySteps = new Stegräknare();

        for (int i = 0; i < 1000; i++)
        {
            mySteps.Step();
        }

        Console.WriteLine("Du har tagit " + mySteps.Steps + " steg.");
        mySteps.Reset();
    }


    class Stegräknare
    {
        private int _steps = 0;
        public int Steps { get { return _steps; } }

        public void Step()
        {
            _steps++;
        }

        public void Reset()
        {
            Console.WriteLine("Mätaren återställs.");
            _steps = 0;
        }
    }

}

class Uppgift5
{
    public static void Run()
    {

        //UPPGIFT 5 - Bil
        //Skriv en ny klass som motsvarar en bil. Den ska ha privata fields för modell, pris och färg.
        //Skapa publika properties för att hämta eller ändra värdet på varje field.
        //Skriv en konstruktor till bilklassen som inte tar några parametrar.
        //Skriv en till konstruktor som tar en parameter för varje property som klassen har och initierar dessa.
        //Hur kan man styra vilken konstruktor som anropas när man skapar ett objekt av klassen?
        //Skriv en metod till bilklassen med namnet HalfPrice().När den anropas ska priset på bilen sänkas till hälften.


        Car newCar = new Car();
        Car newCar2 = new Car("Saab", 25000, "röd");

        newCar2.HalfPrice();

        Console.WriteLine(newCar2.Price);

    }

    class Car
    {
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Car()
        {

        }

        public Car(string model, double price, string color)
        {
            this._model = model;
            this._price = price;
            this._color = color;
        }

        public void HalfPrice()
        {
            Price = Price / 2;
        }

    }
}

class Uppgift6
{
    public static void Run()
    {

        //6.Vattenglas
        //Skriv en klass som representerar ett vattenglas. Den ska ha en metod för att fylla glaset, och en metod för att tömma glaset.
        //Dessutom ska den ha en private field som håller reda på om glaset är tomt eller fullt.
        //Beroende på tillståndet (tomt/fullt) så ska metoden som fyller glaset skriva ut antingen “Fyller glaset” eller “Glaset är redan fullt”.
        //Den andra metoden ska skriva ut “Tömmer glaset” eller “Glaset är redan tomt”.

        //Extra övning: Lägg till ytterligare en metod för att slå sönder glaset. Varje glas (instans) ska hålla reda på sitt tillstånd,
        //och skriva ut vad som händer när man kör de olika metoderna. (t.ex “Glaset går sönder, och vattnet rinner ut på golvet”, 
        // eller “Glaset kan inte fyllas, eftersom det är trasigt” osv.)


        Vattenglas newGlas = new Vattenglas();
        newGlas.FillGlass();
        newGlas.FillGlass();
        newGlas.EmptyGlass();
        newGlas.BreakGlass();

        Vattenglas newGlas2 = new Vattenglas();
        newGlas2.FillGlass();
        newGlas2.BreakGlass();


    }
    class Vattenglas
    {
        private bool _full = false;

        public bool IsFull
        {
            get { return _full; }
            set { _full = value; }
        }

        private bool _whole = true;

        public bool IsWhole
        {
            get { return _whole; }
            set { _whole = value; }
        }


        public void FillGlass()
        {
            if (IsFull && IsWhole)
            {
                Console.WriteLine("Glaset är redan fullt.");
            }
            else if (!IsFull)
            {
                Console.WriteLine("Glaset är trasigt!");
            }
            else
            {
                Console.WriteLine("Fyller glaset");
                IsFull = true;
            }

        }

        public void EmptyGlass()
        {
            if (IsFull && IsWhole)
            {
                Console.WriteLine("Glaset töms");
                IsFull = false;
            }
            else if (!IsWhole)
            {
                Console.WriteLine("Gaset är trasigt!");
            }
            else
            {
                Console.WriteLine("Glaset är redan tomt.");
            }
        }

        public void BreakGlass()
        {
            if (IsWhole && IsFull)
            {
                Console.WriteLine("Glaset gick sönder och allt vatten rinner ut!");
                IsWhole = false;
            }
            else if (IsWhole && !IsFull)
            {
                Console.WriteLine("Glaset gick sönder!");
                IsWhole = false;
            }
            else
            {
                Console.WriteLine("Glaset är redan trasigt.");
            }
        }
    }
}

class Uppgift7
{
    public static void Run()
    {
        Console.WriteLine("\nUppgift 7 - Blå & Röd\nSkapa en en klass som har en property “Red” och en property “Blue”.\n" +
            "Båda ska vara en double och kunna ha ett värde mellan 0.0 och 100.0 men de ska vara “sammankopplade”\n" +
            "på så vis att värdena tillsammans alltid är 100.0 d.v.s om man t.ex.sätter “Blue” till 8.5 och sedan läser av “Red”\n" +
            "så ska den returnera 91.5\n");


        Purple purpleOne = new Purple();
        Console.WriteLine("Ange värdet på Blue (0-100): ");

        if (double.TryParse(Console.ReadLine(), out double blueValue))
        {
            try
            {
                purpleOne.Blue = blueValue;
                Console.WriteLine("Färgen är " + purpleOne.Blue + " blå och " + purpleOne.Red + " röd.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Värdet måste vara mellan 0-100.");
            }
        }
        else
        {
            Console.WriteLine("Du angav inte ett giltigt tal");
        }

        Console.WriteLine("Ange värdet på Red (0-100): ");

        if (double.TryParse(Console.ReadLine(), out double redValue))
        {
            try
            {
                purpleOne.Red = redValue;
                Console.WriteLine("Färgen är " + purpleOne.Blue + " blå och " + purpleOne.Red + " röd.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Värdet måste vara mellan 0-100.");
            }
        }
        else
        {
            Console.WriteLine("Du angav inte ett giltigt tal");
        }
    }

    class Purple
    {
        private double _red = 50;

        public double Red
        {
            get { return this._red; }
            set
            {
                if (value >= 0 && value <= 100)
                { this._red = value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
        }

        public double Blue
        {
            get { return 100 - _red; }
            set
            {
                if (value >= 0 && value <= 100)
                { this._red = 100 - value; }
                else { throw new ArgumentOutOfRangeException(); }
            }
        }
    }
}

class Uppgift8
{
    public static void Run()
    {
        // UPPGIFT 8 - Temperatur

        Temperature t = new Temperature();

        Console.WriteLine("Ange en temperatur i Celsius: ");
        t.Celsius = Double.Parse(Console.ReadLine());

        Console.WriteLine($"Celcius:  {t.Celsius,10:f2}");
        Console.WriteLine($"Kelvin:   {t.Kelvin,10:f2}");
        Console.WriteLine($"Farenheit:{t.Farenheit,10:f2}");

    }

    class Temperature
    {
        private double _celsius;

        public double Celsius
        {
            get { return _celsius; }
            set
            {
                _celsius = value;
            }
        }


        public double Kelvin
        {
            get { return _celsius + 273.15; }
            set
            {
                _celsius = value - 273.15;
            }
        }

        public double Farenheit
        {
            get { return _celsius * (9.0 / 5.0) + 32; }
            set
            {
                _celsius = (value - 32) * (5.0 / 9.0);

            }
        }




    }

}

class Uppgift9
{
    public static void Run()
    {
        Console.WriteLine("Uppgifter är inte klar än.");
    }
}

class Uppgift10
{
    public static void Run()
    {

        // UPPGIFT 10 - BIL 2.0

        // Skriv en ny klass som representerar en bil. Varje bil ska kunna ha en färg som representeras av en ConsoleColor, samt en längd.
        // När man instansierar en bil så ska den få en random färg, och en random längd (mellan 3 och 5 meter).
        // Instansiera 1000 bilar och spara i en array. Skapa en funktion som tar en array av bilar och returnerar den sammanlagda
        // längden av alla gröna bilar.



        //Console.ForegroundColor = ConsoleColor.DarkRed;
    }

    class Car
    {

        public Car()
        {

        }
        Random rnd = new();

        string[] colors = ["red", "green", "yellow", "dark red", "dark blue", "cyan", "dark cyan"];


        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = colors[rnd.Next(0, colors.Length)]; }
        }



    }

}



