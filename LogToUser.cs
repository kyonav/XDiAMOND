namespace XDiAMOND;

class LogToUser
{
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

    public static void DoYouWannaContinue()
    {
        Console.WriteLine();
        Console.WriteLine("Do you wish to redraw the triangle? Y/N");

    }
}