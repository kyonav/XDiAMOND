using System.Diagnostics.Contracts;

namespace XDiAMOND;

class RequestUserInput 
{
    public static string? userInputString;

    public static void UserInput()
    {
        userInputString = Console.ReadLine()!;        
    }
}