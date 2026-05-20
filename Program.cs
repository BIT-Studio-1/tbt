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
            Thread.Sleep(8000);
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

        public static void Scene1()
        {

        }

        public static void Inventory()
        {

        }
        //Richie start
        public static void Yard()
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
                        action_2 = Convert.ToInt32(Console.ReadLine());
                        switch (action_2)
                        {
                            case 1:
                            {
                                    //Fight_Jamal(); HELLO
                                    break;
                            }
                            case 2:
                            {
                                    break;
                            }
                            case 3:
                            {
                                    //Gift_jamal();
                                    break;
                                
                            }
                        }
                        break;
                }
                case 2:
                {
                        Cell();
                        break;
                
                }
            }
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
