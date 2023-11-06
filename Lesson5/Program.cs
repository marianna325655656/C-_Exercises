using System;
using System.Collections.Generic;

List<int> oddNumbers = new List<int>();
List<int> evenNumbers = new List<int>();

Console.WriteLine("Enter numbers (separated by spaces):");
string input = Console.ReadLine();

string[] numberStrings = input.Split(' ');

foreach (string numberString in numberStrings)
{
    if (int.TryParse(numberString, out int number))
    {
        if (number % 2 == 0)
        {
            evenNumbers.Add(number);
        }
        else
        {
            oddNumbers.Add(number);
        }
    }
    else
    {
        Console.WriteLine($"Invalid number: {numberString}");
    }
}

Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));