namespace XDiAMOND;

class ConvertInput
{
    public static int userInputInt;
    public static int ConvertToInt32(string userInputString)
    {
        userInputInt = Convert.ToInt32(userInputString);

        return userInputInt;
    }
}