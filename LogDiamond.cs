using System.Security.Cryptography.X509Certificates;

namespace XDiAMOND;

class LogDiamond
{
    public static void PrintXDiamondTop()
    {
        int spaces = (ConvertInput.userInputInt / 2);

        for (int lineOfDiamond = 1; lineOfDiamond <= ConvertInput.userInputInt; lineOfDiamond += 2)
        {
            for (int spacesBeforeX = 0; spacesBeforeX < spaces ; spacesBeforeX++)
            {
                Console.Write(" ");
            }

            for (int xOnLine = 0; xOnLine < lineOfDiamond; xOnLine++)
            {
                Console.Write('x');
            }

            Console.WriteLine();

            spaces--;
        } 
    }

    public static void PrintXDiamondBottom (){
        
        int spacesQtt = (ConvertInput.userInputInt / 2);
        int oldSpacesQtt = spacesQtt;

        for (int lineOfDiamond = (ConvertInput.userInputInt - 2); lineOfDiamond >= 1; lineOfDiamond -= 2)
        {
            for (int spacesBeforeX = spacesQtt; spacesBeforeX >= oldSpacesQtt; spacesBeforeX--)
            {
                Console.Write(" ");
            }

            for (int xOnLine = lineOfDiamond; xOnLine > 0; xOnLine--)
            {
                Console.Write('x');
            }

            Console.WriteLine();

            spacesQtt++;
        }
    }
}