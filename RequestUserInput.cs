using System.Diagnostics.Contracts;

namespace XDiAMOND;

class RequestUserInput 
{

    public static string UserInput()
    {
        string userInput = Console.ReadLine()!;        

        return userInput;
    }

}