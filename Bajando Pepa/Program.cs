using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bajando_Pepa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.ReadLine();
            for (int i = 0; i <= 8; i++)
            {
                m = 5;
                m = m * i;
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n");
                Console.Write("\t\t\t\t\t\t\t ___ ");
                for (int k = 0; k <= 80-m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write(" ___ \n");
                Console.Write("\t\t\t\t\t\t\t/  .\\");
                for (int k = 0; k <= 80-m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("/  .\\\n");
                Console.Write("\t\t\t\t\t\t\t\\  ;|");
                for (int k = 0; k <= 80 - m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\  ;|\n");
                Console.Write("\t\t\t\t\t\t\t `--\"");
                for (int k = 0; k <= 80-m; k++)
                {

                    Console.Write(" ");
                }
                Console.Write(" `--\" ");
                Thread.Sleep(100);
              
            }



            for(int i = 0; i <= 8; i++)
            {
                Console.Clear();
                m = 5;
                m = m * i;
                Console.WriteLine("\n\n\n\n\n\n\n\n");
                //1
                Console.Write("\t\t\t\t\t\t\t   ,---.  ");
                for (int k = 0; k <= 40 - m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("   ,---.   \n");

                //2
                Console.Write("\t\t\t\t\t\t\t  '   ,'\\ ");
                for (int k = 0; k <= 40 - m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("  '   ,'\\   \n");

                //3
                Console.Write("\t\t\t\t\t\t\t /       |");
                for (int k = 0; k <= 40 - m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write(" /       |    \n");

                //4
                Console.Write("\t\t\t\t\t\t\t.     ,. :");
                for (int k = 0; k <= 40 - m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write(".     ,. : \n");

                //5
                Console.Write("\t\t\t\t\t\t\t'   | |: :");
                for (int k = 0; k <= 40 - m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("'   | |: :\n");


                //6
                Console.Write("\t\t\t\t\t\t\t'     .; :");
                for (int k = 0; k <= 40 - m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("'     .; :\n");


                //7

                Console.Write("\t\t\t\t\t\t\t|   :    |");
                for (int k = 0; k <= 40 - m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("|   :    |\n");


                //8
                Console.Write("\t\t\t\t\t\t\t \\      / ");
                for (int k = 0; k <= 40 - m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write(" \\      / \n");


                //9

                Console.Write("\t\t\t\t\t\t\t  `----'  ");
                for (int k = 0; k <= 40 - m; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("  `----' \n");
               
                if (i == 8) break;
                Thread.Sleep(100);
            }
            for(int i = 0; i <5; i ++)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n");
                
                Console.WriteLine("                                                                  /||   |||  |  || |  |  || |  ||     |||  | | |  | \\                         ");
                Console.WriteLine("                                                       ,-            /                                         |       |      /  ./   / ");
                Console.WriteLine("                                                     \\ ' \\  \\  \\                     /            |       /      /   /        ,,   /   /");
                Console.WriteLine("                                                   \\\\\\  |.\\ \\ \\     \\   '     |          |            |          / .      |             /");
                Console.WriteLine("                                                    ' \\¡        \\   \\    \\       |   ,                 /    /    /   , ,      /   /  /  /");
                Console.WriteLine("                                                   >   \\  \\ \\ \\   \\ \\  >'                         ,    |      ,   |         /       /|");
                Console.WriteLine("                                                  >>>             \\>             ,    |        |        ,   |    .       /      //    |  /");
                Console.WriteLine("                                               ,     ,., .  \\   >\\        ,.,   ,      ,       |    ,       |  ,    ,   ,   /      /  <");
                Console.WriteLine("                                            \\   > \\             >  > |   ,.        .,    , ,       , .    |   .,      /   |    /   |   /");
                Console.WriteLine("                                                     \\ >   \\  >         .    .             .   . ,      ,   |      /  / ,    /   ");
                Console.WriteLine("                                                >     >                      ,      , .  , .   ,.    .  .       ,       < / <    /");
                Console.WriteLine("                                                 -,.,    >      ° \"  \"|   .            .  ,.      .,    .    /   , , ,    <             >   ");
                Console.WriteLine("                                      -            -      >           .  ,     ,.   ,  ,   .         .  \\       \\  ,    ,     <\\     ,.");
                Console.WriteLine("                                                   -  /                     .          ,.          ,      ,      \\    ,          -.\\");
                Console.WriteLine("                                                   /    - /    /    /      |       |    |       \\          ,,      \\,    ,   .  \\      \\");
                Console.WriteLine("                                         ,     .,                                         \\   \\       \\   .-    \\    \\          \\");
                Console.WriteLine("                                                .,      --/   /   /   |      |   |               \\            \\   .-        \\     ,");
                Console.WriteLine("                                         .                              |    |        |            \\     \\  ,,   \\         \\    \\ ");
                Console.WriteLine("                                               . -   /   /     /                   \\        \\         \\      ,    \\      \\    \\ \\ ");
                Console.WriteLine("                                                    /   /          |                             \\     \\        ,       \\    \\  \\ ");
                Console.WriteLine("                                          .          |  / /   |         | _-   !\"     |||     |             \\  \\         \\     \\  \\ ");
                Console.WriteLine("                                                       |       |                 \"               |                                     ");
                Console.WriteLine("                                                                 \\||   |||  |  || |  |  || |  ||     |||  | | |  | /    ");
                Thread.Sleep(50);

            }
            

            for (int i = 0; i <= 4; i++)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("\t\t\t\t_____/\\\\\\\\\\\\\\\\\\\\\\\\______________________________________________________________________________/\\\\\\\\\\_     ");
                Console.WriteLine("\t\t\t\t ___/\\\\\\//////////___________________________________________________________________________/\\\\\\\\////__    ");
                Console.WriteLine("\t\t\t\t  __/\\\\\\___________________________________________/\\\\\\\\\\\\\\\\\\______________________________/\\\\\\///_______      ");
                Console.WriteLine("\t\t\t\t   _\\/\\\\\\____/\\\\\\\\\\\\\\__/\\\\/\\\\\\\\\\\\\\___/\\\\\\____/\\\\\\__/\\\\\\/////\\\\\\_____/\\\\\\\\\\________________/\\\\\\\\\\\\\\\\\\\\\\____    ");
                Console.WriteLine("\t\t\t\t    _\\/\\\\\\___\\/////\\\\\\_\\/\\\\\\/////\\\\\\_\\/\\\\\\___\\/\\\\\\_\\/\\\\\\\\\\\\\\\\\\\\____/\\\\\\///\\\\\\_____________/\\\\\\\\///////\\\\\\__   ");
                Console.WriteLine("\t\t\t\t     _\\/\\\\\\_______\\/\\\\\\_\\/\\\\\\___\\///__\\/\\\\\\___\\/\\\\\\_\\/\\\\\\//////____/\\\\\\__\\//\\\\\\___________\\/\\\\\\______\\//\\\\\\_   ");
                Console.WriteLine("\t\t\t\t      _\\/\\\\\\_______\\/\\\\\\_\\/\\\\\\_________\\/\\\\\\___\\/\\\\\\_\\/\\\\\\_________\\//\\\\\\__/\\\\\\____________\\//\\\\\\______/\\\\\\__ ");
                Console.WriteLine("\t\t\t\t       _\\//\\\\\\\\\\\\\\\\\\\\\\\\/__\\/\\\\\\_________\\//\\\\\\\\\\\\\\\\\\__\\/\\\\\\__________\\///\\\\\\\\\\/______________\\///\\\\\\\\\\\\\\\\\\/___ ");
                Console.WriteLine("\t\t\t\t        __\\////////////____\\///___________\\/////////___\\///_____________\\/////__________________\\/////////_____");
                Thread.Sleep(10);
            }

            for (int o = 0; o <= 1; o++)
            {
                Console.Clear();
              
                for (int i = 0; i <= 6; i++)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t                                                                   Cargando...\n");
                    Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t                                                                   ");
                    for (int j = 0; j <= i + 1; j++)
                    {
                        Console.Write("|");
                    }
                    for (int k = 0; k <= 6 - i - 1; k++)
                    {
                        Console.Write("-");
                    }
                    Thread.Sleep(10);
                }
                for (int i = 0; i <= 6; i++)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t                                                                   Cargando...\n");
                    Console.Write("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t                                                                   ");
                    for (int j = 0; j <= 6 - i; j++)
                    {
                        Console.Write("|");
                    }
                    for (int k = 0; k <= i; k++)
                    {
                        Console.Write("-");
                    }
                    Thread.Sleep(10);
                }
            }
            Console.Clear();
            Console.WriteLine("       Menú");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" 1. Gei el que lo lee");
            Console.WriteLine(" 2. Puro kchudo");
            Console.WriteLine(" 3. Salir");
            Console.ReadLine();
        }
    }
}
