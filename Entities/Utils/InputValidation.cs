namespace XDiAMOND;

class InputException
{
    public static bool IsInputNull()
    {
        return RequestUserInput.userInputString is null;
    }

    public static bool CanItConvertToInt()
    {
        if (Int32.TryParse(RequestUserInput.userInputString, out _)){
            return true;
        } else {
            return false;
        }
    }
}
class ConditionalInput()
{
    public static bool IsUserInputOdd()
    {
        if (ConvertInput.userInputInt % 2 != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool DidUserContinue()
    {
        if (RequestUserInput.userInputString == "Y" ||
            RequestUserInput.userInputString == "y")
        {
            return true;
        } 
        else
        {
            return false;
        }
    }
}