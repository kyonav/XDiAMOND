using System.Diagnostics.Contracts;

namespace XDiAMOND;

class AskForUserInput 
{

    public static string UserInput()
    {
        string userInput = Console.ReadLine()!;        

        return userInput;
    }

}