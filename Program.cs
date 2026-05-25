using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace PB
{
    internal class Program
    {

        
        static bool flowers = false;
        static bool screwdriver = false;
        static bool shiv = false;
        static bool soap = false;

        // =========================
        // MAIN ENTRY POINT
        // =========================
        static void Main(string[] args)
        {
            MainMenu();
        }

         // =========================
        // ANIMATED TITLE
        // =========================
        public static void AnimatedTitle()
        {
            string[] title =
            {
                "____________________.___  _________________    _______    _______________________________   _____   ____  __.",
                "\\______   \\______   \\   |/   _____/\\_____  \\   \\      \\   \\______   \\______   \\_   _____/  /  _  \\ |    |/ _|",
                " |     ___/|       _/   |\\_____  \\  /   |   \\  /   |   \\   |    |  _/|       _/|    __)_  /  /_\\\\  \\|      < ",
                " |    |    |    |   \\   |/        \\/    |    \\/    |    \\  |    |   \\|    |   \\|        \\/    |    \\    |  \\",
                " |____|    |____|_  /___/_______  /\\_______  /\\____|__  /  |______  /|____|_  /_______  /\\____|__  /____|__ \\",
                "                  \\/            \\/         \\/         \\/          \\/        \\/        \\/         \\/        \\/"
            };

            ConsoleColor[] colors =
            {
                ConsoleColor.Red,
                ConsoleColor.Yellow,
                ConsoleColor.Green,
                ConsoleColor.Cyan,
                ConsoleColor.Magenta
            };

            for (int flash = 0; flash < 5; flash++)
            {
                Console.Clear();

                Console.ForegroundColor = colors[flash % colors.Length];

                foreach (string line in title)
                {
                    Console.WriteLine(line);
                    Thread.Sleep(50);
                }

                Thread.Sleep(100);
            }

            Console.ResetColor();
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

                AnimatedTitle();

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

                        Console.ForegroundColor = ConsoleColor.Green;
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
                        Console.ResetColor();

                        Thread.Sleep(1000);
                        Console.Clear();
                        Intro();
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Closing Game...");
                        Console.ResetColor();

                        Thread.Sleep(1000);
                        running = false;
                        Environment.Exit(0);
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
            TypeText("You have been convicted of watching anime on an illegal website.");
            TypeText("The Judge has committed you to 25 life sentences due to your severe crime");

            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("      -------------Outcast Juvenile Holding Center-------------");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Cell();
        }

        // =========================
        // TYPEWRITER EFFECT
        // =========================
        public static void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }

            Console.WriteLine();
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
                Console.WriteLine("4. Go to showers");
                celltemp = Console.ReadLine();
                celldec = Convert.ToInt32(celltemp);
                switch (celldec)
                {
                    case 1:
                        Look();
                        break;
                    case 2:
                        Yard();
                        break;
                    case 3:
                        Cafeteria();
                        break;
                    case 4:
                        Showers();
                        break;
                    

                }
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
            Console.WriteLine("3. Look inside desk");
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
                    toilet();
                    break;
                case 3:
                    inventory();
                    break;
                case 4:
                    Window();
                    break;
                case 5:
                    Cell();
                    break;

            }
        }
        public static void Bed()
        {
            Console.WriteLine("It's an old rusty bed. The mattress has some weird stains on them, might be blood.");
            Thread.Sleep(1500);
            Look();
        }
        public static void Window()
        {
            Console.WriteLine("You look out the window just to see a solid concrete wall, how ironic...");
            Thread.Sleep(1500);
            Look();
        }
        public static void inventory()
        {
            Console.WriteLine("\tInventory");
            Console.ReadLine();
            Look();
        }
        public static void toilet() {
            int cellchoice, cellchoice2;
            Console.WriteLine("There's a toilet in the corner of the cell, it seems to be connected by some screws");
            Console.WriteLine("1. Remove toilet from wall (Screwdriver needed)");
            Console.WriteLine("2. Leave toilet");
            cellchoice = Convert.ToInt32(Console.ReadLine());
            switch (cellchoice)
            {
                case 1:
                    if (screwdriver = true)
                    {
                        Console.WriteLine("You unscrew the screws from the toilet.");
                        Console.WriteLine("You remove the toilet from the wall to see a hole that leads to behind the cell.");
                        Console.WriteLine("Inside, you see a ladder that seems to lead to the roof.");
                        Console.WriteLine("1. Go to roof");
                        Console.WriteLine("2. Return to cell");
                        cellchoice2 = Convert.ToInt32(Console.ReadLine());
                        switch (cellchoice2)
                        {
                            case 1:
                                Roof();
                                break;
                            case 2:
                                Console.WriteLine("You go back to your cell and screw the toilet back to the wall");
                                Look();
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("You need a screwdriver");
                        Thread.Sleep(1000);
                        Look();
                    }
                        break;
                    case 2:
                    Look();
                    break;
            }
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
                if (screwdriver != true)
                {
                    Console.WriteLine("1:\tConfront Jamal");
                }
         
                Console.WriteLine("2:\tExit Yard");

                action_1 = Convert.ToInt32(Console.ReadLine());

                if (screwdriver != true)
                {
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
                                    if (shiv != true)
                                    {
                                        Console.WriteLine("You walk to jamal and take a swing. He bashes you on the skull, instantly killing you.");
                                        Console.WriteLine("You are dead. Sending back to Yard.");
                                        YardDeath();
                                    }
                                    if (shiv == true)
                                    {
                                        Console.WriteLine("You walk to jamal and take a swing with your shiv. He falls to the ground. Dropping a screwdriver.");
                                        Console.WriteLine("You pick it up.");
                                        screwdriver = true;
                                        Cell();
                                    }
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
                else
                {
                    switch (action_1)
                    {
                        case 2:
                            Console.WriteLine("You leave the Yard");
                            inYard = false;
                            Cell();
                            break;
                    }
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
        static bool pudding = false;

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
                    else
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1:\tGo Back.");
                        Console.WriteLine("2:\tGive Crack Head Joe Pudding.");
                        action_2 = Convert.ToInt32(Console.ReadLine());
                        switch (action_2)
                        {
                            case 1:
                                Cafeteria();
                                break;
                            case 2:
                                if (shiv != true)
                                {
                                    Console.WriteLine("Thanks kid heres a shiv");
                                    shiv = true;
                                }
                                else
                                {
                                    Console.WriteLine("Bro You already tried that go away.");
                                }

                                    Cafeteria();
                                break;
                        }
                    }
                        break;

                case 2:
                    Console.WriteLine("You enter the chow line. Today they are serving pudding. ONE PER INMATE.");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1:\tGo Back.");
                    Console.WriteLine("2:\tGet some pudding.");
                    action_2 = Convert.ToInt32(Console.ReadLine());
                    switch (action_2)
                    {
                        case 1:
                            Cafeteria();
                            break;
                        case 2:
                            if (pudding != true)
                            {
                                Console.WriteLine("You have recieved pudding!");
                                pudding = true;
                  
                            }
                            else
                            {
                                Console.WriteLine("You've already got your pudding!");
                            }
                            Cafeteria();
                            break;


                    }
                    break;
                    case 3: 
                    Cell();
                    break;
            }
        }
        public static void Roof()
        {
            int cellchoice = 0;
            Console.WriteLine("You find yourself ontop of the prison roof. There seem to be 2 possible ways to go");
            Console.WriteLine("1. Jump to the next building");
            Console.WriteLine("2. Move tpo the other sid eof roof");
            cellchoice = Convert.ToInt32(Console.ReadLine());
            if (cellchoice == 1)
            {
                Jump();
            }
            if (cellchoice == 2)
            {
                Move();
            }
        }
        public static void Jump()
        {

        }
        public static void Move()
        {

        }
        public static void Showers()
        {
            int cellchoice;
            Console.WriteLine("The showers are all empty, the only thing you see is a bar of soap on the floor");
            if (soap != true)
            {
                Console.WriteLine("1. Pick up Soap");
            }
            Console.WriteLine("2. Leave showers");
            cellchoice = Convert.ToInt32(Console.ReadLine());
            if (soap != true)
            {
                if (cellchoice == 1)
                {
                    Console.WriteLine("You pick up the soap");
                    soap = true;
                    Showers();
                }
            }
            if (cellchoice == 2)
            {
                Cell();
            }

        }

        public static void YardDeath()
        {
            Console.WriteLine("PlaceHolder GameOver");
            Console.WriteLine("1: Continue from last checkpoint.");
            Console.WriteLine("2: Exit to menu.");
            int action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    break;

                    case 2:
                    flowers = false;
                    screwdriver = false;
                    shiv = false;
                    soap = false;
                    pudding = false;
                    MainMenu();
                    break;
            }
        }
    }
}
