using System.Diagnostics.Contracts;

namespace XDiAMOND;

class ValidateInput
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
}