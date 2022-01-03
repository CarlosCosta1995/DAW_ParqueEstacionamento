using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Functionalities;
using ConsolePrint;

namespace Menus
{
    public class AllMenus
    {
        //https://www.youtube.com/watch?v=9JST13MhrFU

        public static void Start() //Start UI
        {
            Console.Clear();
            Console.WriteLine("Machine in standby.");
            Console.WriteLine("Please press start [0]");

            int userSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 0:
                    MainMenu();
                    break;
                default:
                    Switchdefault();
                    break;
            }
        }

        public static void MainMenu() //Main Menu
        {
                ConsolePrints.PrintMainMenu(); //Call prints of Main Menu

                int userSelection = int.Parse(Console.ReadLine()); //user input to navigate through the Main Menu

                switch (userSelection) //Ref: https://stackoverflow.com/questions/43484523/switch-statements-for-a-menu-c
                {
                    case 0:
                        //Closing Application
                        CloseApp(); 
                        break;
                    case 1:
                        //Call client Menu
                        ClientMenu();
                        break;
                    case 2:
                        //Call Admin Menu
                        //AdminMenu();
                        AdminLogInMenu();
                        break;
                    default:
                        //Unnexpected action from the user. What should it happen in this case?
                        Switchdefault();
                        break;
                }
        } 

        public static void ClientMenu() //Clients Interactive Menu 
        {
            ConsolePrints.PrintClientMenu(); //Call prints of Client Menu

            int userSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 0:
                    MainMenu();
                    break;
                case 1:
                    Zone1();
                    break;
                case 2:
                    Zone2();
                    break;
                case 3:
                    Zone3();
                    break;
                case 4:
                    MainMenu();
                    break;
                case 5:
                    CloseApp(); //Closing Application
                    break;
                default:
                    //Unnexpected action from the user. What should it happen in this case?
                    Switchdefault();
                    break;
            }
        } 

        public static void AdminLogInMenu() //Security menu for the Admins
        {
            Console.Clear();

            int pinCode = 0987;

            Console.WriteLine("Hello! Please, insert your Admin Pin code.\n"); // \n == Enter, \t == tab, \b == ' '
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

        public static void AdminMenu() //Clients Interactive Menu
        {
            ConsolePrints.PrintAdminMenu();//Call prints of Admin Menu

            int userSelection = int.Parse(Console.ReadLine()); 

            switch (userSelection)
            {
                case 0:
                    Start();
                    break;
                case 1:
                    ZoneAdmin1();
                    break;
                case 2:
                    ZoneAdmin2();
                    break;
                case 3:
                    ZoneAdmin3();
                    break;
                case 4:
                    MainMenu();
                    break;
                default:
                    //Unnexpected action from the user. What should it happen in this case?
                    Switchdefault();
                    break;
            }
        }
        
        public static void CloseApp() //Close the application nor console
        {

            Environment.Exit(0); //Command to Close App
        }

        public static void Switchdefault()//If none of the avaible options is selected 
        {
           Console.WriteLine("Please, choose only the numbers available in the script");
        }

        //Zones for Client
        public static void Zone1() //Zone1 Interactive Menu
        {
            Console.Clear();
            Console.WriteLine("Zone 1 selected");
            Console.WriteLine("---Price/max.Hour---");
            Console.WriteLine("1.15€/h - max.45 min");

            //Ask the user for a Car Plate
            Console.WriteLine("Insert your Plate:");
            string carPlateZone1 = Console.ReadLine();
            // CarPlate newCarPlate = new CarPlate(carPlateZone1);

            //CarPlate._plateArrayZone1[0] =  carPlateZone1;

            CarPlate.novaLista.Add(carPlateZone1);


            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Cheak the time
            double total;
            ParkPayment paidpark = new ParkPayment();


            do
            {
                Console.WriteLine("\nInsert your cash:");
                total = moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine())); 
                

                Console.WriteLine("====!!===== " + total);
                Console.WriteLine("You can be parked for {0} time.",Math.Round(paidpark.PayInZone1(total)));
                Console.WriteLine("Press zero(0) to stop counting.");
                if (moneyMachine._cash == 0) { stop = false;}
            } while (stop == true);

            //For Print ticket
            Console.WriteLine("Do you want to print your ticket? \n yes(y) or no(n)");
            string ticket = Console.ReadLine(); //user input to navigate through the Menu
            if (ticket == "y")
            {
                Console.Clear();
                Console.WriteLine("ticket");
                Console.WriteLine("----zone 1----");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("array novo, devia dar matricula -> " + CarPlate._plateArrayZone1.Count());
                Console.WriteLine("array novo, devia dar matricula -> " + CarPlate.novaLista.Count());
                Console.WriteLine("array novo, devia dar matricula -> " + CarPlate.novaLista[0]);
                Console.WriteLine("Car Plate: {0}", carPlateZone1);
                Console.WriteLine("\nYou can be parked for {0} time.", paidpark.PayInZone1(total));
                Console.WriteLine("Press X if you want to park another car,\nor press other key if you want to leave.");

                string done = Console.ReadLine();
                if (done == "x")
                {
                    Console.WriteLine("You will be sent to the Client Menu!");
                    AllMenus.ClientMenu();
                }
                else 
                {
                    Console.WriteLine("Thank you and have a nice day!");
                    AllMenus.Start();
                }
            }
            if (ticket == "n")
            {
                Console.WriteLine("You will be refounded.");
                moneyMachine.refundCash();
                Console.WriteLine("Are you sure you want to leave? y or n");
                string sure = Console.ReadLine();
                if(sure == "y") { AllMenus.ClientMenu(); }
                else { AllMenus.Zone1(); }
            }
            else
            {
                Switchdefault(); //ref. https://www.xsprogram.com/content/how-to-jump-to-another-case-statement-in-a-switch-case-condition-with-the-value.html
                AllMenus.Zone1();
            }
        }

        public static void Zone2() //Zone2 Interactive Menu
        {
            Console.Clear();
            Console.WriteLine("Zone 2 selected");
            Console.WriteLine("---Price/max.Hour---");
            Console.WriteLine("1€/h - max.2 hours");

            //Ask the user for a Car Plate
            Console.WriteLine("Insert your Plate:");
            string carPlateZone2 = Console.ReadLine();
           // CarPlate newCarPlate = new CarPlate("0", carPlateZone2, "0");

            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Cheak the time
            double total = moneyMachine._addCash;
            ParkPayment paidpark = new ParkPayment();

            do
            {
                Console.WriteLine("\nInsert your cash:");
                moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("You can be parked for {0} time.", paidpark.PayInZone1(total));
                Console.WriteLine("Press zero(0) if you want to stop counting.");
                if (moneyMachine._cash == 0) { stop = false; }
            } while (stop == true);

            //For Print ticket
            Console.WriteLine("Do you want to print your ticket? \n yes(y) or no(n)");
            string ticket = Console.ReadLine(); //user input to navigate through the Menu
            if (ticket == "y")
            {
                Console.Clear();
                Console.WriteLine("ticket");
                Console.WriteLine("----zone 2----");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("Car Plate: {0}", carPlateZone2);
                Console.WriteLine("\nYou can be parked for {0} time.", paidpark.PayInZone1(total));
                Console.WriteLine("Press X if you want to park another car,\nor press other key if you want to leave.");

                string done = Console.ReadLine();
                if (done == "x")
                {
                    Console.WriteLine("You will be sent to the Client Menu!");
                    AllMenus.ClientMenu();
                }
                else
                {
                    Console.WriteLine("Thank you and have a nice day!");
                    AllMenus.Start();
                }
            }
            if (ticket == "n")
            {
                Console.WriteLine("You will be refounded.");
                moneyMachine.refundCash();
                Console.WriteLine("Are you sure you want to leave? y or n");
                string sure = Console.ReadLine();
                if (sure == "y") { AllMenus.ClientMenu(); }
                else { AllMenus.Zone2(); }
            }
            else
            {
                Switchdefault(); //ref. https://www.xsprogram.com/content/how-to-jump-to-another-case-statement-in-a-switch-case-condition-with-the-value.html
                AllMenus.Zone2();
            }
        }

        public static void Zone3() //Zone3 Interactive Menu
        {
            Console.Clear();
            Console.WriteLine("Zone 3 selected");
            Console.WriteLine("---Price/max.Hour---");
            Console.WriteLine("0.62€/h - no max.hours");

            //Ask the user for a Car Plate
            Console.WriteLine("Insert your Plate:");
            string carPlateZone3 = Console.ReadLine();
            //CarPlate newCarPlate = new CarPlate("0", "0", carPlateZone3);

            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Cheak the time
            double total = moneyMachine._addCash;
            ParkPayment paidpark = new ParkPayment();

            do
            {
                Console.WriteLine("\nInsert your cash:");
                moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("You can be parked for {0} time.", paidpark.PayInZone1(total));
                Console.WriteLine("Press zero(0) to stop counting.");
                if (moneyMachine._cash == 0) { stop = false; }
            } while (stop == true);

            //For Print ticket
            Console.WriteLine("Do you want to print your ticket? \n yes(y) or no(n)");
            string ticket = Console.ReadLine(); //user input to navigate through the Menu
            if (ticket == "y")
            {
                Console.Clear();
                Console.WriteLine("ticket");
                Console.WriteLine("----zone 3----");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine("Car Plate: {0}", carPlateZone3);
                Console.WriteLine("\nYou can be parked for {0} time.", paidpark.PayInZone1(total));
                Console.WriteLine("Press X if you want to park another car,\nor press other key if you want to leave.");

                string done = Console.ReadLine();
                if (done == "x")
                {
                    Console.WriteLine("You will be sent to the Client Menu!");
                    AllMenus.ClientMenu();
                }
                else
                {
                    Console.WriteLine("Thank you and have a nice day!");
                    AllMenus.Start();
                }
            }
            if (ticket == "n")
            {
                Console.WriteLine("You will be refounded.");
                moneyMachine.refundCash();
                Console.WriteLine("Are you sure you want to leave? y or n");
                string sure = Console.ReadLine();
                if (sure == "y") { AllMenus.ClientMenu(); }
                else { AllMenus.Zone3(); }
            }
            else
            {
                Switchdefault(); //ref. https://www.xsprogram.com/content/how-to-jump-to-another-case-statement-in-a-switch-case-condition-with-the-value.html
                AllMenus.Zone3();
            }
        }

        //Zones for the Admin
        //Need to create a now void with switch, otherwise the program go to start();
        public static void ZoneAdmin1() //Admin report for Zone1
        {
            ConsolePrints.ReportZone1();
            Console.WriteLine("\nBack to Admin menu [0]");
            Console.WriteLine("Back to Main menu [1]");
            Console.WriteLine("Back to standby menu [2]");

            int userSelection = int.Parse(Console.ReadLine());
            switch (userSelection)
            {
                case 0:
                    AdminMenu();
                    break;
                case 1:
                    MainMenu();
                    break;
                case 2:
                    Start();
                    break;
            }
        }

        public static void ZoneAdmin2() //Admin report for Zone2
        {
            ConsolePrints.ReportZone2();
            Console.WriteLine("\nBack to Admin menu [0]");
            Console.WriteLine("Back to Main menu [1]");
            Console.WriteLine("Back to standby menu [2]");

            int userSelection = int.Parse(Console.ReadLine());
            switch (userSelection)
            {
                case 0:
                    AdminMenu();
                    break;
                case 1:
                    MainMenu();
                    break;
                case 2:
                    Start();
                    break;
            }
        }

        public static void ZoneAdmin3() //Admin report for Zone3
        {
            ConsolePrints.ReportZone3();
            Console.WriteLine("\nBack to Admin menu [0]");
            Console.WriteLine("Back to Main menu [1]");
            Console.WriteLine("Back to standby menu [2]");

            int userSelection = int.Parse(Console.ReadLine());
            switch (userSelection)
            {
                case 0:
                    AdminMenu();
                    break;
                case 1:
                    MainMenu();
                    break;
                case 2:
                    Start();
                    break;
            }
        }
    }
}
