using System;
using System.Data;
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
        static bool cross = false;

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
              " ███████████  ███████████   █████  █████████     ███████    ██████   █████    ███████████  ███████████   ██████████   █████████   █████   ████",
              "▒▒███▒▒▒▒▒███▒▒███▒▒▒▒▒███ ▒▒███  ███▒▒▒▒▒███  ███▒▒▒▒▒███ ▒▒██████ ▒▒███    ▒▒███▒▒▒▒▒███▒▒███▒▒▒▒▒███ ▒▒███▒▒▒▒▒█  ███▒▒▒▒▒███ ▒▒███   ███▒ ",
              " ▒███    ▒███ ▒███    ▒███  ▒███ ▒███    ▒▒▒  ███     ▒▒███ ▒███▒███ ▒███     ▒███    ▒███ ▒███    ▒███  ▒███  █ ▒  ▒███    ▒███  ▒███  ███   ",
              " ▒██████████  ▒██████████   ▒███ ▒▒█████████ ▒███      ▒███ ▒███▒▒███▒███     ▒██████████  ▒██████████   ▒██████    ▒███████████  ▒███████    ",
              " ▒███▒▒▒▒▒▒   ▒███▒▒▒▒▒███  ▒███  ▒▒▒▒▒▒▒▒███▒███      ▒███ ▒███ ▒▒██████     ▒███▒▒▒▒▒███ ▒███▒▒▒▒▒███  ▒███▒▒█    ▒███▒▒▒▒▒███  ▒███▒▒███   ",
              " ▒███         ▒███    ▒███  ▒███  ███    ▒███▒▒███     ███  ▒███  ▒▒█████     ▒███    ▒███ ▒███    ▒███  ▒███    ▒█ ▒███    ▒███  ▒███ ▒▒███  ",
              " █████        █████   █████ █████▒▒█████████  ▒▒▒███████▒   █████  ▒▒█████    ███████████  █████   █████ ██████████ █████   █████ █████ ▒▒████",
              " ▒▒▒▒▒        ▒▒▒▒▒   ▒▒▒▒▒ ▒▒▒▒▒  ▒▒▒▒▒▒▒▒▒     ▒▒▒▒▒▒▒    ▒▒▒▒▒    ▒▒▒▒▒    ▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒   ▒▒▒▒▒ ▒▒▒▒▒▒▒▒▒▒ ▒▒▒▒▒   ▒▒▒▒▒ ▒▒▒▒▒   ▒▒▒▒"
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

                TypeText("\t\t\t\tHello human, welcome to our game!");


                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Start Game");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("2. Exit Game");
                Console.ResetColor();

                Console.WriteLine("3. How to Play");

                Console.WriteLine();
                Console.WriteLine("Choose an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();


                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeText("Loading ");
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

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypeText("Closing Game...");
                        Console.ResetColor();

                        Thread.Sleep(1000);
                        running = false;
                        Environment.Exit(0);
                        break;

                    case 3:
                        HowToPlay();
                        break;

                    default:
                        TypeText("Invalid Option");
                        Thread.Sleep(1000);
                        break;
                }
            }


        }

        public static void HowToPlay()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=============== HOW TO PLAY ===============");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Welcome to Outcast Juvenile Holding Center.");
            Console.WriteLine("Your goal is simple: survive, explore, and escape.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BASIC CONTROLS");
            Console.ResetColor();
            Console.WriteLine("- Type the number of the option you want to choose.");
            Console.WriteLine("- Press Enter to confirm.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("GAMEPLAY");
            Console.ResetColor();
            Console.WriteLine("- Explore different areas like your cell, yard, cafeteria, and showers.");
            Console.WriteLine("- Collect items to help you survive or escape.");
            Console.WriteLine("- Interact with inmates—some friendly, some deadly.");
            Console.WriteLine("- Earn money in the casino, gain strength in the gym, or find hidden paths.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WINNING & LOSING");
            Console.ResetColor();
            Console.WriteLine("- You can escape through various methods depending on your choices.");
            Console.WriteLine("- Bad decisions (like fighting unarmed) may result in death.");
            Console.WriteLine("- Death sends you back to try again.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TIPS");
            Console.ResetColor();
            Console.WriteLine("- Items matter. Some paths require specific tools.");
            Console.WriteLine("- Talking before fighting can reveal clues.");
            Console.WriteLine("- Strength helps in combat.");
            Console.WriteLine("- Money helps everywhere.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press Enter to return to the Main Menu.");
            Console.ResetColor();
            Console.ReadLine();
            MainMenu();
        }


        // =========================
        // INTRO SCENE
        // =========================
        static void Intro()
        {
            bool invalidInput = true;
            invalidInput = true;
            Console.WriteLine("Would you like to skip the intro");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            while (invalidInput == true)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    invalidInput = false;
                    Console.Clear();
                    Cell();
                }
                if (choice == 2)
                {
                    invalidInput = false;
                    Console.Clear();
                    TypeText("You have been convicted of watching anime on an illegal website.");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    TypeText("The Judge has committed you to 25 life sentences due to your severe crime");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    TypeText("You were sent to the most hardcore prison within the area");
                    Thread.Sleep(1000);

                    Thread.Sleep(100);
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    TypeText("      -------------Outcast Juvenile Holding Center-------------");
                    Thread.Sleep(1000);
                    Console.ResetColor();

                    Console.WriteLine("");
                    Cell();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
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
            Console.Clear();
            int celldec;
            TypeText("You arrive in your cell, a cramped cold and dirty cell");
            Thread.Sleep(100);
            TypeText("What would you like to do");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1:\tCheck cell");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2:\tGo to yard");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3:\tGo to cafeteria");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("4:\tGo to showers");

            Console.ResetColor();

            bool invalidInputCheck = true;
            while (invalidInputCheck)
            {
                celldec = Convert.ToInt32(Console.ReadLine());
                switch (celldec)
                {
                    case 1:
                        invalidInputCheck = false;
                        Look();
                        break;
                    case 2:
                        invalidInputCheck = false;
                        Yard();
                        break;
                    case 3:
                        invalidInputCheck = false;
                        Cafeteria();
                        break;
                    case 4:
                        invalidInputCheck = false;
                        Showers();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;


                }
            }
        }

        public static void Look()
        {
            int cellchoice;
            Console.WriteLine();
            TypeText("You look around your cell");
            TypeText("It contains a bed, desk, toilet, and a window.");
            TypeText("What do you want to do");
            Thread.Sleep(100);
            Console.WriteLine("1:\tLook at bed");
            Thread.Sleep(100);
            Console.WriteLine("2:\tLook at toilet");
            Thread.Sleep(100);
            Console.WriteLine("3:\tLook inside desk");
            Thread.Sleep(100);
            Console.WriteLine("4:\tLook through window");
            Thread.Sleep(100);
            Console.WriteLine("5:\tExit");
            Thread.Sleep(100);
            if (cross)
            {
                Console.WriteLine("");
                Console.WriteLine("=====================");
                Console.WriteLine("6:\tPray");
                Console.WriteLine("=====================");
            }
            bool invalidInputCheck = true;
            while (invalidInputCheck)
            {
                cellchoice = Convert.ToInt32(Console.ReadLine());
                switch (cellchoice)
                {
                    case 1:
                        invalidInputCheck = false;
                        Console.Clear();
                        Bed();
                        break;
                    case 2:
                        invalidInputCheck = false;
                        Console.Clear();
                        toilet();
                        break;
                    case 3:
                        invalidInputCheck = false;
                        Console.Clear();
                        inventory();
                        break;
                    case 4:
                        invalidInputCheck = false;
                        Console.Clear();
                        Window();
                        break;
                    case 5:
                        invalidInputCheck = false;
                        Console.Clear();
                        Cell();
                        break;
                    case 6:
                        if (cross)
                        {
                            invalidInputCheck = false;
                            Console.Clear();
                            Pray();
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            } 
        }

        public static void Pray()
        {
            TypeText("You put on the pendant and kneel on the cold stone floor.");
            TypeText("Closing your eyes, you begin to pray...");

            Thread.Sleep(1000);

            for (int i = 0; i < 3; i++)
            {
                TypeText("..............");
                Thread.Sleep(1000);
            }

            // Earthquake
            Console.Beep(200, 300);
            Console.Beep(180, 300);
            Console.Beep(160, 500);

            TypeText("Suddenly, the ground begins to shake!");
            TypeText("Cracks spread across the prison walls!");

            Thread.Sleep(1500);

            Console.Beep(100, 1000);

            TypeText("A blinding light erupts from above!");

            Thread.Sleep(2000);

            // Jesus descending animation
            string[] frames =
            {
@"
                 ✨
                ☁☁☁
                  O
                 /|\
                 / \
",

@"
                 
                 ✨
                ☁☁☁
                  O
                 /|\
                 / \
",

@"
                 
                 
                 ✨
                ☁☁☁
                  O
                 /|\
                 / \
",

@"
                 
                 
                 
                 ✨
                ☁☁☁
                  O
                 /|\
                 / \
",

@"
                 
                 
                 
                 
                 ✨
                ☁☁☁
                  O
                 /|\
                 / \
"
    };

            foreach (string frame in frames)
            {
                Console.Clear();
                Console.WriteLine(frame);

                Console.Beep(900, 150);

                Thread.Sleep(700);
            }

            Console.Clear();

            // Heavenly fanfare
            Console.Beep(523, 250); // C
            Console.Beep(659, 250); // E
            Console.Beep(784, 500); // G
            Console.Beep(1046, 1000); // High C

            TypeText("You shield your eyes from the brilliance.");
            TypeText("A figure emerges from the light...");
            Thread.Sleep(1500);

            TypeText("It is Jesus Christ.");

            Thread.Sleep(1000);

            TypeText("\"Do not be afraid,\" He says.");
            TypeText("\"Your prayers have been heard.\"");

            Console.Beep(1200, 500);

            TypeText("The chains around your wrists shatter.");
            TypeText("The prison doors burst open.");
            TypeText("The darkness flees from His presence.");

            Thread.Sleep(1500);

            TypeText("Jesus extends His hand.");

            Thread.Sleep(1000);

            TypeText("You take it.");

            Console.Beep(1500, 800);

            TypeText("A warm peace fills your heart.");
            TypeText("You begin to rise into the sky.");
            TypeText("Far below, the prison collapses into ruins.");
            TypeText("You have been set free.");

            Thread.Sleep(1000);

            Win();
        }
        public static void Bed()
        {
            TypeText("It's an old rusty bed. The mattress has some weird stains on them, might be blood.");
            Thread.Sleep(1500);
            Look();
        }
        public static void Window()
        {
            TypeText("You look out the window just to see a solid concrete wall, how ironic...");
            Thread.Sleep(1500);
            Look();
        }
        public static void inventory()
        {
            TypeText("\tInventory");
            Console.WriteLine("");
            Thread.Sleep(100);
            if (flowers)
            {
                Console.WriteLine("\tFlowers");
                Console.WriteLine("");
                Thread.Sleep(100);
            }
            if (shiv)
            {
                Console.WriteLine("\tShiv");
                Console.WriteLine("");
                Thread.Sleep(100);
            }
            if (screwdriver)
            {
                Console.WriteLine("\tScrewdriver");
                Console.WriteLine("");
                Thread.Sleep(100);
            }
            if (cross)
            {
                Console.WriteLine("\tCross Pendent");
                Console.WriteLine("");
                Thread.Sleep(100);
            }
            if (pudding)
            {
                Console.WriteLine("\tPudding");
                Console.WriteLine("");
                Thread.Sleep(100);
            }
            if (soap)
            {
                Console.WriteLine("\tSoap");
                Console.WriteLine("");
                Thread.Sleep(100);
            }
            Console.WriteLine($"\t${money}");
            Console.WriteLine("");
            Thread.Sleep(100);
            Console.WriteLine($"\tStrentgh = {strength}");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(100);
            TypeText("Press 'Enter' to exit");
            Console.ReadLine();
            Console.Clear();
            Look();
        }
        public static void toilet()
        {
            int cellchoice, cellchoice2;
            TypeText("There's a toilet in the corner of the cell, it seems to be connected by some screws");
            Thread.Sleep(100);
            Console.WriteLine("1:\tRemove toilet from wall (Screwdriver needed)");
            Thread.Sleep(100);
            Console.WriteLine("2:\tLeave toilet");

            bool invalidInputCheck = true;
            while (invalidInputCheck)
            {
                cellchoice = Convert.ToInt32(Console.ReadLine());
                switch (cellchoice)
                {
                    case 1:
                        invalidInputCheck = false;
                        if (screwdriver == true)
                        {
                            TypeText("You unscrew the screws from the toilet.");
                            Console.WriteLine();
                            TypeText("You remove the toilet from the wall to see a hole that leads to behind the cell.");
                            Console.WriteLine();
                            TypeText("Inside, you see a ladder that seems to lead to the roof.");
                            Thread.Sleep(100);
                            Console.WriteLine("1. Go to roof");
                            Thread.Sleep(100);
                            Console.WriteLine("2. Return to cell");
                            bool invalidInput = true;
                            while (invalidInput == true)
                            {
                                cellchoice2 = Convert.ToInt32(Console.ReadLine());
                                switch (cellchoice2)
                                {
                                    case 1:
                                        invalidInput = false;
                                        Roof();
                                        break;
                                    case 2:
                                        invalidInput = false;
                                        TypeText("You go back to your cell and screw the toilet back to the wall");
                                        Look();
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            TypeText("You need a screwdriver");
                            Thread.Sleep(1000);
                            Look();
                        }
                        break;
                    case 2:
                        invalidInputCheck = false;
                        Look();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        // =========================
        // YARD SCENE
        // =========================
        public static void Yard()
        {
            Console.Clear() ;
            bool inYard = true;

            while (inYard)
            {
                int action_1 = 0, action_2 = 0;

                TypeText("You enter the Yard");
                TypeText("You look around and see another inmate");
                TypeText("What would you like to do?");
                Thread.Sleep(100);
                if (inmate == true)
                {
                    Console.WriteLine("1:\tConfront the inmate");
                    Thread.Sleep(100);
                }

                Console.WriteLine("2:\tCheck the Yard");
                Thread.Sleep(100);
                Console.WriteLine("3:\tExit the Yard");

                bool invalidInputCheck = true;
                while (invalidInputCheck)
                {
                    action_1 = Convert.ToInt32(Console.ReadLine());

                    switch (action_1)
                    {
                        case 1:
                            invalidInputCheck = false;
                            TypeText("You approach the inmate");
                            TypeText("What would you like to do?");
                            Thread.Sleep(100);
                            Console.WriteLine("1:\tFight the inmate");
                            Thread.Sleep(100);
                            Console.WriteLine("2:\tTalk to the inmate");
                            Thread.Sleep(100);
                            Console.WriteLine("3:\tGive the inmate a gift");
                            Thread.Sleep(100);
                            Console.WriteLine("4:\tGo back");

                            bool invalidInputCheck2 = true;
                            while (invalidInputCheck2)
                            {
                                action_2 = Convert.ToInt32(Console.ReadLine());

                                switch (action_2)
                                {
                                    case 1:
                                        invalidInputCheck2 = false;
                                        if (shiv != true)
                                        {
                                            TypeText("You walk up to the inmate and take a swing. He bashes you on the skull, instantly killing you.");
                                            TypeText("You are dead. Sending back to Yard.");

                                            string[] frames =
                                            {
                                                "(-_- )    ⌐■-■ ",
                                                "( -_-)>  ( •_•)",
                                                "(x_x) oh noo im dead now'"
                                            };

                                            foreach (string frame in frames)
                                            {
                                                Console.Clear();
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                TypeText(frame);
                                                Console.ResetColor();

                                                Thread.Sleep(500);
                                            }

                                            Death();
                                        }
                                        if (shiv == true)
                                        {
                                            TypeText("You walk up to the inmate and take a swing with your shiv. He falls to the ground. Dropping a screwdriver.");
                                            TypeText("You pick it up.");
                                            screwdriver = true;
                                            inmate = false;
                                            Cell();
                                        }
                                        break;

                                    case 2:
                                        invalidInputCheck2 = false;
                                        TypeText("INMATE:\t'Hmmm, I could really use some flowers right now'");
                                        break;

                                    case 3:
                                        invalidInputCheck2 = false;
                                        Gift_Jamal();
                                        break;

                                    case 4:
                                        invalidInputCheck2 = false;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid input");
                                        break;
                                }
                            }

                            
                            break;


                        case 2:
                            invalidInputCheck = false;
                            Check_Yard();
                            break;
                        case 3:
                            invalidInputCheck = false;
                            TypeText("You leave the Yard");
                            inYard = false;
                            Cell();
                            break;
                        default:
                            Console.WriteLine("Invalid input");
                            break;
                    }
                }
            }
        }
        public static void Check_Yard()
        {
            int action = 0;
            TypeText("You look around the Yard");
            TypeText("You see a small flower garden, a makeshift casino, and a gym");
            TypeText("What would you like to do?");
            Thread.Sleep(100);
            Console.WriteLine("1:\tWalk over to the garden");
            Thread.Sleep(100);
            Console.WriteLine("2:\tGo to the casino");
            Thread.Sleep(100);
            Console.WriteLine("3:\tCheck out the gym");
            Thread.Sleep(100);
            Console.WriteLine("4:\tGo back");

            Console.WriteLine("5:\tDo laundry job");

            bool invalidInputCheck = true;
            while (invalidInputCheck)
            {
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        invalidInputCheck = false;
                        TypeText("You walk over to the garden and pick some flowers");
                        flowers = true;
                        break;
                    case 2:
                        invalidInputCheck = false;
                        Console.Clear();
                        Casino();
                        break;
                    case 3:
                        invalidInputCheck = false;
                        TypeText("You go to check out the gym and work out");
                        TypeText("You gained 1 strentgh");
                        strength++;
                        break;
                    case 4:
                        invalidInputCheck = false;
                        Console.Clear();
                        Yard();
                        break;
                    case 5:
                        invalidInputCheck = false;
                        Console.Clear();
                        LaundryJob();
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;


                }
            }  
        }

        public static void Gift_Jamal()
        {
            if (flowers)
            {
                TypeText("BIG DOG:\t'Aww flowers, thank you so much. Here's a screwdriver'");
                screwdriver = true;
                flowers = false;
            }
            else
            {
                TypeText("You don't have anything to give Big Dog");
            }

            Yard();
        }


        static DateTime lastLaundryTime = DateTime.MinValue;

        public static void LaundryJob()
        {
            // Check cooldown
            if ((DateTime.Now - lastLaundryTime).TotalMinutes < 10)
            {
                Console.Clear();
                TypeText("The laundry job isn't ready yet.");

                double timeLeft = 2.5 - (DateTime.Now - lastLaundryTime).TotalMinutes;
                TypeText($"Come back in {Math.Ceiling(timeLeft)} minutes.");

                Console.ReadLine();
                Yard();
                return;
            }

            // Set last time used
            lastLaundryTime = DateTime.Now;

            Console.Clear();
            TypeText("You head over to the prison laundry room.");
            Thread.Sleep(500);

            TypeText("A guard hands you a pile of dirty clothes.");
            Thread.Sleep(500);

            TypeText("You spend time washing, folding, and sorting uniforms...");

            // Simulate work
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }

            Console.WriteLine();

            // Use global Random instead (better)
            int earnings = new Random().Next(5, 15);

            money += earnings;

            Console.ForegroundColor = ConsoleColor.Green;
            TypeText($"You earned ${earnings} for your work.");
            Console.ResetColor();

            TypeText($"You now have ${money}");

            Console.WriteLine();
            TypeText("Press Enter to return to the yard...");
            Console.ReadLine();

            Yard();
        }


        // =========================
        // CASINO
        // =========================

        public static void Casino()
        {
            Console.Clear();
            int action = 0;
            int choice = 0;
            int bet = 0;
            bool inCasino = true;
            while (inCasino)
            {

                string[] letterC = {
                    " .----------------. ",
                    "| .--------------. |",
                    "| |     ______   | |",
                    "| |   .' ___  |  | |",
                    "| |  / .'   \\_|  | |",
                    "| |  | |         | |",
                    "| |  \\ `.___.'\\  | |",
                    "| |   `._____.'  | |",
                    "| |              | |",
                    "| '--------------' |",
                    " '----------------' "
                };

                string[] letterA = {
                    " .----------------. ",
                    "| .--------------. |",
                    "| |      __      | |",
                    "| |     /  \\     | |",
                    "| |    / /\\ \\    | |",
                    "| |   / ____ \\   | |",
                    "| | _/ /    \\ \\_ | |",
                    "| ||____|  |____|| |",
                    "| |              | |",
                    "| '--------------' |",
                    " '----------------' "
                };

                string[] letterS = {
                    " .----------------. ",
                    "| .--------------. |",
                    "| |    _______   | |",
                    "| |   /  ___  |  | |",
                    "| |  |  (__ \\_|  | |",
                    "| |   '.___`-.   | |",
                    "| |  |`\\____) |  | |",
                    "| |  |_______.'  | |",
                    "| |              | |",
                    "| '--------------' |",
                    " '----------------' "
                };

                string[] letterI = {
                    " .----------------. ",
                    "| .--------------. |",
                    "| |     _____    | |",
                    "| |    |_   _|   | |",
                    "| |      | |     | |",
                    "| |      | |     | |",
                    "| |     _| |_    | |",
                    "| |    |_____|   | |",
                    "| |              | |",
                    "| '--------------' |",
                    " '----------------' "
                };

                string[] letterN = {
                    " .-----------------. ",
                    "| .--------------. |",
                    "| | ____  _____  | |",
                    "| ||_   \\|_   _| | |",
                    "| |  |   \\ | |   | |",
                    "| |  | |\\ \\| |   | |",
                    "| | _| |_\\   |_  | |",
                    "| ||_____|\\____| | |",
                    "| |              | |",
                    "| '--------------' |",
                    " '----------------' "
                };

                string[] letterO = {
                    " .----------------. ",
                    "| .--------------. |",
                    "| |     ____     | |",
                    "| |   .'    `.   | |",
                    "| |  /  .--.  \\  | |",
                    "| |  | |    | |  | |",
                    "| |  \\  `--'  /  | |",
                    "| |   `.____.'   | |",
                    "| |              | |",
                    "| '--------------' |",
                    " '----------------' "
                };

                ConsoleColor[] colours1 = {
                    ConsoleColor.Red,
                    ConsoleColor.Yellow,
                    ConsoleColor.Green,
                    ConsoleColor.Cyan,
                    ConsoleColor.Blue,
                    ConsoleColor.Magenta
                };

                string[][] letters1 = { letterC, letterA, letterS, letterI, letterN, letterO };

                for (int line = 0; line < 11; line++)
                {
                    for (int letter = 0; letter < 6; letter++)
                    {
                        Console.ForegroundColor = colours1[letter];
                        Console.Write(letters1[letter][line]);
                    }
                    Console.WriteLine();
                }

                Console.ResetColor();
                Console.WriteLine("");
                TypeText("Welcome to the Casino!");
                TypeText("Here you can play roulette or blackjack");
                TypeText("What would you like to do?");
                Thread.Sleep(100);
                Console.WriteLine("1:\tRoulette");
                Thread.Sleep(100);
                Console.WriteLine("2:\tBlackjack");
                Thread.Sleep(100);
                Console.WriteLine("3:\tBack to the Yard");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        bool inRoulette = true;
                        while (inRoulette)
                        {

                            string[] letterR1 = {
                                " .----------------. ",
                                "| .--------------. |",
                                "| |  _______     | |",
                                "| | |_   __ \\    | |",
                                "| |   | |__) |   | |",
                                "| |   |  __ /    | |",
                                "| |  _| |  \\ \\_  | |",
                                "| | |____| |___| | |",
                                "| |              | |",
                                "| '--------------' |",
                                " '----------------' "
                            };

                            string[] letterO1 = {
                                " .----------------. ",
                                "| .--------------. |",
                                "| |     ____     | |",
                                "| |   .'    `.   | |",
                                "| |  /  .--.  \\  | |",
                                "| |  | |    | |  | |",
                                "| |  \\  `--'  /  | |",
                                "| |   `.____.'   | |",
                                "| |              | |",
                                "| '--------------' |",
                                " '----------------' "
                            };

                            string[] letterU = {
                                " .----------------. ",
                                "| .--------------. |",
                                "| | _____  _____ | |",
                                "| ||_   _||_   _|| |",
                                "| |  | |    | |  | |",
                                "| |  | '    ' |  | |",
                                "| |   \\ `--' /   | |",
                                "| |    `.__.'    | |",
                                "| |              | |",
                                "| '--------------' |",
                                " '----------------' "
                            };

                            string[] letterL = {
                                " .----------------. ",
                                "| .--------------. |",
                                "| |   _____      | |",
                                "| |  |_   _|     | |",
                                "| |    | |       | |",
                                "| |    | |   _   | |",
                                "| |   _| |__/ |  | |",
                                "| |  |________|  | |",
                                "| |              | |",
                                "| '--------------' |",
                                " '----------------' "
                            };

                            string[] letterE1 = {
                                " .----------------. ",
                                "| .--------------. |",
                                "| |  _________   | |",
                                "| | |_   ___  |  | |",
                                "| |   | |_  \\_|  | |",
                                "| |   |  _|  _   | |",
                                "| |  _| |___/ |  | |",
                                "| | |_________|  | |",
                                "| |              | |",
                                "| '--------------' |",
                                " '----------------' "
                            };

                            string[] letterT = {
                                " .----------------. ",
                                "| .--------------. |",
                                "| |  _________   | |",
                                "| | |  _   _  |  | |",
                                "| | |_/ | | \\_|  | |",
                                "| |     | |      | |",
                                "| |    _| |_     | |",
                                "| |   |_____|    | |",
                                "| |              | |",
                                "| '--------------' |",
                                " '----------------' "
                            };

                            string[] letterT2 = {
                                " .----------------. ",
                                "| .--------------. |",
                                "| |  _________   | |",
                                "| | |  _   _  |  | |",
                                "| | |_/ | | \\_|  | |",
                                "| |     | |      | |",
                                "| |    _| |_     | |",
                                "| |   |_____|    | |",
                                "| |              | |",
                                "| '--------------' |",
                                " '----------------' "
                            };

                            string[] letterE2 = {
                                " .----------------. ",
                                "| .--------------. |",
                                "| |  _________   | |",
                                "| | |_   ___  |  | |",
                                "| |   | |_  \\_|  | |",
                                "| |   |  _|  _   | |",
                                "| |  _| |___/ |  | |",
                                "| | |_________|  | |",
                                "| |              | |",
                                "| '--------------' |",
                                " '----------------' "
                            };

                            ConsoleColor[] colours2 = {
                                ConsoleColor.Red,
                                ConsoleColor.White,
                                ConsoleColor.Red,
                                ConsoleColor.White,
                                ConsoleColor.Red,
                                ConsoleColor.White,
                                ConsoleColor.Red,
                                ConsoleColor.White
                            };

                            string[][] letters2 = { letterR1, letterO1, letterU, letterL, letterE1, letterT, letterT2, letterE2 };

                            for (int line = 0; line < 11; line++)
                            {
                                for (int letter = 0; letter < 8; letter++)
                                {
                                    Console.ForegroundColor = colours2[letter];
                                    Console.Write(letters2[letter][line]);
                                }
                                Console.WriteLine();
                            }

                            Console.ResetColor();


                            TypeText("How to play roulette:");
                            TypeText("You can choose to bet on either red or black");
                            TypeText("If it lands on the colour you choose, you double your bet");
                            Console.WriteLine("");
                            TypeText("What is your decision?");
                            Thread.Sleep(100);
                            Console.WriteLine("1:\tBet on black");
                            Thread.Sleep(100);
                            Console.WriteLine("2:\tBet on red");
                            Thread.Sleep(100);
                            Console.WriteLine("3:\tGo back");
                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    bool betblack = true;
                                    while (betblack)
                                    {
                                        TypeText($"You have ${money}");
                                        TypeText("How much would you like to bet?");
                                        bet = Convert.ToInt32(Console.ReadLine());
                                        if (bet > money)
                                        {
                                            TypeText("INSUFFICIENT FUNDS");
                                            TypeText("TRY AGAIN");
                                            betblack = false;
                                        }
                                        else if (bet <= 0)
                                        {
                                            TypeText("You can't be 0 or less");
                                            betblack = false;
                                        }
                                        else
                                        {
                                            TypeText($"You bet ${bet} on black");
                                            Random rand = new Random();
                                            int land = rand.Next(0, 2);
                                            switch (land)
                                            {
                                                case 0:
                                                    TypeText($"YOU WON ${bet + bet}");
                                                    money = money + bet;
                                                    TypeText($"You now have ${money}");
                                                    betblack = false;
                                                    break;

                                                case 1:
                                                    TypeText("You lost");
                                                    money = money - bet;
                                                    TypeText($"You now have ${money}");
                                                    betblack = false;
                                                    break;
                                            }
                                        }

                                    }
                                    break;


                                case 2:
                                    bool betred = true;
                                    while (betred)
                                    {
                                        TypeText($"You have ${money}");
                                        TypeText("How much would you like to bet?");
                                        bet = Convert.ToInt32(Console.ReadLine());
                                        if (bet > money)
                                        {
                                            TypeText("INSUFFICIENT FUNDS");
                                            TypeText("TRY AGAIN");
                                            betred = false;
                                        }
                                        else if (bet <= 0)
                                        {
                                            TypeText("You can't be 0 or less");
                                            betred = false;
                                        }
                                        else
                                        {
                                            TypeText($"You bet ${bet} on red");
                                            Random rand = new Random();
                                            int land = rand.Next(0, 2);
                                            switch (land)
                                            {
                                                case 0:
                                                    TypeText($"YOU WON ${bet + bet}");
                                                    money = money + bet;
                                                    TypeText($"You now have ${money}");
                                                    betred = false;
                                                    break;

                                                case 1:
                                                    TypeText("You lost");
                                                    money = money - bet;
                                                    TypeText($"You now have ${money}");
                                                    betred = false;
                                                    break;
                                            }
                                        }

                                    }
                                    break;

                                case 3:
                                    inRoulette = false;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        bool inBlackjack = true;
                        while (inBlackjack)
                        {
                            string[] letterB = {
                                ".------.",
                                "|B.--. |",
                                "| :(): |",
                                "| ()() |",
                                "| '--'B|",
                                "`------'"
                            };

                            string[] letterL = {
                                ".------.",
                                "|L.--. |",
                                "| :/\\: |",
                                "| (__) |",
                                "| '--'L|",
                                "`------'"
                            };

                            string[] letterA1 = {
                                ".------.",
                                "|A.--. |",
                                "| (\\/) |",
                                "| :\\/: |",
                                "| '--'A|",
                                "`------'"
                            };

                            string[] letterC1 = {
                                ".------.",
                                "|C.--. |",
                                "| :/\\: |",
                                "| :\\/: |",
                                "| '--'C|",
                                "`------'"
                            };

                            string[] letterK1 = {
                                ".------.",
                                "|K.--. |",
                                "| :/\\: |",
                                "| :\\/: |",
                                "| '--'K|",
                                "`------'"
                            };

                            string[] letterJ = {
                                ".------.",
                                "|J.--. |",
                                "| :(): |",
                                "| ()() |",
                                "| '--'J|",
                                "`------'"
                            };

                            string[] letterA2 = {
                                ".------.",
                                "|A.--. |",
                                "| (\\/) |",
                                "| :\\/: |",
                                "| '--'A|",
                                "`------'"
                            };

                            string[] letterC2 = {
                                ".------.",
                                "|C.--. |",
                                "| :/\\: |",
                                "| :\\/: |",
                                "| '--'C|",
                                "`------'"
                            };

                            string[] letterK2 = {
                                ".------.",
                                "|K.--. |",
                                "| :/\\: |",
                                "| :\\/: |",
                                "| '--'K|",
                                "`------'"
                            };


                            ConsoleColor[] colors = {
                                ConsoleColor.White,
                                ConsoleColor.Red,
                                ConsoleColor.White,
                                ConsoleColor.Red,
                                ConsoleColor.White,
                                ConsoleColor.Red,
                                ConsoleColor.White,
                                ConsoleColor.Red,
                                ConsoleColor.White
                            };

                            string[][] letters = { letterB, letterL, letterA1, letterC1, letterK1, letterJ, letterA2, letterC2, letterK2 };

                            for (int line = 0; line < 6; line++)
                            {
                                for (int letter = 0; letter < 9; letter++)
                                {
                                    Console.ForegroundColor = colors[letter];
                                    Console.Write(letters[letter][line]);
                                }
                                Console.WriteLine();
                            }

                            Console.ResetColor();
                            TypeText("");
                            TypeText("How to play blackjack:");
                            TypeText("Your goal is to get as close to 21 as possible");
                            TypeText("If you go over 21, you bust and lose");
                            TypeText("Face cards are worth 10");
                            TypeText("Aces are worth 1 or 11");
                            TypeText("The dealer must draw until they reach 17");
                            TypeText("");
                            TypeText("What would you like to do?");
                            Thread.Sleep(100);
                            Console.WriteLine("1:\tPlay Blackjack");
                            Thread.Sleep(100);
                            Console.WriteLine("2:\tGo Back");
                            int blackjackmenu = Convert.ToInt32(Console.ReadLine());
                            switch (blackjackmenu)
                            {
                                case 1:
                                    Random rand = new Random();
                                    int playertotal = 0;
                                    int dealertotal = 0;

                                    int playeraces = 0;
                                    int dealeraces = 0;

                                    int betblackjack = 0;

                                    bool playerleft = false;

                                    bool betting = true;
                                    while (betting)
                                    {

                                        TypeText($"You have ${money}");
                                        TypeText("How much would you like to bet?");
                                        betblackjack = Convert.ToInt32(Console.ReadLine());
                                        if (betblackjack > money || betblackjack <= 0)
                                        {
                                            TypeText("Invalid bet");
                                            TypeText("Try again");

                                        }
                                        else
                                        {
                                            betting = false;
                                        }
                                    }

                                    int playercard1 = rand.Next(1, 14);
                                    int playercard2 = rand.Next(1, 14);

                                    int dealercard1 = rand.Next(1, 14);
                                    int dealercard2 = rand.Next(1, 14);

                                    //Player Card 1
                                    if (playercard1 > 10)
                                    {
                                        Console.WriteLine("");
                                        TypeText("You were dealt: Face Card");
                                        playercard1 = 10;
                                    }
                                    else if (playercard1 == 1)
                                    {
                                        playercard1 = 11;
                                        Console.WriteLine("");
                                        TypeText("You were dealt: Ace");
                                        playeraces++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        TypeText($"You were dealt: {playercard1}");
                                    }

                                    //Player Card 2
                                    if (playercard2 > 10)
                                    {
                                        Console.WriteLine("");
                                        TypeText("You were dealt: Face Card");
                                        playercard2 = 10;
                                    }
                                    else if (playercard2 == 1)
                                    {
                                        playercard2 = 11;
                                        Console.WriteLine("");
                                        TypeText("You were dealt: Ace");
                                        playeraces++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        TypeText($"You were dealt: {playercard2}");
                                    }

                                    //Dealer Card 1
                                    if (dealercard1 > 10)
                                    {
                                        Console.WriteLine("");
                                        TypeText("Dealer was dealt: Face Card");
                                        dealercard1 = 10;
                                    }
                                    else if (dealercard1 == 1)
                                    {
                                        dealercard1 = 11;
                                        Console.WriteLine("");
                                        TypeText("Dealer was dealt: Ace");
                                        dealeraces++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        TypeText($"Dealer was dealt: {dealercard1}");
                                    }

                                    //Dealer Card 2
                                    if (dealercard2 > 10)
                                    {
                                        Console.WriteLine("");
                                        TypeText("Dealer was dealt: Hidden Card");
                                        dealercard2 = 10;
                                    }
                                    else if (dealercard2 == 1)
                                    {
                                        dealercard2 = 11;
                                        Console.WriteLine("");
                                        TypeText("Dealer was dealt: Hidden Card");
                                        dealeraces++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        TypeText("Dealer was dealt: Hidden Card");
                                    }

                                    playertotal = playercard1 + playercard2;
                                    dealertotal = dealercard1 + dealercard2;

                                    while (playertotal > 21 && playeraces > 0)
                                    {
                                        playertotal -= 10;
                                        playeraces--;
                                    }
                                    while (dealertotal > 21 && dealeraces > 0)
                                    {
                                        dealertotal -= 10;
                                        dealeraces--;
                                    }

                                    Console.WriteLine("");
                                    TypeText($"Dealer visible total: {dealercard1}");
                                    TypeText($"Your total: {playertotal}");
                                    Console.WriteLine("");

                                    bool blackjack = false;
                                    bool playerturn = true;
                                    while (playerturn)
                                    {


                                        if (playertotal == 21)
                                        {
                                            TypeText("BLACKJACK!");
                                            int blackjackpayout = (int)(betblackjack * 1.5);
                                            money += blackjackpayout;
                                            TypeText($"You win ${blackjackpayout}");
                                            TypeText($"You now have ${money}");
                                            playerturn = false;
                                            blackjack = true;
                                            break;
                                        }
                                        Thread.Sleep(100);
                                        Console.WriteLine("1:\tHit");
                                        Thread.Sleep(100);
                                        Console.WriteLine("2:\tStand");
                                        Thread.Sleep(100);
                                        Console.WriteLine("3:\tLeave BlackJack");
                                        int blackjackaction = Convert.ToInt32(Console.ReadLine());

                                        switch (blackjackaction)
                                        {
                                            case 1:
                                                int newcard = rand.Next(1, 14);

                                                if (newcard > 10)
                                                {
                                                    Console.WriteLine("");
                                                    TypeText("You were dealt: Face Card");
                                                    newcard = 10;
                                                }
                                                else if (newcard == 1)
                                                {
                                                    newcard = 11;
                                                    Console.WriteLine("");
                                                    TypeText("You were dealt: Ace");
                                                    playeraces++;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("");
                                                    TypeText($"You were dealt: {newcard}");
                                                }

                                                playertotal += newcard;

                                                while (playertotal > 21 && playeraces > 0)
                                                {
                                                    playertotal -= 10;
                                                    playeraces--;
                                                }
                                                TypeText($"Your total is now {playertotal}");
                                                if (playertotal > 21)
                                                {
                                                    TypeText("BUST! you went over 21");
                                                    money -= betblackjack;
                                                    TypeText($"You now have ${money}");
                                                    playerturn = false;
                                                }

                                                break;

                                            case 2:
                                                TypeText("You stand");
                                                playerturn = false;
                                                break;

                                            case 3:
                                                TypeText("You left the table and lost your bet");
                                                money -= betblackjack;
                                                playerturn = false;
                                                playerleft = true;
                                                break;

                                        }
                                    }
                                    if (playertotal <= 21 && !playerleft && !blackjack)
                                    {
                                        Console.WriteLine("");
                                        TypeText($"Dealer reveals: {dealercard2}");
                                        TypeText("The Dealer's turn...");

                                        while (dealertotal < 17)
                                        {
                                            int newdealercard = rand.Next(1, 14);

                                            if (newdealercard > 10)
                                            {
                                                Console.WriteLine("");
                                                TypeText("Dealer was dealt: Face Card");
                                                newdealercard = 10;
                                            }
                                            else if (newdealercard == 1)
                                            {
                                                newdealercard = 11;
                                                Console.WriteLine("");
                                                TypeText("Dealer was dealt: Ace");
                                                dealeraces++;
                                            }
                                            else
                                            {
                                                Console.WriteLine("");
                                                TypeText($"Dealer was dealt: {newdealercard}");
                                            }
                                            dealertotal += newdealercard;

                                            while (dealertotal > 21 && dealeraces > 0)
                                            {
                                                dealertotal -= 10;
                                                dealeraces--;
                                            }
                                        }
                                        Console.WriteLine("");
                                        TypeText($"Dealer's total: {dealertotal}");
                                        TypeText($"Your total: {playertotal}");
                                        Console.WriteLine("");

                                        if (dealertotal > 21)
                                        {
                                            TypeText("Dealer busted");
                                            TypeText("You win");
                                            money += betblackjack;
                                        }
                                        else if (dealertotal > playertotal)
                                        {
                                            TypeText("Dealer wins");
                                            money -= betblackjack;
                                        }
                                        else if (dealertotal < playertotal)
                                        {
                                            TypeText("You win");
                                            money += betblackjack;
                                        }
                                        else
                                        {
                                            TypeText("It's a draw");
                                            TypeText("You get your money back");
                                        }
                                        TypeText($"You now have ${money}");
                                    }
                                    Console.WriteLine("");
                                    TypeText("Press 'Enter' to continue");
                                    Console.ReadLine();
                                    break;


                                case 2:
                                    inBlackjack = false;
                                    break;
                            }



                        }
                        break;

                    case 3:
                        inCasino = false;
                        Console.Clear();
                        Yard();
                        break;
                }
            }

        }

        // =========================
        // CAFETERIA
        // =========================
        static bool pudding = false;

        public static void Cafeteria()
        {
            Console.Clear();
            int action_1 = 0;
            int action_2 = 0;
            TypeText("You enter the Cafeteria and look around.");
            Thread.Sleep(500);
            TypeText("You see Crack Head Joe sitting at a table.");
            Thread.Sleep(500);
            TypeText("You also see the chow line.");
            Thread.Sleep(500);
            TypeText("What would you like to do?");
            Thread.Sleep(100);
            Console.WriteLine("1:\tTalk to Crack Head Joe.");
            Thread.Sleep(100);
            Console.WriteLine("2:\tEnter the Chow Line.");
            Thread.Sleep(100);
            Console.WriteLine("3:\tExit Cafeteria.");

            action_1 = Convert.ToInt32(Console.ReadLine());

            switch (action_1)
            {
                case 1:
                    TypeText("You walk up to Crack Head Joe.");
                    Thread.Sleep(500);
                    TypeText("You see him constantly scratching his skin");
                    Thread.Sleep(500);
                    TypeText("'Hmmm... I could really use some pudding right now' he mutters.");
                    Thread.Sleep(500);
                    TypeText("You also see that he has a cross around his neck");
                    if (pudding != true)
                    {
                        TypeText("What would you like to do?");
                        Thread.Sleep(100);
                        Console.WriteLine("1:\tGo Back.");
                        Thread.Sleep(100);
                        Console.WriteLine("3.\tBuy Cross Pendent $100");
                        action_2 = Convert.ToInt32(Console.ReadLine());
                        switch (action_2)
                        {
                            case 1:
                                Cafeteria();
                                break;
                            case 3:
                                if (money >= 100)
                                {
                                    money = money - 100;
                                    TypeText("You give Crack Head Joe $100, he takes off the cross and hands it to you");
                                    Thread.Sleep(750);
                                    TypeText("You now have a cross");
                                    cross = true;
                                }
                                else
                                {
                                    TypeText("You don't have enough money");
                                }
                                Cafeteria();
                                break;
                        }

                    }
                    else
                    {
                        TypeText("What would you like to do?");
                        Thread.Sleep(100);
                        Console.WriteLine("1:\tGo Back.");
                        Thread.Sleep(100);
                        Console.WriteLine("2:\tGive Crack Head Joe Pudding.");
                        Thread.Sleep(100);
                        Console.WriteLine("3.\tBuy Cross Pendent $100");
                        action_2 = Convert.ToInt32(Console.ReadLine());
                        switch (action_2)
                        {
                            case 1:
                                Cafeteria();
                                break;
                            case 2:
                                if (shiv != true)
                                {
                                    TypeText("Thanks kid heres a shiv");
                                    shiv = true;
                                }
                                else
                                {
                                    TypeText("Bro You already tried that go away.");
                                }

                                Cafeteria();
                                break;
                            case 3:
                                if (money >= 100)
                                {
                                    money = money - 100;
                                    TypeText("You give Crack Head Joe $100, he takes off the cross and hands it to you");
                                    Thread.Sleep(750);
                                    TypeText("You now have a cross");
                                    cross = true;
                                }
                                else
                                {
                                    TypeText("You don't have enough money");
                                }
                                Cafeteria();
                                break;
                        }
                    }
                    break;

                case 2:
                    TypeText("You enter the chow line. Today they are serving pudding. ONE PER INMATE.");
                    Thread.Sleep(500);
                    TypeText("What would you like to do?");
                    Thread.Sleep(100);
                    Console.WriteLine("1:\tGo Back.");
                    Thread.Sleep(100);
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
                                TypeText("You have recieved pudding!");
                                pudding = true;

                            }
                            else
                            {
                                TypeText("You've already got your pudding!");
                            }
                            Cafeteria();
                            break;


                    }
                    break;
                case 3:
                    Console.Clear();
                    Cell();
                    break;
            }
        }
        public static void Roof()
        {
            Console.Clear();
            int cellchoice = 0;
            TypeText("You find yourself ontop of the prison roof. There seem to be 2 possible ways to go");
            Thread.Sleep(100);
            Console.WriteLine("1: Jump to the next building");
            Thread.Sleep(100);
            Console.WriteLine("2: Move to the other side of the roof");
            Thread.Sleep(100);
            Console.WriteLine("3: Go back to cell");
            cellchoice = Convert.ToInt32(Console.ReadLine());
            switch (cellchoice)
            {
                case 1:
                    Console.Clear();
                    Jump();
                    break;

                case 2:
                    Console.Clear();
                    Move();
                    break;

                case 3:
                    Console.Clear();
                    Cell();
                    break;
            }
        }
        public static void Jump()
        {
            Console.Clear();
            TypeText("You start running and get ready to jump to the other building but your foot slips and you fall, spliting your head open");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  ________                        ________                     \r\n /  _____/_____    _____   ____   \\_____  \\___  __ ___________ \r\n/   \\  ___\\__  \\  /     \\_/ __ \\   /   |   \\  \\/ // __ \\_  __ \\\r\n\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  /    |    \\   /\\  ___/|  | \\/\r\n \\______  (____  /__|_|  /\\___  > \\_______  /\\_/  \\___  >__|   \r\n        \\/     \\/      \\/     \\/          \\/          \\/       ");
            Console.ResetColor();
            Thread.Sleep(100);
            Console.WriteLine("1: Continue from last checkpoint.");
            Thread.Sleep(100);
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
                    cross = false;
                    MainMenu();
                    break;
            }
        }
        public static void Move()
        {
            Console.Clear();
            int cellchoice;
            TypeText("You move to the other side of the roof and find yourself near the surrounding fence.");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("There seem to be 2 possible ways you can make it out of this");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("There's a space in between the barbed wire that you could possibly crawl through, but it seems risky");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("There's also a guard tower that you could possibly climb up to and escape through there, but there may be someone inside");
            Thread.Sleep(100);
            Console.WriteLine("1. Climb the guard tower");
            Thread.Sleep(100);
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
            Console.Clear();
            int choice;
            TypeText("You begin to crawl through the barbed fence.");
            Thread.Sleep(100);
            Console.WriteLine("1. Crawl carefully");
            Thread.Sleep(100);
            Console.WriteLine("2. Rush through");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    TypeText("You slowly crawl through the barbed wire.");
                    if (strength > 7)
                    {
                        TypeText("Your strength was high enough to make it through");
                        Win();
                    }
                    else
                    {
                        TypeText("You were not strong enough to make it through.");
                        Death();
                        Roof();
                    }
                    break;
                case 2:
                    TypeText("You rush through the barbed wire, cutting yourself. You bleed out.");
                    Death();
                    Roof();
                    break;
            }
        }
        public static void Tower()
        {
            Console.Clear ();
            int choice;
            TypeText("You take a step back before leaping onto the side of the guard tower");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("Luckily, You manage to grab onto a fixed light on the side of the tower");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("You lift yourself over the railing and make it into the tower");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("Unfortunetly, a guard happened to be inside the tower as you made it inside");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("The guard aims their gun at you and orders you to comply ");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("You can see a way to escape the prison on just the other side of the tower, but you need to get past the guard");
            Thread.Sleep(100);
            Console.WriteLine("1. Reason with the guard");
            Thread.Sleep(100);
            Console.WriteLine("2. Fight the guard");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Reason();
                    break;
                case 2:
                    Console.Clear();
                    TowerFight();
                    break;
            }
        }
        public static void Reason()
        {
            TypeText("Before you have the chance to say anything, the guard fires his gun, shooting you straight in the head");
            Thread.Sleep(1500);
            Death();
            Roof();
        }
        public static void TowerFight()
        {
            Console.Clear();
            if (shiv = true)
            {
                TypeText("Without giving the guard a chance, you dive into the guard, pressing the shiv deep into their stomach");
                Console.WriteLine();
                Thread.Sleep(1000);
                TypeText("The guard collapses on the ground, clutching their chest in pain");
                Console.WriteLine();
                Thread.Sleep(1000);
                TypeText("You rush past the guard and make it to the other side of the tower");
                Console.WriteLine();
                Thread.Sleep(1500);
                TowerEscape();
            }
            else
            {
                TypeText("You dive at the guard, pushing him against the wall");
                Console.WriteLine();
                Thread.Sleep(1000);
                TypeText("You try to take a swing at the guard, but they end up firing a round into the side of your waist");
                Console.WriteLine();
                Thread.Sleep(1000);
                TypeText("You collapse to the ground, as you hold your wound tight");
                Console.WriteLine();
                Thread.Sleep(1500);
                Console.Clear();
                Death();
                Roof();
            }
        }
        public static void TowerEscape()
        {
            TypeText("You see a pipe near the front wall of the gate that seems to lead you to the outside of the prison");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("You leap over the railing and just manage to get a grip of the pipe as it starts shaking from impact");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("you slide down the pipe carefully and manage to make it to the ground safely");
            Console.WriteLine();
            Thread.Sleep(1000);
            TypeText("Without a second later, you start sprinting away from the prison, leading to your freedom");
            Console.WriteLine();
            Thread.Sleep(2000);
            Win();
        }
        public static void Showers()
        {
            Console.Clear();
            int cellchoice;
            TypeText("The showers are all empty, the only thing you see is a bar of soap on the floor");
            Thread.Sleep(100);
            if (soap != true)
            {
                Console.WriteLine("1. Pick up Soap");
            }
            Thread.Sleep(100);
            Console.WriteLine("2. Take a shower");
            Thread.Sleep(100);
            Console.WriteLine("3. Leave showers");
            cellchoice = Convert.ToInt32(Console.ReadLine());
            if (soap != true)
            {
                if (cellchoice == 1)
                {
                    TypeText("You pick up the soap");
                    soap = true;
                    Showers();
                }
            }
            if (cellchoice == 2)
            {
                TypeText("You take a shower and feel clean.");
                Showers();
            }
            else if (cellchoice == 3)
            {
                Cell();
            }

        }

        public static void Death()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  ________                        ________                     \r\n /  _____/_____    _____   ____   \\_____  \\___  __ ___________ \r\n/   \\  ___\\__  \\  /     \\_/ __ \\   /   |   \\  \\/ // __ \\_  __ \\\r\n\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  /    |    \\   /\\  ___/|  | \\/\r\n \\______  (____  /__|_|  /\\___  > \\_______  /\\_/  \\___  >__|   \r\n        \\/     \\/      \\/     \\/          \\/          \\/       ");
            Console.ResetColor();

            Thread.Sleep(100);
            Console.WriteLine("1: Continue from last checkpoint.");
            Thread.Sleep(100);
            Console.WriteLine("2: Exit to menu.");
            int action = Convert.ToInt32(Console.ReadLine());
            bool exit = true;
            switch (action)
            {
                case 1:
                    break;

                case 2:
                    while (exit)
                    {
                        Console.WriteLine();
                        Console.WriteLine("This proccess will reset your game, would you like to continue?");
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. No");
                        int action2 = Convert.ToInt32(Console.ReadLine());


                        switch (action2)
                        {
                            case 1:
                                flowers = false;
                                screwdriver = false;
                                shiv = false;
                                soap = false;
                                strength = 0;
                                money = 10;
                                inmate = true;
                                pudding = false;
                                cross = false;

                                MainMenu();
                                break;
                            case 2:
                                Death();
                                break;
                            default:
                                Console.WriteLine("Invalid input");
                                Console.ReadLine();
                                Death();
                                break;
                        }
                   
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    Death();
                    break;
            }
        }

        public static void Win()
        {
            Thread.Sleep(1000);
            TypeText("You have escaped!");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\r\n _____      _____        _____     ____   ____         _____            ____  _____   ______   \r\n|\\    \\    /    /|  ____|\\    \\   |    | |    |       |\\    \\   _____  |    ||\\    \\ |\\     \\  \r\n| \\    \\  /    / | /     /\\    \\  |    | |    |       | |    | /    /| |    | \\\\    \\| \\     \\ \r\n|  \\____\\/    /  //     /  \\    \\ |    | |    |       \\/     / |    || |    |  \\|    \\  \\     |\r\n \\ |    /    /  /|     |    |    ||    | |    |       /     /_  \\   \\/ |    |   |     \\  |    |\r\n  \\|___/    /  / |     |    |    ||    | |    |      |     // \\  \\   \\ |    |   |      \\ |    |\r\n      /    /  /  |\\     \\  /    /||    | |    |      |    |/   \\ |    ||    |   |    |\\ \\|    |\r\n     /____/  /   | \\_____\\/____/ ||\\___\\_|____|      |\\ ___/\\   \\|   /||____|   |____||\\_____/|\r\n    |`    | /     \\ |    ||    | /| |    |    |      | |   | \\______/ ||    |   |    |/ \\|   ||\r\n    |_____|/       \\|____||____|/  \\|____|____|       \\|___|/\\ |    | ||____|   |____|   |___|/\r\n       )/             \\(    )/        \\(   )/            \\(   \\|____|/   \\(       \\(       )/  \r\n       '               '    '          '   '              '      )/       '        '       '   \r\n                                                                 '                             ");
            Console.ResetColor();
            Thread.Sleep(100);
            Console.WriteLine("1: Exit to menu.");
            Thread.Sleep(100);
            Console.WriteLine("2: Exit to desktop.");
            int action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    flowers = false;
                    screwdriver = false;
                    shiv = false;
                    soap = false;
                    strength = 0;
                    money = 10;
                    inmate = true;
                    pudding = false;
                    cross = false;

                    MainMenu();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
