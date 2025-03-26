namespace XDiAMOND;

class IsOddOrEven
{
    public static bool CheckIfOdd(int userInputInt)
    {
        if (userInputInt % 2 != 0)
        {
            return true;
        } else {
            return false;
        }
    }
}