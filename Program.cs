using System;
using System.Threading;

namespace PB
{
    internal class Program
    {
        static bool flowers = false;
        static bool screwdriver = false;

        // =========================
        // MAIN ENTRY POINT
        // =========================
        static void Main(string[] args)
        {
            MainMenu();
        }

        // =========================
        // MAIN MENU
        // =========================
        static void MainMenu()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;

                
               Console.WriteLine("____________________.___  _________________    _______    _______________________________   _____   ____  __.\r\n\\______   \\______   \\   |/   _____/\\_____  \\   \\      \\   \\______   \\______   \\_   _____/  /  _  \\ |    |/ _|\r\n |     ___/|       _/   |\\_____  \\  /   |   \\  /   |   \\   |    |  _/|       _/|    __)_  /  /_\\  \\|      <  \r\n |    |    |    |   \\   |/        \\/    |    \\/    |    \\  |    |   \\|    |   \\|        \\/    |    \\    |  \\ \r\n |____|    |____|_  /___/_______  /\\_______  /\\____|__  /  |______  /|____|_  /_______  /\\____|__  /____|__ \\\r\n                  \\/            \\/         \\/         \\/          \\/        \\/        \\/         \\/        \\/");

                Console.ResetColor();

                Console.WriteLine("Hello human, welcome to our game!");


                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("1. Start Game");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("2. Exit Game");
                Console.ResetColor();

                Console.WriteLine();
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Starting Game...");
                        Console.WriteLine();
                        Console.Write("Loading ");

                        for (int i = 0; i < 5; i++)
                        {
                            Thread.Sleep(400);
                            Console.Write(".");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("[");

                        for (int i = 0; i < 20; i++)
                        {
                            Thread.Sleep(100);
                            Console.Write("■");
                        }

                        Console.WriteLine("]");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Intro();
                        break;

                    case "2":
                        Console.WriteLine("Closing Game...");
                        Thread.Sleep(1000);
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }

        // =========================
        // INTRO SCENE
        // =========================
        static void Intro()
        {
            Console.WriteLine("You have been convicted of watching anime on an illegal website.");
            Thread.Sleep(1000);
            Console.WriteLine("The Judge has commited you 25 life sentences due to your severe crime");
            Console.WriteLine("");
            Console.WriteLine("      -------------Outcast Juvenile Holding Center-------------");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Cell();
        }

        // =========================
        // CELL SCENE
        // =========================
        public static void Cell()
        {
            string celltemp;

            
            int celldec, cellchoice;
            Console.WriteLine("You arrive in your cell, a cramped cold and dirty cell");
            celldec = 0;

            if (celldec == 0)
            {
                Console.WriteLine("What would you like to do");
                Console.WriteLine("1. Check cell");
                Console.WriteLine("2. Go to yard");
                Console.WriteLine("3. Go to cafeteria");
                Console.WriteLine("4. Go to outside of cell");
                celltemp = Console.ReadLine();
                celldec = Convert.ToInt32(celltemp);
                switch (celldec)
                {
                    case 1:
                        Look();
                        break;
                    case 2:
                        celldec = 6;
                        break;
                    case 3:
                        celldec = 7;
                        break;
                    case 4:
                        celldec = 8;
                        break;
                    case 5:
                        celldec = 9;
                        break;

                }
            }

            if (celldec == 1)
            {
                Console.WriteLine();
                Console.WriteLine("You look around your cell");
                Console.WriteLine("It contains a bed, desk, toilet, and a window.");
                Console.WriteLine("What do you want to do");
                Console.WriteLine("1. Look at bed");
                Console.WriteLine("2. Look at toilet");
                Console.WriteLine("3. Look at desk");
                Console.WriteLine("4. Look through window");
                Console.WriteLine("5. Exit");
                celltemp = Console.ReadLine();
                cellchoice = Convert.ToInt32(celltemp);
                switch (cellchoice)
                {
                    case 1:
                        Bed();
                        break;
                        case 2:
                        celldec = 6;
                        break;
                        case 3:
                        celldec = 7;
                        break;
                        case 4:
                        celldec = 8;
                        break;
                        case 5:
                        Cell();
                        break;
                    
                }
            }
            
            if (celldec == 6)
            {
                Console.WriteLine("You look out the window just to see a solid concrete wall, how ironic...");
                Thread.Sleep(1500);
                celldec = 1;
            }

            if (celldec == 2)
            {
                Yard();
            }
            if (celldec == 7)
            {
                Cafeteria();
            }
            if (celldec == 4)
            {
                //SceneOC();
            }
        }

        public static void Look()
        {
            string celltemp;
            int celldec, cellchoice;
            Console.WriteLine();
            Console.WriteLine("You look around your cell");
            Console.WriteLine("It contains a bed, desk, toilet, and a window.");
            Console.WriteLine("What do you want to do");
            Console.WriteLine("1. Look at bed");
            Console.WriteLine("2. Look at toilet");
            Console.WriteLine("3. Look at desk");
            Console.WriteLine("4. Look through window");
            Console.WriteLine("5. Exit");
            celltemp = Console.ReadLine();
            cellchoice = Convert.ToInt32(celltemp);
            switch (cellchoice)
            {
                case 1:
                    Bed();
                    break;
                case 2:
                    celldec = 6;
                    break;
                case 3:
                    celldec = 7;
                    break;
                case 4:
                    celldec = 8;
                    break;
                case 5:
                    celldec = 9;
                    break;

            }
        }
        public static void Bed()
        {
            Console.WriteLine("It's an old rusty bed. The mattress has some weird stains on them, might be blood.");
            Thread.Sleep(1500);
            Look();
        }

        // =========================
        // YARD SCENE
        // =========================
        public static void Yard()
        {
            bool inYard = true;

            while (inYard)
            {
                int action_1 = 0, action_2 = 0;

                Console.WriteLine("You enter the Yard");
                Console.WriteLine("You look around and see another inmate");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1:\tConfront Jamal");
                Console.WriteLine("2:\tExit Yard");

                action_1 = Convert.ToInt32(Console.ReadLine());

                switch (action_1)
                {
                    case 1:
                        Console.WriteLine("You approach Jamal");
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1:\tFight Jamal");
                        Console.WriteLine("2:\tTalk to Jamal");
                        Console.WriteLine("3:\tGive Jamal a gift");
                        Console.WriteLine("4:\tCheck the Yard");

                        action_2 = Convert.ToInt32(Console.ReadLine());

                        switch (action_2)
                        {
                            case 1:
                                break;

                            case 2:
                                Console.WriteLine("JAMAL:\t'Hmmm, I could really use some flowers right now'");
                                break;

                            case 3:
                                Gift_Jamal();
                                break;

                            case 4:
                                Console.WriteLine("You check around the yard and find a batch of flowers.");
                                flowers = true;
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("You leave the Yard");
                        inYard = false;
                        Cell();
                        break;
                }
            }
        }

        public static void Gift_Jamal()
        {
            if (flowers)
            {
                Console.WriteLine("JAMAL:\t'Aww flowers, thank you so much. Here's a screwdriver'");
                screwdriver = true;
                flowers = false;
            }
            else
            {
                Console.WriteLine("You don't have anything to give Jamal");
            }

            Yard();
        }

        // =========================
        // CAFETERIA
        // =========================
        static bool pudding;
        public static void Cafeteria()
        {
            int action_1 = 0;
            int action_2 = 0;
            Console.WriteLine("You enter the Cafeteria and look around.");
            Console.WriteLine("You see Crack Head Joe sitting at a table.");
            Console.WriteLine("You also see the chow line.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1:\tTalk to Crack Head Joe.");
            Console.WriteLine("2:\tEnter the Chow Line.");
            Console.WriteLine("3:\tExit Cafeteria.");

            action_1 = Convert.ToInt32(Console.ReadLine());

            switch (action_1)
            {
                case 1:
                    Console.WriteLine("You walk up to Crack Head Joe.");
                    Console.WriteLine("'Hmmm... I could really use some pudding right now' he mutters.");
                    if (pudding != true)
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1:\tGo Back.");
                        action_2 = Convert.ToInt32(Console.ReadLine());
                        switch (action_2)
                        {
                            case 1:
                                Cafeteria();
                                break;
                        }
                            
                    }
                    break;

                case 2:
                    break;
            }
        }
    }
}
