using System.Diagnostics.Contracts;

namespace XDiAMOND;

class ValidateInput
{
    public static bool IsInputNull(string userInputString)
    {
        return userInputString is null ? true : false;
    }

    public static bool CanItConvertToInt(string userInputString)
    {
        if (Int32.TryParse(userInputString, out _)){
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