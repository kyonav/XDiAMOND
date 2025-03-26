namespace XDiAMOND;

class Program
{
    static void Main(string[] args)
    {
        ApplicationStart();
    }

    public static int userInputInt;

    public static void ApplicationStart()
    {
        do {
        RequestUserInput.UserInput();    
        string userInputString = RequestUserInput.userInputString!;

            if (!ValidateInput.IsInputNull(userInputString))
            {
                if (ValidateInput.CanItConvertToInt(userInputString))
                {
                    userInputInt = ConvertInput.ConvertToInt32(userInputString);
                }
                else
                {
                    LogToUser.StringInputDetected();
                    
                    continue;
                }
            } else {
               LogToUser.NullInputDetected();

               continue; 
            }

            

        } while (true);
    }
}
