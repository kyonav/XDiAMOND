namespace XDiAMOND;

class Program
{
    static void Main(string[] args)
    {
        ApplicationStart();
    }

    public static void ApplicationStart()
    {
        string userInput = AskForUserInput.UserInput();

        int userInputInt = ConvertNumber.ConvertToInt(userInput);

        bool IsUserInputIntOdd = IsOddOrEven.CheckIfOdd(userInputInt);

        if (IsUserInputIntOdd){
            DiamondLog.PrintXDiamond(userInputInt);
        }
    }
}
