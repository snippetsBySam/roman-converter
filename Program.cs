// See https://aka.ms/new-console-template for more information


//RomanNumerals testRom = new RomanNumerals();
using RomanConverter;

//string romanChar = "XcV";
Console.WriteLine("Please enter a Roman Numeral:");
string? romanChar = Console.ReadLine();
//Console.WriteLine($"{romanChar} converts to: {RomanNumerals.Convert(romanChar)}");
Console.WriteLine($"{RomanNumerals.Convert(romanChar)}");
