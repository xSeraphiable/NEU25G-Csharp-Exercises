Console.WriteLine("=== Uppgiftsmeny FUNKTIONER ===");
Console.WriteLine("Välj uppgift (1-13): ");

if (int.TryParse(Console.ReadLine(), out int choice))
{
    switch (choice)
    {
        case 1: Uppgift1.Run(); break;
        //case 2: Uppgift2.Run(); break;
        //case 3: Uppgift3.Run(); break;
        //case 4: Uppgift4.Run(); break;
        //case 5: Uppgift5.Run(); break;
        //case 6: Uppgift6.Run(); break;
        //case 7: Uppgift7.Run(); break;
        //case 8: Uppgift8.Run(); break;
        //case 9: Uppgift9.Run(); break;
        //case 10: Uppgift10.Run(); break;
        //case 11: Uppgift11.Run(); break;
        //case 12: Uppgift12.Run(); break;
        //case 13: Uppgift13.Run(); break;
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
        Console.WriteLine("Uppgift 1 - Skapa en klass för fordon\nSkapa en enum Brand med 5 bilmärken, och en enum color med 5 färger.\n" +
            "Klassen ska ha en konstruktor som man kan använda för att sätta Brand och Color,\n" +
            "och en konstruktor som endast tar brand och sätter en default färg.\n");

        var myVehicle = new Vehicle(Brand.saab, Color.magenta);
        var mySecondVecicle = new Vehicle(Brand.volvo);

        Console.WriteLine(new Vehicle(Brand.audi, Color.blue));
    }

    class Vehicle
    {
        public Brand _brand { get; set; }
        public Color _color { get; set; }



        public Vehicle(Brand brand)
        {
            _brand = brand;

        }
        //public Vehicle(Brand brand)
        //{
        //    _color = Color.cyan;
        //    _brand = brand;
        //}

        public Vehicle(Brand brand, Color color) : this(brand)
        {
            _color = color;
            ToString();
        }

        public override string ToString()
        {
            return "A " + _color + " " + _brand + ".";
        }


    }
    enum Brand { saab, audi, volvo, toyota, volkswagen }

    enum Color { red, green, blue, cyan, magenta }

}
