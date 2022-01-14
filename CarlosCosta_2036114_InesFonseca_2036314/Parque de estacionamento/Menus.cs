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
        //========================= Start UI =========================//
        public static void Start()
        {
            Console.Clear();
            Console.WriteLine(" ----------------------------");
            Console.WriteLine("|     Machine in standby     |");
            Console.WriteLine(" ----------------------------"); 
            Console.WriteLine("|___Please press start [0]___|");

            Console.Write(">"); int userSelection = int.Parse(Console.ReadLine());

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

        //========================= Main Menu =========================//
        //Ref: https://stackoverflow.com/questions/43484523/switch-statements-for-a-menu-c
        public static void MainMenu() 
        {
            //Call prints of Main Menu
            ConsolePrints.PrintMainMenu();

            //user input to navigate through the Main Menu
            Console.Write("->"); int userSelection = int.Parse(Console.ReadLine()); 

            switch (userSelection) 
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

        //========================= Clients Interactive Menu  =========================//
        public static void ClientMenu()
        {
            //Call prints of Client Menu
            ConsolePrints.PrintClientMenu();

            //user input to navigate through the client Menu
            Console.Write("->"); int userSelection = int.Parse(Console.ReadLine());
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

        //========================= Admin Login Menu  =========================//
        //Security menu for the Admin menu PIN
        public static void AdminLogInMenu()
        {
            Console.Clear();

            //PIN
            int pinCode = 0987;
            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine("| Hello! Please, insert your Admin Pin code.  |");
            Console.WriteLine(" ---------------------------------------------");

            int Pin;
            int tries = 3;

            while (tries <= 3)
            {
                Console.Write("->"); Pin = int.Parse(Console.ReadLine());

                if (Pin == pinCode) { AdminMenu(); tries = 3; }
                else if (Pin != pinCode && tries > 0 && tries <= 3)
                {
                    
                    Console.WriteLine(" -------------------------------------------------------------------");
                    Console.WriteLine("| !!!       Your Pin is Incorrect! Please try again.           !!! |");
                    Console.WriteLine(" -------------------------------------------------------------------");
                    Console.WriteLine("| !!! Failing 3 times, you will be sent back to the main Menu. !!! |");
                    Console.WriteLine(" -------------------------------------------------------------------");
                    tries--;
                }
                else { MainMenu(); tries = 3; }
            }
        }

        //========================= Admin Interactive Menu  =========================//
        public static void AdminMenu()
        {
            //Call prints of Admin Menu
            ConsolePrints.PrintAdminMenu();

            //user input to navigate through the Admin Menu
            Console.Write("->"); int userSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 0:
                    Start();
                    break;
                case 1:
                    //Call the Admin Report Menu in Zone1
                    ZoneAdmin1();
                    break;
                case 2:
                    //Call the Admin Report Menu in Zone2
                    ZoneAdmin2();
                    break;
                case 3:
                    //Call the Admin Report Menu in Zone3
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

        //========================= Close the application nor console =========================//
        //Command to Close App
        public static void CloseApp() //Close the application nor console
        {

            Environment.Exit(0); //Command to Close App
        }

        //========================= Default choice =========================//
        //If none of the avaible options is selected
        public static void Switchdefault()
        {
           Console.WriteLine("_!!! Please, choose only the numbers available in the script !!!_");
        }

        //========================= Client Zone1 ========================//
        //ref. https://www.xsprogram.com/content/how-to-jump-to-another-case-statement-in-a-switch-case-condition-with-the-value.html
        public static void Zone1() 
        {
            //Call prints for Zone1 Menu
            ConsolePrints.PrintZone1();

            //Ask the user for a Car Plate
            Console.Write("->"); string carPlateZone1 = Console.ReadLine();
            CarPlate.listaZona1.Add(carPlateZone1);
               
            
            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Cheak the time
            //Variable to accept the same amount of cash inserted in the MoneyMachine method
            double total; 
            ParkPayment paidpark = new ParkPayment();

            //Days of the week and schedule rules
            do
            {
                //The client insert the cash and the time is calculated
                Console.WriteLine("|________________>Insert your cash:<________________|");
                total = moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));
                //Console.WriteLine(paidpark.PayInZone1(total));

                if ((int)DateTime.Now.DayOfWeek != 0)
                {
                    //If it's a day of the week, bettween 9 am and 8 pm and if the time counted is less than 45 min    
                    if ((int)DateTime.Now.DayOfWeek != 6 && DateTime.Now.Hour > 9 && DateTime.Now.Hour < 20)
                    {
                        if (paidpark.PayInZone1(total) <= 45)
                        {
                            
                            Console.WriteLine(">>>You have now paid for {0} minutes.\n", Math.Round(paidpark.PayInZone1(total)));  
                            Console.WriteLine("|   You can be parked until: {0}    |", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone1(total))));
                            Console.WriteLine("|                                                   |");
                            Console.WriteLine("|__________Press zero(0) to stop counting___________|");
                        }
                        else
                        {
                            Console.WriteLine(" !!!You can only be parked for 45 min máx! Don´t print the ticket to receive a refund!!!\n");
                            stop = false;
                        }
                    }
                    else
                    {
                        //On Saturdays schedule
                        if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 14) 
                        {
                            if (paidpark.PayInZone1(total) <= 45)
                            {
                                Console.WriteLine(DateTime.Now);
                                Console.WriteLine(">>>You have now paid for {0} minutes.\n", Math.Round(paidpark.PayInZone1(total)));
                                Console.WriteLine("|   You can be parked until: {0}    |", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone1(total))));
                                Console.WriteLine("|                                                   |");
                                Console.WriteLine("|__________Press zero(0) to stop counting___________|");
                            }
                            else
                            {
                                Console.WriteLine(" !!!You can only be parked for 45 min máx! Don´t print the ticket to receive a refund!!!\n");
                                stop = false;
                            }
                        }
                        else 
                        {
                            Console.WriteLine(" >You can Park for Free before 9 and after 20h.\nYou will be refunded if you don´t print the ticket!< ");
                            stop = false;
                        }
                    }
                }
                else //On Sundays
                {   
                    Console.WriteLine(" >You can Park for Free on Sundays.<\n>You will be refunded if you don´t print the ticket!< ");
                    stop = false;
                }
                //Console.WriteLine("You can be parked for {0} time.",Math.Round(paidpark.PayInZone1(total))); //Returns the aproximated time for the amount of inserted coins
                if (moneyMachine._cash == 0) { stop = false;}
            } while (stop == true);


            //=============== Asking the user if he wants to Print a ticket ===============// 
            ConsolePrints.PrintTicket();
            //user input to navigate through the Menu
            Console.Write("->"); string ticket = Console.ReadLine();
            if (ticket == "y")
            {
                Console.Clear();
                Console.WriteLine(" ___________________________________________________ ");
                Console.WriteLine("|                      TICKET                       |");
                Console.WriteLine("|----------------------zone 1-----------------------|");
                Console.WriteLine("|                " + DateTime.Now + "                |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("  >>>Car Plate: {0}                                 ", carPlateZone1);
                Console.WriteLine("  >>>You can be parked until: {0}                   ", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone1(total))));
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|______Press X if you want to park another car______|");
                Console.WriteLine("|______or press other key if you want to leave._____|");

                //If the user wants to park another car, will be sent to menu start
                string done = Console.ReadLine();
                if (done == "x")
                {
                   AllMenus.ClientMenu();
                }
                else 
                {
                    AllMenus.Start();
                }
            }
            //If the user doesn't want to park and want's a refund
            if (ticket == "n")
            {
                Console.WriteLine(" ___________________________________________________ ");
                Console.WriteLine("|              You will be refunded                 |");
                moneyMachine.refundCash();
                Console.WriteLine("|____Are you sure you want to leave? (y) or (n)_____|");
                string sure = Console.ReadLine();
                if(sure == "y") { AllMenus.ClientMenu(); }
                else { AllMenus.Zone1(); }
            }
            //By default the user is sent to menu zone 1
            else
            {
                Switchdefault(); 
                AllMenus.Zone1();
            }
        }

        //========================= Client Zone2 ========================//
        //ref. https://www.xsprogram.com/content/how-to-jump-to-another-case-statement-in-a-switch-case-condition-with-the-value.html
        public static void Zone2()
        {
            //Call prints for Zone2 Menu
            ConsolePrints.PrintZone2();

            //Ask the user for a Car Plate
            Console.Write("->"); string carPlateZone2 = Console.ReadLine();
            CarPlate.listaZona2.Add(carPlateZone2);

            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Cheak the time
            double total; //Variable to accept the same amount of cash inserted in the MoneyMachine method
            ParkPayment paidpark = new ParkPayment();

            do
            {
                //The client insert the cash and the time is calculated
                Console.WriteLine("|________________>Insert your cash:<________________|");
                Console.Write("->"); total = moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));


                if ((int)DateTime.Now.DayOfWeek != 0)
                {
                    //If it's a day of the week, bettween 9 am and 8 pm and if the time counted is less than 120 min 
                    if ((int)DateTime.Now.DayOfWeek != 6 && DateTime.Now.Hour > 9 && DateTime.Now.Hour < 20)
                    {
                        if (paidpark.PayInZone2(total) <= 120)
                        {
                            Console.WriteLine(">>>You have now paid for {0} minutes.\n", Math.Round(paidpark.PayInZone2(total)));
                            Console.WriteLine("|   You can be parked until: {0}    |", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone2(total))));
                            Console.WriteLine("|                                                   |");
                            Console.WriteLine("|__________Press zero(0) to stop counting___________|");
                        }

                        else
                        {
                            Console.WriteLine(" !!! You can only be parked for 2 hours máx! Don´t print the ticket to receive a refund !!!\n");
                            stop = false;
                        }
                    }
                    else
                    {
                        //If it's a saturday, bettween 9 am and 2 pm and if the time counted is less than 120 min  
                        if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 14)
                        {
                            if (paidpark.PayInZone2(total) <= 120)
                            {
                                Console.WriteLine(DateTime.Now);
                                Console.WriteLine(">>>You have now paid for {0} minutes.\n", Math.Round(paidpark.PayInZone2(total)));
                                Console.WriteLine("|   You can be parked until: {0}    |", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone2(total))));
                                Console.WriteLine("|                                                   |");
                                Console.WriteLine("|__________Press zero(0) to stop counting___________|");
                            }
                            else//If exceeds the time allowed for the zone
                            {
                                Console.WriteLine(" !!!You can only be parked for 2 hours máx! Don´t print the ticket to receive a refund!!! ");
                                stop = false;
                            }
                        }
                        else //If time allowed is out of the zone schedule
                        {
                            Console.WriteLine(" >You can Park for Free before 9 and after 20h. You will be refunded!< ");
                            stop = false;
                        }
                    }
                }
                else //If it's a sunday
                {
                    Console.WriteLine(" >You can Park for Free on Sundays.\nIf you inserted money you will be refounded!< ");
                    stop = false;
                }
                if (moneyMachine._cash == 0) { stop = false; }
            } while (stop == true);

            //=============== Asking the user if he wants to Print a ticket ===============// 
            ConsolePrints.PrintTicket();

            //======= User input to navigate through integreated Ticket Menu ========//
            Console.Write("->"); string ticket = Console.ReadLine();
            if (ticket == "y")
            {
                Console.Clear();
                Console.WriteLine(" ___________________________________________________ ");
                Console.WriteLine("|                      TICKET                       |");
                Console.WriteLine("|----------------------zone 2-----------------------|");
                Console.WriteLine("|                " + DateTime.Now + "                |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("  >>>Car Plate: {0}                                 ", carPlateZone2);
                Console.WriteLine("  >>>You can be parked until: {0}                   ", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone2(total))));
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|______Press X if you want to park another car______|\n|______or press other key if you want to leave______|");

                //If the user wants to park another car, will be sent to menu start
                Console.Write("->"); string done = Console.ReadLine();
                if (done == "x") { AllMenus.ClientMenu(); }
                else { AllMenus.Start(); }
            }
            //If the user doesn't want to park and want's a refund
            if (ticket == "n")
            {
                Console.WriteLine(" ___________________________________________________ ");
                Console.WriteLine("|              You will be refunded                 |");
                moneyMachine.refundCash();
                Console.WriteLine("|____Are you sure you want to leave? (y) or (n)_____|");
                Console.Write("->"); string sure = Console.ReadLine();
                if (sure == "y") { AllMenus.ClientMenu(); }
                else { AllMenus.Zone2(); }
            }
            //By default the user is sent to menu zone 2
            else { Switchdefault(); AllMenus.Zone2(); }
        }


        public static void Zone3() //Zone3 Interactive Menu
        {
            Console.Clear();
            Console.WriteLine(" ___________________________________________________");
            Console.WriteLine("|                  Zone 3 selected                  |");
            Console.WriteLine("|                " + DateTime.Now + "                |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|------------------Price/max.Hour-------------------|");
            Console.WriteLine("|               0.62€/h - no max.hours              |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|________________>Insert your Plate:<_______________|"); //Ask the user for a Car Plate
            string carPlateZone3 = Console.ReadLine();
            //CarPlate newCarPlate = new CarPlate("0", "0", carPlateZone3);

            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Cheak the time
            double total;
            ParkPayment paidpark = new ParkPayment();
            Schedule newSchedule = new Schedule();

            double insertMoney;

            //TimeSpan to change date based on paid hours
            //https://docs.microsoft.com/en-us/dotnet/api/system.timespan?view=net-6.0
            //https://docs.microsoft.com/en-us/dotnet/api/system.timespan.days?view=net-6.0
            //https://docs.microsoft.com/en-us/dotnet/api/system.datetime.subtract?view=net-6.0

            DateTime _startingDate = DateTime.Now;
            DateTime _loopDate = new DateTime();
            _loopDate = _startingDate;
            DateTime result = new DateTime();

            do
            {
                //Console.WriteLine("data inicial = _loopDate " + _loopDate);
                Console.WriteLine("\nInsert your cash:");
                insertMoney = Convert.ToDouble(Console.ReadLine());
                total = paidpark.PayInZone3(moneyMachine.insertingCash(insertMoney));
                //Console.WriteLine("total variable " + total);

                newSchedule.CalculateTime(Math.Round(total)); //Calculate time
                Console.WriteLine("\n You paid to park for {0}Day(s), {1}Hour(s), {2}Minute(s)", newSchedule.Day, newSchedule.Hour, newSchedule.Minute);

                //TimeSpan tSpan = new System.TimeSpan((int)newSchedule.Day, (int)newSchedule.Hour, (int)newSchedule.Minute, 1);
                result = newSchedule.ScheduleForZone(_loopDate, newSchedule.Day, newSchedule.Hour, newSchedule.Minute);
                newSchedule.CompareDate(result);

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
                newSchedule.CompareDate(result);
                //Console.WriteLine("\nYou can be parked for {0} time.", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone3(total))));
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

        //============================================= Admin Report In Zone1 =============================================//
        //Need to create a new void with switch, otherwise the program go to start();
        public static void ZoneAdmin1()
        {
            //Call Prints Admin Report Zone1 Menu
            ConsolePrints.ReportZone1();

            Console.Write("->"); int userSelection = int.Parse(Console.ReadLine());
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

        //============================================= Admin Report In Zone2 =============================================//
        public static void ZoneAdmin2() 
        {
            //Call Prints Admin Report Zone2 Menu
            ConsolePrints.ReportZone2();
            
            Console.Write("->"); int userSelection = int.Parse(Console.ReadLine());
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

        //============================================= Admin Report In Zone3 =============================================//
        public static void ZoneAdmin3() //Admin report for Zone3
        {
            //Call Prints Admin Report Zone3 Menu
            ConsolePrints.ReportZone3();

            Console.Write("->"); int userSelection = int.Parse(Console.ReadLine());
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
