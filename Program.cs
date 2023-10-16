using System;
using System.Collections.Generic;


namespace Tic_Tac
{
    class Program
    {

        static char switchuser(char user)
        {          
            if (user == 'x')
            {
                user = 'o';
                return user;
            }

            else
            {
                user = 'x';
                return user;
            }
        }

        static void RefDisplay()
        {
            int[] indecat = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int w = 0; w < 3; w++)
            {
                Console.Write(indecat[w] + " ");
            }
            Console.WriteLine("");
            for (int w = 3; w < 6; w++)
            {
                Console.Write(indecat[w] + " ");
            }
            Console.WriteLine("");
            for (int w = 6; w < 9; w++)
            {
                Console.Write(indecat[w] + " ");
            }
            Console.WriteLine("");
        }

        static void UpdateDisplay(char[] values)
        {
            for (int w = 0; w < 3; w++)
            {
                Console.Write(values[w] + " ");
            }
            Console.WriteLine("");
            for (int w = 3; w < 6; w++)
            {
                Console.Write(values[w] + " ");
            }
            Console.WriteLine("");
            for (int w = 6; w < 9; w++)
            {
                Console.Write(values[w] + " ");
            }
            Console.WriteLine("");
        }

        static bool winner(char[] values)
        {
            if (values[0] == values[1] && values[0] == values[2] && values[0] != '-' ||
                    values[0] == values[3] && values[0] == values[6] && values[0] != '-' ||
                    values[0] == values[4] && values[0] == values[8] && values[0] != '-')
            {
                if (values[0] == 'x')
                {
                    Console.WriteLine("Player (x) won");
                    return true;
                }                  
               
                else
                {
                    Console.WriteLine("Player (o) won");
                }
                return true;
            }
            if (values[3] == values[4] && values[3] == values[5] && values[3] != '-')
            {
                if (values[3] == 'x')
                {
                    Console.WriteLine("Player (x) won");
                    return true;

                }
                    
                else
                {
                    Console.WriteLine("Player (o) won");
                }
                return true;
            }
            if (values[6] == values[7] && values[06] == values[8] && values[6] != '-')
            {
                if (values[6] == 'x')
                {
                    Console.WriteLine("Player (x) won");
                    return true;
                }
                    
                else
                {
                    Console.WriteLine("Player (o) won");
                }
                return true;
            }
            if (values[1] == values[4] && values[1] == values[7] && values[1] != '-')
            {
                if (values[1] == 'x')
                {
                    Console.WriteLine("Player (x) won");
                    return true;
                }
                    
                else
                {
                    Console.WriteLine("Player (o) won");
                }
                return true;
            }
            if (values[2] == values[5] && values[2] == values[8] && values[2] != '-' ||
                values[2] == values[4] && values[2] == values[6] && values[2] != '-')
            {
                if (values[2] == 'x')
                {
                    Console.WriteLine("Player (x) won");
                    return true;
                }
                    
                else
                {
                    Console.WriteLine("Player (o) won");
                }
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {

            char[] values = { '-', '-', '-', '-', '-', '-', '-', '-', '-' };
            int u = 0;
            string input;
            char player = 'o';
            
            
            RefDisplay();            

            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Please select the place(from 1 to 9) you want to tic");

                    input = Console.ReadLine();

                    if (Convert.ToInt32(input) > 9)
                    {
                        continue;
                    }

                    player = switchuser(player);

                    foreach (var i in values)
                    {

                        if (i != '-')
                        {
                            u++;
                        }
                    }
                    if (u == 9)
                    {
                        Console.WriteLine("Tie");
                        break;
                    }

                    if (values[Convert.ToInt32(input) - 1] != '-')
                    {
                        Console.WriteLine("it's already ticked please choose another one");
                        continue;

                    }

                    values[Convert.ToInt32(input) - 1] = player;

                    UpdateDisplay(values);

                    if (winner(values) == true)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine("To restart Press 'Space'");
                Console.WriteLine("To end Prss 'Enter'");
                var end = Console.ReadLine();
                if (end == " ")
                {
                    for (int i = 0; i<9; i++)
                    {
                        values[i] = '-';
                    }
                    continue;
                }
                else
                {
                    break;
                }
                
            }            
        }       

    }
}
