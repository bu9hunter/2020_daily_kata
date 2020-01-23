using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Kata
{
    public class DianmondFactory
    {
        public char[][] print(char letter)
        {
            if (Char.IsNumber(letter))
                return null;

            int arraySize = ((int)letter - 'A') * 2 + 1;

            if (arraySize == 1)
            {
                char[][] diamond_one_char =
                {
                    new char [] { 'A' }
                };

                return diamond_one_char;
            }

            char[][] diamond = new char[arraySize][];

            for (int i = 0; i < arraySize; i++)
            {
                diamond[i] = new char[arraySize];
                for (int j = 0; j < arraySize; j++)
                {
                    if (j == (arraySize / 2 - i))
                    {
                        diamond[i][j] = (char)('A' + i);
                        Console.Write(diamond[i][j]);
                    }
                    else if (j == (arraySize / 2 + i))
                    {
                        diamond[i][j] = (char)('A' + i);
                        Console.Write(diamond[i][j]);
                    }
                    else
                    {
                        diamond[i][j] = '.';
                        Console.Write(diamond[i][j]);
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            return diamond;
        }
    }
}
