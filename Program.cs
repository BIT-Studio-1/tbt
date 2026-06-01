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
              "░░███████████            ░███                                ░███████████                              ░█████     ",
              " ░░███░░░░░███           ░░░                                 ░░███░░░░░███                             ░░███      ",
              "  ░███    ░███░████████ ░████  ░█████  ░██████ ░████████      ░███    ░███░███████   ░██████  ░██████   ░███░█████",
              "  ░██████████ ░░███░░███░░███  ███░░   ███░░███░░███░░███     ░██████████ ░░███░░███ ███░░███ ░░░░░███  ░███░░███ ",
              "  ░███░░░░░░   ░███ ░░░  ░███ ░░█████ ░███ ░███ ░███ ░███     ░███░░░░░███ ░███ ░░░ ░███████   ███████  ░██████░  ",
              "  ░███         ░███      ░███  ░░░░███░███ ░███ ░███ ░███     ░███    ░███ ░███     ░███░░░   ███░░███  ░███░░███ ",
              "  █████        █████     █████ ██████ ░░██████  ████ █████    ███████████  █████    ░░██████ ░░████████ ████ █████",
              " ░░░░░        ░░░░░     ░░░░░ ░░░░░░   ░░░░░░  ░░░░ ░░░░░    ░░░░░░░░░░░  ░░░░░      ░░░░░░   ░░░░░░░░ ░░░░ ░░░░░ "
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
                                                                                                                 
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
                TypeText("1. Start Game");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                TypeText("2. Exit Game");
                Console.ResetColor();

                Console.WriteLine();
                TypeText("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        TypeText("Starting Game...");
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        TypeText("Loading ");

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
            Console.WriteLine();
            TypeText("The Judge has committed you to 25 life sentences due to your severe crime");
            Console.WriteLine();
            TypeText("You were sent to the most hardcore prison within the area");

            Thread.Sleep(100);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            TypeText("      -------------Outcast Juvenile Holding Center-------------");
            Console.ResetColor();

            Console.WriteLine("");
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
                TypeText("What would you like to do");

                Console.ForegroundColor = ConsoleColor.Gray;
                TypeText("1. Check cell");

                Console.ForegroundColor = ConsoleColor.Green;
                TypeText("2. Go to yard");

                Console.ForegroundColor = ConsoleColor.Yellow;
                TypeText("3. Go to cafeteria");

                Console.ForegroundColor = ConsoleColor.Cyan;
                TypeText("4. Go to showers");

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
            TypeText("You look around your cell");
            TypeText("It contains a bed, desk, toilet, and a window.");
            TypeText("What do you want to do");
            TypeText("1. Look at bed");
            TypeText("2. Look at toilet");
            TypeText("3. Look inside desk");
            TypeText("4. Look through window");
            TypeText("5. Exit");
            if (cross = true)
            {
                TypeText("6. Pray");
            }
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
                case 6:
                    if (cross = true)
                    {
                        Pray();
                    }
                    break;

            }
        }
        
        public static void Pray()
        {
            TypeText("You put on the pendent and kneel on the ground");
            TypeText("You close your eyes on starting praying a way out of this horrible prison");
            Thread.Sleep(1000);
            TypeText("..............");
            Thread.Sleep(1000);
            TypeText("..............");
            Thread.Sleep(1000);
            TypeText("..............");
            Thread.Sleep(2000);
            TypeText("Suddenly, you feel a huge quake surrounding your cell");
            TypeText("You see the roof of your cell collapse, a bright light errupts from it");
            TypeText("You squint your eyes in reaction, but in the bright light, you see something you would have never expected before...");
            Thread.Sleep(1000);
            TypeText("It's Jesus");
            Thread.Sleep(1000);
            TypeText("He extends his hand out to you, responding to your dire need");
            TypeText("You take his hand, as he lifts you into the sky");
            TypeText("In that moment, you realise that Jesus is helping you escape prison.");
            Thread.Sleep(500);
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
            if (flowers)
            {
                TypeText("\tFlowers");
                Console.WriteLine("");
            }
            if (shiv)
            {
                TypeText("\tShiv");
                Console.WriteLine("");
            }
            if (screwdriver)
            {
                TypeText("\tScrewdriver");
                Console.WriteLine("");
            }
            if (cross)
            {
                TypeText("\tCross Pendent");
                Console.WriteLine("");
            }
            if (soap)
            {
                TypeText("\tSoap");
                Console.WriteLine("");
            }
            TypeText($"\t${money}");
            Console.WriteLine("");
            TypeText($"\tStrentgh = {strength}");
            Console.WriteLine("");
            Console.WriteLine("");
            TypeText("Press 'Enter' to exit");
            Console.ReadLine();
            Look();
        }
        public static void toilet()
        {
            int cellchoice, cellchoice2;
            TypeText("There's a toilet in the corner of the cell, it seems to be connected by some screws");
            TypeText("1. Remove toilet from wall (Screwdriver needed)");
            TypeText("2. Leave toilet");
            cellchoice = Convert.ToInt32(Console.ReadLine());
            switch (cellchoice)
            {
                case 1:
                    if (screwdriver == true)
                    {
                        TypeText("You unscrew the screws from the toilet.");
                        TypeText("You remove the toilet from the wall to see a hole that leads to behind the cell.");
                        TypeText("Inside, you see a ladder that seems to lead to the roof.");
                        TypeText("1. Go to roof");
                        TypeText("2. Return to cell");
                        cellchoice2 = Convert.ToInt32(Console.ReadLine());
                        switch (cellchoice2)
                        {
                            case 1:
                                Roof();
                                break;
                            case 2:
                                TypeText("You go back to your cell and screw the toilet back to the wall");
                                Look();
                                break;
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

                TypeText("You enter the Yard");
                TypeText("You look around and see another inmate");
                TypeText("What would you like to do?");
                if (inmate == true)
                {
                    TypeText("1:\tConfront the inmate");
                }

                TypeText("2:\tCheck the Yard");
                TypeText("3:\tExit the Yard");

                action_1 = Convert.ToInt32(Console.ReadLine());

                switch (action_1)
                {
                    case 1:
                        TypeText("You approach the inmate");
                        TypeText("What would you like to do?");
                        TypeText("1:\tFight the inmate");
                        TypeText("2:\tTalk to the inmate");
                        TypeText("3:\tGive the inmate a gift");
                        TypeText("4:\tGo back");

                        action_2 = Convert.ToInt32(Console.ReadLine());

                        switch (action_2)
                        {
                            case 1:
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
                                TypeText("INMATE:\t'Hmmm, I could really use some flowers right now'");
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
                        TypeText("You leave the Yard");
                        inYard = false;
                        Cell();
                        break;

                }
            }
        }
        public static void Check_Yard()
        {
            int action = 0;
            TypeText("You look around the Yard");
            TypeText("You see a small flower garden, a makeshift casino, and a gym");
            TypeText("What would you like to do?");
            TypeText("1:\tWalk over to the garden");
            TypeText("2:\tGo to the casino");
            TypeText("3:\tCheck out the gym");
            TypeText("4:\tGo back");
            action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    TypeText("You walk over to the garden and pick some flowers");
                    flowers = true;
                    break;
                case 2:
                    Casino();
                    break;
                case 3:
                    TypeText("You go to check out the gym and work out");
                    TypeText("You gained 1 strentgh");
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
        // =========================
        // CASINO
        // =========================

        public static void Casino()
        {
            int action = 0;
            int choice = 0;
            int bet = 0;
            bool inCasino = true;
            while (inCasino)
            {
                TypeText("\t======================================");
                TypeText("\t              CASINO");
                TypeText("\t======================================");
                Console.WriteLine("");
                Console.WriteLine("");
                TypeText("Welcome to the Casino!");
                TypeText("Here you can play roulette or blackjack");
                TypeText("What would you like to do?");
                TypeText("1:\tRoulette");
                TypeText("2:\tBlackjack");
                TypeText("3:\tBack to the Yard");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        bool inRoulette = true;
                        while (inRoulette)
                        {
                            Console.WriteLine("");
                            TypeText("\t======================================");
                            TypeText("\t              ROULETTE");
                            TypeText("\t======================================");
                            TypeText("");
                            TypeText("");
                            TypeText("How to play roulette:");
                            TypeText("You can choose to bet on either red or black");
                            TypeText("If it lands on the colour you choose, you double your bet");
                            Console.WriteLine("");
                            TypeText("What is your decision?");
                            TypeText("1:\tBet on black");
                            TypeText("2:\tBet on red");
                            TypeText("3:\tGo back");
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
                            TypeText("\t======================================");
                            TypeText("\t             BLACKJACK");
                            TypeText("\t======================================");
                            TypeText("");
                            TypeText("");
                            TypeText("How to play blackjack:");
                            TypeText("Your goal is to get as close to 21 as possible");
                            TypeText("If you go over 21, you bust and lose");
                            TypeText("Face cards are worth 10");
                            TypeText("Aces are worth 1 or 11");
                            TypeText("The dealer must draw until they reach 17");
                            TypeText("");
                            TypeText("What would you like to do?");
                            TypeText("1:\tPlay Blackjack");
                            TypeText("2:\tGo Back");
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

                                        TypeText("1:\tHit");
                                        TypeText("2:\tStand");
                                        TypeText("3:\tLeave BlackJack");
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
                                    if (playertotal <=21 && !playerleft && !blackjack)
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
            int action_1 = 0;
            int action_2 = 0;
            TypeText("You enter the Cafeteria and look around.");
            TypeText("You see Crack Head Joe sitting at a table.");
            TypeText("You also see the chow line.");
            TypeText("What would you like to do?");
            TypeText("1:\tTalk to Crack Head Joe.");
            TypeText("2:\tEnter the Chow Line.");
            TypeText("3:\tExit Cafeteria.");

            action_1 = Convert.ToInt32(Console.ReadLine());

            switch (action_1)
            {
                case 1:
                    TypeText("You walk up to Crack Head Joe.");
                    TypeText("You see him constantly scratching his skin");
                    TypeText("'Hmmm... I could really use some pudding right now' he mutters.");
                    TypeText("You also see that he has a cross around his neck");
                    if (pudding != true)
                    {
                        TypeText("What would you like to do?");
                        TypeText("1:\tGo Back.");
                        TypeText("3.\tBuy Cross Pendent $100");
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
                                    TypeText("You now have a cross");
                                }
                                else
                                {
                                    TypeText("You don't have enough money");
                                }
                                break;
                        }

                    }
                    else
                    {
                        TypeText("What would you like to do?");
                        TypeText("1:\tGo Back.");
                        TypeText("2:\tGive Crack Head Joe Pudding.");
                        TypeText("3.\tBuy Cross Pendent $100");
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
                                    TypeText("You now have a cross");
                                }
                                else
                                {
                                    TypeText("You don't have enough money");
                                }
                                    break;
                        }
                    }
                    break;

                case 2:
                    TypeText("You enter the chow line. Today they are serving pudding. ONE PER INMATE.");
                    TypeText("What would you like to do?");
                    TypeText("1:\tGo Back.");
                    TypeText("2:\tGet some pudding.");
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
                    Cell();
                    break;
            }
        }
        public static void Roof()
        {
            int cellchoice = 0;
            TypeText("You find yourself ontop of the prison roof. There seem to be 2 possible ways to go");
            TypeText("1: Jump to the next building");
            TypeText("2: Move to the other side of the roof");
            TypeText("3: Go back to cell");
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
            TypeText("You start running and get ready to jump to the other building but your foot slips and you fall, spliting your head open");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            TypeText("  ________                        ________                     \r\n /  _____/_____    _____   ____   \\_____  \\___  __ ___________ \r\n/   \\  ___\\__  \\  /     \\_/ __ \\   /   |   \\  \\/ // __ \\_  __ \\\r\n\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  /    |    \\   /\\  ___/|  | \\/\r\n \\______  (____  /__|_|  /\\___  > \\_______  /\\_/  \\___  >__|   \r\n        \\/     \\/      \\/     \\/          \\/          \\/       ");
            Console.ResetColor();

            TypeText("1: Continue from last checkpoint.");
            TypeText("2: Exit to menu.");
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
            int cellchoice;
            TypeText("You move to the other side of the roof and find yourself near the surrounding fence.");
            TypeText("There seem to be 2 possible ways you can make it out of this");
            TypeText("There's a space in between the barbed wire that you could possibly crawl through, but it seems risky");
            TypeText("There's also a guard tower that you could possibly climb up to and escape through there, but there may be someone inside");
            TypeText("1. Climb the guard tower");
            TypeText("2. Crawl through the barbed fence");
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
            int choice;
            TypeText("You begin to crawl through the barbed fence.");
            TypeText("1. Crawl carefully");
            TypeText("2. Rush through");
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
                    }
                    break;
                case 2:
                    TypeText("You rush through the barbed wire, cutting yourself. You bleed out.");
                    Death();
                    break;
            }
        }
        public static void Tower()
        {
            int choice;
            TypeText("You take a step back before leaping onto the side of the guard tower");
            TypeText("Luckily, You manage to grab onto a fixed light on the side of the tower");
            TypeText("You lift yourself over the railing and make it into the tower");
            TypeText("Unfortunetly, a guard happened to be inside the tower as you made it inside");
            TypeText("The guard aims their gun at you and orders you to comply ");
            TypeText("You can see a way to escape the prison on just the other side of the tower, but you need to get past the guard");
            TypeText("1. Reason with the guard");
            TypeText("2. Fight the guard");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Reason();
                    break;
                        case 2:
                    TowerFight();
                    break;
            }
        }
        public static void Reason()
        {
            TypeText("Before you have the chance to say anything, the guard fires his gun, shooting you straight in the head");
            Thread.Sleep(1500);
            Death();
        }
        public static void TowerFight()
        {
            if (shiv = true)
            {
                TypeText("Without giving the guard a chance, you dive into the guard, pressing the shiv deep into their stomach");
                TypeText("The guard collapses on the ground, clutching their chest in pain");
                TypeText("You rush past the guard and make it to the other side of the tower");
                Thread.Sleep(1500);
                TowerEscape();
            }
            else
            {
                TypeText("You dive at the guard, pushing him against the wall");
                TypeText("You try to take a swing at the guard, but they end up firing a round into the side of your waist");
                TypeText("You collapse to the ground, as you hold your wound tight");
                Thread.Sleep(1500);
                Death();
            }
        }
        public static void TowerEscape()
        {
            TypeText("You see a pipe near the front wall of the gate that seems to lead you to the outside of the prison");
            TypeText("You leap over the railing and just manage to get a grip of the pipe as it starts shaking from impact");
            TypeText("you slide down the pipe carefully and manage to make it to the ground safely");
            TypeText("Without a second later, you start sprinting away from the prison, leading to your freedom");
            Thread.Sleep(2000);
            Win();
        }
        public static void Showers()
        {
            int cellchoice;
            TypeText("The showers are all empty, the only thing you see is a bar of soap on the floor");
            if (soap != true)
            {
                TypeText("1. Pick up Soap");
            }
            TypeText("2. Take a shower");
            TypeText("3. Leave showers");
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
            Console.ForegroundColor = ConsoleColor.Red;
            TypeText("  ________                        ________                     \r\n /  _____/_____    _____   ____   \\_____  \\___  __ ___________ \r\n/   \\  ___\\__  \\  /     \\_/ __ \\   /   |   \\  \\/ // __ \\_  __ \\\r\n\\    \\_\\  \\/ __ \\|  Y Y  \\  ___/  /    |    \\   /\\  ___/|  | \\/\r\n \\______  (____  /__|_|  /\\___  > \\_______  /\\_/  \\___  >__|   \r\n        \\/     \\/      \\/     \\/          \\/          \\/       ");
            Console.ResetColor();


            TypeText("1: Continue from last checkpoint.");
            TypeText("2: Exit to menu.");
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
                    strength = 0;
                    money = 10;
                    inmate = true;
                    pudding = false;
                    cross = false;

                    MainMenu();
                    break;
            }
        }

        public static void Win()
        {
            TypeText("You have escaped!");

            Console.ForegroundColor = ConsoleColor.Green;

            TypeText("                                                                                               \r\n _____      _____        _____     ____   ____         _____            ____  _____   ______   \r\n|\\    \\    /    /|  ____|\\    \\   |    | |    |       |\\    \\   _____  |    ||\\    \\ |\\     \\  \r\n| \\    \\  /    / | /     /\\    \\  |    | |    |       | |    | /    /| |    | \\\\    \\| \\     \\ \r\n|  \\____\\/    /  //     /  \\    \\ |    | |    |       \\/     / |    || |    |  \\|    \\  \\     |\r\n \\ |    /    /  /|     |    |    ||    | |    |       /     /_  \\   \\/ |    |   |     \\  |    |\r\n  \\|___/    /  / |     |    |    ||    | |    |      |     // \\  \\   \\ |    |   |      \\ |    |\r\n      /    /  /  |\\     \\  /    /||    | |    |      |    |/   \\ |    ||    |   |    |\\ \\|    |\r\n     /____/  /   | \\_____\\/____/ ||\\___\\_|____|      |\\ ___/\\   \\|   /||____|   |____||\\_____/|\r\n    |`    | /     \\ |    ||    | /| |    |    |      | |   | \\______/ ||    |   |    |/ \\|   ||\r\n    |_____|/       \\|____||____|/  \\|____|____|       \\|___|/\\ |    | ||____|   |____|   |___|/\r\n       )/             \\(    )/        \\(   )/            \\(   \\|____|/   \\(       \\(       )/  \r\n       '               '    '          '   '              '      )/       '        '       '   \r\n                                                                 '                             ");
            Console.ResetColor();

            TypeText("1: Exit to menu.");
            TypeText("2: Exit to desktop.");
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
