using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml.Serialization;

namespace PB
{
    internal class Program
    {

        static bool flowers = false;
        static bool screwdriver = false;
        static bool shiv = false;
        static bool soap = false;
        static int strength = 0;
        static int money = 10;
        static bool inmate = true;

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
                Console.SetCursorPosition(0, 0);


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

                Console.WriteLine("\t\t\t\tHello human, welcome to our game!");


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
                            Thread.Sleep(100);
                            Console.Write(".");
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("[");

                        for (int i = 0; i < 20; i++)
                        {
                            Thread.Sleep(30);
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

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("      -------------Outcast Juvenile Holding Center-------------");
            Console.ResetColor();

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

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. Check cell");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2. Go to yard");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("3. Go to cafeteria");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("4. Go to showers");

                Console.ResetColor();

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
            Console.WriteLine("");
            if (flowers)
            {
                Console.WriteLine("\tFlowers");
                Console.WriteLine("");
            }
            if (shiv)
            {
                Console.WriteLine("\tShiv");
                Console.WriteLine("");
            }
            if (screwdriver)
            {
                Console.WriteLine("\tScrewdriver");
                Console.WriteLine("");
            }
            if (soap)
            {
                Console.WriteLine("\tSoap");
                Console.WriteLine("");
            }
            Console.WriteLine($"\tStrentgh = {strength}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press 'Enter' to exit");
            Console.ReadLine();
            Look();
        }
        public static void toilet()
        {
            int cellchoice, cellchoice2;
            Console.WriteLine("There's a toilet in the corner of the cell, it seems to be connected by some screws");
            Console.WriteLine("1. Remove toilet from wall (Screwdriver needed)");
            Console.WriteLine("2. Leave toilet");
            cellchoice = Convert.ToInt32(Console.ReadLine());
            switch (cellchoice)
            {
                case 1:
                    if (screwdriver == true)
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
                if (inmate == true)
                {
                    Console.WriteLine("1:\tConfront the inmate");
                }

                Console.WriteLine("2:\tCheck the Yard");
                Console.WriteLine("3:\tExit the Yard");

                action_1 = Convert.ToInt32(Console.ReadLine());

                switch (action_1)
                {
                    case 1:
                        Console.WriteLine("You approach the inmate");
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1:\tFight the inmate");
                        Console.WriteLine("2:\tTalk to the inmate");
                        Console.WriteLine("3:\tGive the inmate a gift");
                        Console.WriteLine("4:\tGo back");

                        action_2 = Convert.ToInt32(Console.ReadLine());

                        switch (action_2)
                        {
                            case 1:
                                if (shiv != true)
                                {
                                    Console.WriteLine("You walk up to the inmate and take a swing. He bashes you on the skull, instantly killing you.");
                                    Console.WriteLine("You are dead. Sending back to Yard.");

                                    string[] frames =
                                    {
                                        "(-_- )    ⌐■-■ ",
                                        "( -_-)>  ( •_•)",
                                        "(x_x) oh noo im dead now'"
                                    };

<<<<<<< HEAD
                                        string[] frames =
    {
        "(-_- )    ⌐■-■ ",
        "( -_-)>  ( •_•)",
        "(x_x) oh noo im dead now"
    };

                                        foreach (string frame in frames)
                                        {
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(frame);
                                            Console.ResetColor();

                                            Thread.Sleep(500);
                                        }

                                        YardDeath();
                                    }
                                    if (shiv == true)
=======
                                    foreach (string frame in frames)
>>>>>>> ac764fa6f45feeca2ac252b01b782a932aefa818
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(frame);
                                        Console.ResetColor();

                                        Thread.Sleep(500);
                                    }

                                    YardDeath();
                                }
                                if (shiv == true)
                                {
                                    Console.WriteLine("You walk up to the inmate and take a swing with your shiv. He falls to the ground. Dropping a screwdriver.");
                                    Console.WriteLine("You pick it up.");
                                    screwdriver = true;
                                    inmate = false;
                                    Cell();
                                }
                                break;

                            case 2:
                                Console.WriteLine("INMATE:\t'Hmmm, I could really use some flowers right now'");
                                break;

                            case 3:
                                Gift_Jamal();
                                break;

                            case 4:
                                break;
                        }
                        break;


                    case 2:
                        Check_Yard();
                        break;
                    case 3:
                        Console.WriteLine("You leave the Yard");
                        inYard = false;
                        Cell();
                        break;

                }
            }
        }
        public static void Check_Yard()
        {
            int action = 0;
            Console.WriteLine("You look around the Yard");
            Console.WriteLine("You see a small flower garden, a makeshift casino, and a gym");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1:\tWalk over to the garden");
            Console.WriteLine("2:\tGo to the casino");
            Console.WriteLine("3:\tCheck out the gym");
            Console.WriteLine("4:\tGo back");
            action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    Console.WriteLine("You walk over to the garden and pick some flowers");
                    flowers = true;
                    break;
                case 2:
                    Casino();
                    break;
                case 3:
                    Console.WriteLine("You go to check out the gym and work out");
                    Console.WriteLine("You gained 1 strentgh");
                    strength++;
                    break;
                case 4:
                    Yard();
                    break;

            }
        }

        public static void Gift_Jamal()
        {
            if (flowers)
            {
                Console.WriteLine("BIG DOG:\t'Aww flowers, thank you so much. Here's a screwdriver'");
                screwdriver = true;
                flowers = false;
            }
            else
            {
                Console.WriteLine("You don't have anything to give Big Dog");
            }

            Yard();
        }
        // =========================
        // CASINO
        // =========================

        public static void Casino()
        {
            int action = 0;
            int choice = 0;
            Console.WriteLine("\t======================================");
            Console.WriteLine("\t              CASINO");
            Console.WriteLine("\t======================================");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Casino!");
            Console.WriteLine("Here you can play roulette or blackjack");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1:\tRoulette");
            Console.WriteLine("2:\tBlackjack");
            Console.WriteLine("1:\tBack to the Yard");
            action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("How to play roulette:");
                    Console.WriteLine("You can choose to bet on either red or black");
                    Console.WriteLine("If it lands on the colour you choose, you double your bet");
                    Console.WriteLine("");
                    Console.WriteLine("What is your decision?");
                    Console.WriteLine("1:\tBet on black");
                    Console.WriteLine("2:\tBet on red");
                    Console.WriteLine("3:\tGo back");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            break;

                        case 2:
                            break;

                        case 3:
                            break;
                    }
                    break;

                case 2:
                    break;

                case 3:
                    Yard();
                    break;
            }
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
            Console.WriteLine("1: Jump to the next building");
            Console.WriteLine("2: Move to the other side of the roof");
            Console.WriteLine("3: Go back to cell");
            cellchoice = Convert.ToInt32(Console.ReadLine());
            switch (cellchoice)
            {
                case 1:
                    Jump();
                    break;

                case 2:
                    Move();
                    break;

                case 3:
                    Cell();
                    break;
            }
        }
        public static void Jump()
        {
            Console.WriteLine("You start running and get ready to jump to the other building but your foot slips and you fall, spliting your head open");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  ________                        ________                     \r\n /  _____/_____    _____   ____   \\_____  \\___  __ ___________ \r\n/   \\  ___\\__  \\  /     \\_/ __ \\   /   |   \\  \\/ // __ \\_  __ \\\r\n\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  /    |    \\   /\\  ___/|  | \\/\r\n \\______  (____  /__|_|  /\\___  > \\_______  /\\_/  \\___  >__|   \r\n        \\/     \\/      \\/     \\/          \\/          \\/       ");
            Console.ResetColor();

            Console.WriteLine("1: Continue from last checkpoint.");
            Console.WriteLine("2: Exit to menu.");
            int action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    Roof();
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
        public static void Move()
        {
            int cellchoice;
            Console.WriteLine("You move to the other side of the roof and find yourself near the surrounding fence.");
            Console.WriteLine("There seem to be 2 possible ways you can make it out of this");
            Console.WriteLine("There's a space in between the barbed wire that you could possibly crawl through, but it seems risky");
            Console.WriteLine("There's also a guard tower that you could possibly climb up to and escape through there, but there may be someone inside");
            Console.WriteLine("1. Climb the guard tower");
            Console.WriteLine("2. Crawl through the barbed fence");
            cellchoice = Convert.ToInt32(Console.ReadLine());
            switch (cellchoice)
            {
                case 1:
                    Tower();
                    break;
                case 2:
                    fence();
                    break;
            }
        }
        public static void fence()
        {

        }
        public static void Tower()
        {
            int choice;
            Console.WriteLine("You take a step back before leaping onto the side of the guard tower");
            Console.WriteLine("Luckily, You manage to grab onto a fixed light on the side of the tower");
            Console.WriteLine("You lift yourself over the railing and make it into the tower");
            Console.WriteLine("Unfortunetly, a guard happened to be inside the tower as you made it inside");
            Console.WriteLine("The guard aims their gun at you and orders you to comply ");
            Console.WriteLine("You can see a way to escape the prison on just the other side of the tower, but you need to get past the guard");
            Console.WriteLine("1. Reason with the guard");
            Console.WriteLine("2. Fight the guard");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    
                    break;
                        case 2:

                    break;
            }
        }
        public static void Reason()
        {

        }
        public static void TowerFight()
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
            Console.WriteLine("2. Take a shower");
            Console.WriteLine("3. Leave showers");
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
                Console.WriteLine("You take a shower and feel clean.");
                Showers();
            }
            else if (cellchoice == 3)
            {
                Cell();
            }

        }

        public static void YardDeath()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  ________                        ________                     \r\n /  _____/_____    _____   ____   \\_____  \\___  __ ___________ \r\n/   \\  ___\\__  \\  /     \\_/ __ \\   /   |   \\  \\/ // __ \\_  __ \\\r\n\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  /    |    \\   /\\  ___/|  | \\/\r\n \\______  (____  /__|_|  /\\___  > \\_______  /\\_/  \\___  >__|   \r\n        \\/     \\/      \\/     \\/          \\/          \\/       ");
            Console.ResetColor();


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
