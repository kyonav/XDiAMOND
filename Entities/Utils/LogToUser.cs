namespace XDiAMOND;

class LogToUser
{

    public static void TypeANumber()
    {
        Console.WriteLine("________________________________");
        Console.WriteLine();
        Console.WriteLine("Type an odd integer number!");
        Console.Write("> ");
    }

    public static void InvalidInputDetected()
    {
        Console.Clear();

        Console.WriteLine("_____________________________________________");
        Console.WriteLine();
        Console.WriteLine("Invalid input. Only numbers are allowed.");
        Console.WriteLine("_____________________________________________");
    }

    public static void NullInputDetected()
    {
        Console.Clear();

        Console.WriteLine("_______________________________________________");
        Console.WriteLine();
        Console.WriteLine("Null input detected. Only numbers allowed.");
        Console.WriteLine("_______________________________________________");
    }
    
    public static void InputIsEven()
    {
        Console.Clear();

        Console.WriteLine("__________________________________________________________________________________");
        Console.WriteLine();
        Console.WriteLine($"The number {ConvertInput.userInputInt} is even. Try again with a odd number.");
        Console.WriteLine("__________________________________________________________________________________");
    }

    public static void ContinueOrNot()
    {
        Console.WriteLine("____________________________________________");
        Console.WriteLine();
        Console.WriteLine("Do you wanna redraw the triangle? (y/*)");
        Console.Write("> ");

    }

    public static void QuittingProgram()
    {
        Console.Clear();

        Console.WriteLine("____________________________________________________");
        Console.WriteLine();
        Console.WriteLine("User chose not to continue. Quitting program...");
        Console.WriteLine("____________________________________________________");
    }
}