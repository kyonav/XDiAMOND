namespace XDiAMOND;

class Program
{
    static void Main(string[] args)
    {
        ApplicationStart();
    }

    public static string? userInputString;
    public static int userInputInt;

    public static void ApplicationStart()
    {
        do {
            RequestUserInput.UserInput();    
            userInputString = RequestUserInput.userInputString!; 

            if (!ValidateInput.IsInputNull())
            {
                if (ValidateInput.CanItConvertToInt())
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

            if (ValidateInput.IsUserInputOdd())
            {
                LogDiamond.PrintXDiamondTop();
                LogDiamond.PrintXDiamondBottom();
            }
            else
            {
                LogToUser.InputIsEven();

                continue;
            }
        } while (true);
    }
}
