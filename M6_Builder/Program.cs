namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        // Creates a wood house builder
        WoodHouseBuilder builder = new WoodHouseBuilder();
         // Initializes a civil engineer with the wood house builder
        CivilEngineer civilEngineer = new CivilEngineer(builder);

        // Engineer constructs the house
        civilEngineer.ConstructHouse();

        // Gets the constructed house
        House house = civilEngineer.GetHouse();
        // Displays the house details
        Console.WriteLine(house);
        // Waits for a key press to close the console window
        Console.ReadKey();
    }
}

//Hous-HousBuilder->wood->stone->Engineer