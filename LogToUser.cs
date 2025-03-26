namespace XDiAMOND;

class LogToUser
{

    public static void TypeANumber()
    {
        Console.WriteLine("Type an odd integer number!");
        Console.Write("> ");
    }

    public static void InvalidInputDetected()
    {
        Console.Clear();

        Console.WriteLine("Invalid input. Only numbers are allowed.");
    }

    public static void NullInputDetected()
    {
        Console.Clear();

        Console.WriteLine("Null input detected. Only numbers allowed.");
    }
    
    public static void InputIsEven()
    {
        Console.Clear();

        Console.WriteLine($"The number {ConvertInput.userInputInt} is even. Try again with a odd number.");
    }

    public static void ContinueOrNot()
    {
        Console.WriteLine();
        Console.WriteLine("Do you wanna redraw the triangle? (y/*)");
        Console.Write("> ");

    }

    public static void QuittingProgram()
    {
        Console.Clear();

        Console.WriteLine("User chose not to continue. Quitting program...");
    }
}