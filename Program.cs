namespace XDiAMOND;

class Program
{
    static void Main()
    {   
        Console.Clear();
        ApplicationStart();
    }

    public static string? userInputString;
    public static int userInputInt;

    public static void ApplicationStart()
    {
        do {
            LogToUser.TypeANumber();

            RequestUserInput.UserInput();
            Console.Clear(); 
            //userInputString = RequestUserInput.userInputString!; 

            if (!InputException.IsInputNull())
            {
                if (InputException.CanItConvertToInt())
                {
                    userInputInt = ConvertInput.ConvertToInt32();
                }
                else
                {
                    LogToUser.InvalidInputDetected();
                    
                    continue;
                }
            } else {
               LogToUser.NullInputDetected();

               continue; 
            }

            if (ConditionalInput.IsUserInputOdd())
            {
                LogDiamond.PrintXDiamondTop();
                LogDiamond.PrintXDiamondBottom();
            }
            else
            {
                LogToUser.InputIsEven();

                continue;
            }

            do {
                LogToUser.ContinueOrNot();
                RequestUserInput.UserInput();

                if (ConditionalInput.DidUserContinue())
                {
                    Main();
                }
                else
                {
                    LogToUser.QuittingProgram();
                    Environment.Exit(0);
                }
            } while (true);
        } while (true);
    }
}
