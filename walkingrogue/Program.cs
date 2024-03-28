using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walkingrogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            char[,] map =
            {
              { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
              { '#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
              { '#',' ','#',' ',' ',' ','O',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
              { '#',' ','#',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ',' ','#'},
              { '#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#'},
              { '#',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#'},
              { '#',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ','#'},
              { '#',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ','O',' ','#'},
              { '#',' ','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
              { '#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
              { '#','O',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
              { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}

            };
            int userX = 6, userY = 6;
            char[] bag = new char[1];

            while (true)
            {

                Console.SetCursorPosition(0, 20);
                Console.Write("Bag: ");
                for(int i= 0; i< bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }


                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
                
                Console.SetCursorPosition(userY, userX);
                Console.Write('@');

                ConsoleKeyInfo charKey = Console.ReadKey();
                switch(charKey.Key)
                {
                    case ConsoleKey.W:
                        if (map[userX - 1, userY] != '#')
                        userX--;
                        break;
                    case ConsoleKey.S:
                        if (map[userX + 1, userY] != '#')
                        userX++;
                        break;
                    case ConsoleKey.D:
                        if (map[userX, userY + 1] != '#')
                        userY++;
                        break;
                    case ConsoleKey.A:
                        if (map[userX, userY - 1] != '#')
                            userY--;
                        break;

                }
                if (map[userX, userY] == 'O' )
                {
                    map[userX, userY] = 'o';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = 'O';
                    bag = tempBag;


                }
                Console.Clear();
            }
        }
    }
}
