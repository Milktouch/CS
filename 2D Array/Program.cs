using System;

namespace _2d_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int alive = 5, tries = 0;
            
            Random rnd = new Random();
            int x, y;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(" square " + j + "," + i + " | ");
                }
                Console.WriteLine();
            }

            
            bool[,] answerarr = new bool[10,10];
            for (int i = 0; i < alive; i++)
            {

                Console.WriteLine("Enter the x value of the square  you want to put  ship " + (i + 1) + " in");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the y value of the square  you want to put  ship " + (i + 1) + " in");
                y = int.Parse(Console.ReadLine());





                if (answerarr[y,x] == true)
                {
                    while (answerarr[y,x] == true)
                    {
                        Console.WriteLine("this square already has a ship in it choose another square");
                        Console.WriteLine("Enter the x value of the square  you want to put a ship in");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the y value of the square  you want to put a ship in");
                        y = int.Parse(Console.ReadLine());

                    }
                }
                else
                    answerarr[y,x] = true;






            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (answerarr[i,j] == false)
                    {
                        Console.Write(answerarr[i,j] + " | ");

                    }
                    else
                    {

                        Console.Write(answerarr[i,j] + "  | ");
                    }
                }
                Console.WriteLine();
            }
            bool[,] pcplayer = new bool[10, 10];
            int xpc = 0, ypc = 0;
            for (int i = 0; i < xpc; i++)
            {
                for (int j = 0; j < ypc; j++)
                {
                    pcplayer[j, i] = false;
                }
                
            }
            while (alive > 0)
            {
                Console.WriteLine("The enemy has shot a bomb");
                x = rnd.Next(10);
                y = rnd.Next(10);
                //while (pcplayer[y,x]==true)
                //{
                //    x = rnd.Next(10);
                //    y = rnd.Next(10);
                //}
                //pcplayer[y, x] = true;
                Console.WriteLine("it landed in square " + x + "," + y);
                if (answerarr[y,x] == true)
                {
                    answerarr[y,x] = false;
                    Console.WriteLine("IT HIT! The ship has sank down");
                    alive--;

                }
                else
                {
                    Console.WriteLine("it missed");
                }
                tries++;
            }
            Console.WriteLine("game over! Then enemy wasted " + tries + " bombs");
        }
    }
}
