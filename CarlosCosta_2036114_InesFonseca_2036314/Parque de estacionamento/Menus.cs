using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Functionalities;

namespace Menus
{
    public class AllMenus
    {
        public static void MainMenu() 
        {
            Console.Clear();

                Console.WriteLine("\nWelcome to CarSlot Parking Agency!");
                Console.WriteLine(DateTime.Now); //Display date and time
                Console.WriteLine("Navigate through the Menus by presseing the representative number!");
                Console.WriteLine("Client Menu [0]");
                Console.WriteLine("Admin Menu [1]");
                Console.WriteLine("Options [2]");
                Console.WriteLine("Leave Application [3]");
                
                int userSelection = int.Parse(Console.ReadLine()); //user input to navigate through the Main Menu

                switch (userSelection) //Ref: https://stackoverflow.com/questions/43484523/switch-statements-for-a-menu-c
                {
                    case 0:
                        //Call client Menu
                        ClientMenu();
                        break;
                    case 1:
                        //Call Admin Menu
                        //AdminMenu();
                        AdminLogInMenu();
                        break;
                    case 2:
                        //Call Option Menu
                        OptionsMenu();
                        break;
                    case 3:
                        CloseApp(); //Closing Application
                        break;
                    default:
                        //Unnexpected action from the user. What should it happen in this case?
                        Console.WriteLine("choose only bettween the numbers on the console, please!");
                        break;
                }
            }
        public static void ClientMenu() //https://www.youtube.com/watch?v=9JST13MhrFU
        {
            Console.Clear();

            Console.WriteLine("\nClientMenu selected!");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("     >Schedule<    ");
            Console.WriteLine("----working days----");
            Console.WriteLine(" 9:00 am - 8:00 pm ");
            Console.WriteLine("-----saturdays------");
            Console.WriteLine(" 9:00 am - 2:00 pm ");
            Console.WriteLine(">Choose a zone number<");
            Console.WriteLine("zone 1");
            Console.WriteLine("zone 2");
            Console.WriteLine("zone 3");
            Console.WriteLine("Back to Main Menu [0]");
            Console.WriteLine("Leave Application [5]");

            int zone = int.Parse(Console.ReadLine());

            switch (zone)
            {
                case 0:
                    MainMenu();
                    break;
                case 1:
                    Console.WriteLine("\nZone 1 selected");
                    Console.WriteLine("-Price/máx.Hour-");
                    Console.WriteLine("1.15€/h - max.45 min");
                    ClientMenu();
                    break;
                case 2:
                    Console.WriteLine("\nZone 2 selected");
                    Console.WriteLine("-Price/máx.Hour-");
                    Console.WriteLine("1€/h - max.2 hours");
                    ClientMenu();
                    break;
                case 3:
                    Console.WriteLine("\nZone 3 selected");
                    Console.WriteLine("-Price/máx.Hour-");
                    Console.WriteLine("0.62€/h - no max.hours");
                    ClientMenu();
                    break;
                case 4:
                    //CloseApp(); //Closing Application
                    break;
                case 5:
                    CloseApp(); //Closing Application
                    break;
                default:
                    //Unnexpected action from the user. What should it happen in this case?
                    Console.WriteLine("choose only bettween the numbers on the console, please!");
                    break;
            }

            /*
            if (zone == 0)
            {
                MainMenu();
            }
            if (zone == 1)
            {
                Console.WriteLine("Zone 1 selected");
                Console.WriteLine("-Price/máx.Hour-");
                Console.WriteLine("1.15€/h - max.45 min");
       
    
            }

            if (zone == 2)
            {
                Console.WriteLine("Zone 2 selected");
                Console.WriteLine("-Price/máx.Hour-");
                Console.WriteLine("1€/h - max.2 hours");

            }

            if (zone == 3)
            {
                Console.WriteLine("Zone 3 selected");
                Console.WriteLine("-Price/máx.Hour-");
                Console.WriteLine("0.62€/h - no max.hours");


            }
            if (zone == 5)
            {
                CloseApp();
            }*/
        }

        public static void AdminLogInMenu() 
        {
            Console.Clear();

            int pinCode = 0987;

            Console.WriteLine("Hello! Please, insert your Admin Pin code.\n");
            int pin = int.Parse(Console.ReadLine());

                if (pin == pinCode)
                {
                    Console.WriteLine("Your Pin is correct!\n");
                    AdminMenu();
                }
                /*else if (pin != pinCode && tries < 3)
                {
                    Console.WriteLine("Your Pin is Incorrect! Please try again.\n");
                    AdminLogInMenu();
                    tries++;
                }*/
                else if (pin != pinCode)
                {
                    Console.WriteLine("Blocked, you will be sent back to the main Menu. Goodbye!");
                    MainMenu();
                }
        }

        public static void AdminMenu()
        {
            Console.Clear();

            Console.WriteLine("\nAdminMenu selected!");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("     >Schedule<    ");
            Console.WriteLine("----working days----");
            Console.WriteLine(" 9:00 am - 8:00 pm ");
            Console.WriteLine("-----saturdays------");
            Console.WriteLine(" 9:00 am - 2:00 pm ");
            Console.WriteLine(">Choose a zone number<");
            Console.WriteLine("zone 1");
            Console.WriteLine("zone 2");
            Console.WriteLine("zone 3");
            Console.WriteLine("Back to Main Menu [0]");
            Console.WriteLine("Back to Admin Main Menu [4]");
            Console.WriteLine("Leave Application [5]");


            int zone = int.Parse(Console.ReadLine());

            switch (zone)
            {
                case 0:
                    MainMenu();
                    break;
                case 1:
                    Console.WriteLine("Zone 1 selected");
                    Console.WriteLine("-Price/máx.Hour-");
                    Console.WriteLine("1.15€/h - max.45 min");
                    AdminMenu();
                    break;
                case 2:
                    Console.WriteLine("Zone 2 selected");
                    Console.WriteLine("-Price/máx.Hour-");
                    Console.WriteLine("1€/h - max.2 hours");
                    AdminMenu();
                    break;
                case 3:
                    Console.WriteLine("Zone 3 selected");
                    Console.WriteLine("-Price/máx.Hour-");
                    Console.WriteLine("0.62€/h - no max.hours");
                    AdminMenu();
                    break;
                case 4:
                    CloseApp(); //Closing Application
                    break;
                case 5:
                    AdminMenu();
                    break;
                default:
                    //Unnexpected action from the user. What should it happen in this case?
                    Console.WriteLine("choose only bettween the numbers on the console, please!");
                    break;
            }
            /*
            if (zone == 1)
            {
                Console.WriteLine("Zone 1 selected");
                Console.WriteLine("-Price/máx.Hour-");
                Console.WriteLine("1.15€/h - max.45 min");


            }

            if (zone == 2)
            {
                Console.WriteLine("Zone 2 selected");
                Console.WriteLine("-Price/máx.Hour-");
                Console.WriteLine("1€/h - max.2 hours");

            }

            if (zone == 3)
            {
                Console.WriteLine("Zone 3 selected");
                Console.WriteLine("-Price/máx.Hour-");
                Console.WriteLine("0.62€/h - no max.hours");


            }*/

        }

        public static void OptionsMenu ()
        {
            Console.Clear();

            Console.WriteLine("OptionsMenu selected!");
        }
        public static void CloseApp()
        {

            Environment.Exit(0); //Command to Close App
        }
    }
}
