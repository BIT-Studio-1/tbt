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
            Console.WriteLine("You have been convicted of watching anime on an illegal website.");
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
            
            int celldec, cellchoice;
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
            if (celldec == 3)
            {
                //SceneCafeteria();
            }
            if (celldec == 4) 
            {
                //SceneOC();
            }

            

        }
        public static void Bed()
        {
            Console.WriteLine("It's an old rusty bed. The mattress has some weird stains on them, might be blood.");
            Thread.Sleep(1500);
            Cell();
        }

        public static void Scene1()
        {

        }

        public static void Inventory()
        {

        }
        static bool flowers = false;
        static bool screwdriver = false;
        //Richie start
        public static void Yard()
        {
            bool inYard = true;
            while (inYard)
            {
                int action_1 = 0, action_2 = 0;
                Console.WriteLine("You enter the Yard");
                Console.WriteLine("You see look around and see another inmate");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1:\tConfront Jamal");
                Console.WriteLine("2:\tExit Yard");
                action_1 = Convert.ToInt32(Console.ReadLine());
                switch (action_1)
                {
                    case 1:
                        {
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
                                    {
                                        //Fight_Jamal(); 
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("JAMAL:\t'Hmmm, I could really use some flowers right now'");
                                        break;
                                    }
                                case 3:
                                    {
                                        Gift_Jamal();
                                        break;

                                    }
                                case 4:
                                    {
                                        Console.WriteLine("You check around the yard and came accross a batch of flowers");
                                        Console.WriteLine("You pick up the batch of flowers");
                                        flowers = true;
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
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
                Console.WriteLine("JAMAL:\t'Aww flowers, thank you so much. Here's a screwdriver");
                screwdriver = true;
                flowers = false;
            }
            else
            {
                Console.WriteLine("you don't have anything to give Jamal");
            }
            Yard();
        }
        //richie


































        public static void Cafeteria()
        {
            int action_1 = 0;
            Console.WriteLine("You enter the Cafeteria and look around.");
            Console.WriteLine("You see Crack Head Joe sitting at one of the tables.");
            Console.WriteLine("You also see the chow line.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1:\tTalk to Crack Head Joe.");
            Console.WriteLine("2:\tEnter the Chow Line.");
            Console.WriteLine("3:\tExit Cafeteria.");
            action_1 = Convert.ToInt32(Console.ReadLine());
            switch (action_1)
            {
                case 1:
                    {
                        Console.WriteLine("You walk up to Crack Head Joe.");
                        Console.WriteLine("'Hmmm... I could really use some pudding right now' he mutters.");
                        break;
                    }
                    

                case 2:
                    {



                        break;
                    }


            }
        }
    }

}
