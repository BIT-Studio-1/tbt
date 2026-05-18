using System;
using System.Threading;

namespace PB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro();
        }

        static void Intro()
        {
            Console.WriteLine("You haver been convicted of watching anime on an illegal website.");
                Thread.Sleep(1000);
            Console.WriteLine("The Judge has commited you 25 life sentences due to your severe crime");
            Console.WriteLine("");
            Console.WriteLine("      -------------Outcast Juvenile Holding Center-------------");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Cell();
        }

        public static void Cell()
        {
            string celltemp;
            
            int celldec;
            Console.WriteLine("You arrive in your cell, a cramped cold and dirty cell");
                celldec = 0;
            if (celldec == 0) {
                Console.WriteLine("What would you like to do");
                Console.WriteLine("1. Check cell");
                Console.WriteLine("2. Go to yard");
                Console.WriteLine("3. Go to cafeteria");
                Console.WriteLine("4. Go to outside of cell");
                celltemp = Console.ReadLine();
                celldec = Convert.ToInt32(celltemp);
            }
            if (celldec == 1)
            {
                Console.WriteLine();
                Console.WriteLine("You look around your cell");
                Console.WriteLine("It contains the basic things you would expect to find in a cell");
                    Console.WriteLine("A bed, a desk, a toilet, as well as a window to see the outside");
                Console.WriteLine("Probably there to tease prisoners");
                Console.WriteLine("What do you want to do");
                Console.WriteLine("1. Look at bed");
                Console.WriteLine("2. Look at toilet");
                Console.WriteLine("3. Look at desk");
                Console.WriteLine("4. Look through window");
                celltemp = Console.ReadLine();
                celldec = Convert.ToInt32(celltemp);
            }
            if (celldec == 2)
            {
                //SceneYard();
            }
            if (celldec == 3)
            {
                //SceneCafeteria();
            }
            if (celldec == 4) 
            {
                //SceneOC();
            }

            

        }

        public static void Scene1()
        {

        }

        public static void Inventory()
        {

        }
    }
}
