using System.Security.Principal;

namespace XDiAMOND;

class ConvertNumber 
{
    public static int ConvertToInt(string userInput)
    {
        int n = Convert.ToInt32(userInput);
        return n;
    }
}