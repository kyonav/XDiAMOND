using System.Security.Cryptography.X509Certificates;

namespace XDiAMOND;

class DiamondLog
{
    public static void PrintXDiamond(int userInputIntOdd)
    {
        int spaces = (userInputIntOdd / 2);

        for (int lineOfDiamond = 1; lineOfDiamond <= userInputIntOdd; lineOfDiamond += 2)
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
}