using System.Diagnostics.Contracts;

namespace XDiAMOND;

class ValidateInput
{
    public static bool IsInputNull(string userInputString)
    {
        return userInputString is null ? true : false;
    }
}