
using FactorizerNet;

int number = GetNumberFromUser();

Calculator.PrintFactors(number);
Calculator.IsPerfectNumber(number);
Calculator.IsPrimeNumber(number);

Console.WriteLine("Press any key to quit...");
Console.ReadKey();

/// <summary>
/// Prompt the user for an integer.  Make sure they enter a valid integer!
/// 
/// See the String Input lesson for TryParse() examples
/// </summary>
/// <returns>the user input as an integer</returns>
static int GetNumberFromUser()
{
    throw new NotImplementedException();
}