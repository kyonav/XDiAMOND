namespace XDiAMOND;

class ConvertInput
{
    public static int userInputInt;
    public static int ConvertToInt32()
    {
        userInputInt = Convert.ToInt32(RequestUserInput.userInputString);

        return userInputInt;
    }
}