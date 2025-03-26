namespace XDiAMOND;

class LogToUser
{
    public static void StringInputDetected()
    {
        Console.Clear();

        Console.WriteLine("Invalid input. Only numbers are allowed.");
    }

    public static void NullInputDetected()
    {
        Console.Clear();

        Console.WriteLine("Null input detected. Only numbers allowed.");
    }
}