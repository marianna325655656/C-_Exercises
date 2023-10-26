
//print planets distance by using if else, switch


//string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

//Console.Write("Enter the planet name: ");
//string input = Console.ReadLine();

//switch (input)
//{
//    case "Mercury":
//        Console.WriteLine("The distance is 57,900,000 km");
//        break;
//    case "Venus":
//        Console.WriteLine("The distance is 108,200,000 km");
//        break;
//    case "Earth":
//        Console.WriteLine("The distance is 149,600,000 km");
//        break;
//    case "Mars":
//        Console.WriteLine("The distance is 227,900,000 km");
//        break;
//    case "Jupiter":
//        Console.WriteLine("The distance is 778,600,000 km");
//        break;
//    case "Saturn":
//        Console.WriteLine("The distance is 1,433,500,000 km");
//        break;
//    case "Uranus":
//        Console.WriteLine("The distance is 2,872,500,000 km");
//        break;
//    case "Neptune":
//        Console.WriteLine("The distance is 4,495,100,000 km");
//        break;

//    default:
//        Console.WriteLine("The planet is not found");
//        break;
//}

Dictionary<string, string> planetNames = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
{
    { "Mercury", "The distance is 57,900,000 km" },
    { "Venus", "The distance is 108,200,000 km" },
    { "Earth", "The distance is 149,600,000 km" },
    { "Mars", "The distance is 227,900,000 km" },
    { "Jupiter", "The distance is 778,600,000 km" },
    { "Saturn", "The distance is 1,433,500,000 km" },
    { "Uranus", "The distance is 2,872,500,000 km" },
    { "Neptune", "The distance is 4,495,100,000 km" }
};

Console.Write("Enter the planet name: ");
string input1 = Console.ReadLine()?.Trim();

if (!string.IsNullOrEmpty(input1))
{
    if (planetNames.TryGetValue(input1, out string planetDistance))
    {
        Console.WriteLine(planetDistance);
    }
    else
    {
        Console.WriteLine("The planet name is not found.");
    }
}
else
{
    Console.WriteLine("Invalid input");
}