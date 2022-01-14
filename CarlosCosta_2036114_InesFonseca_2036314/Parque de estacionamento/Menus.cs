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

            Console.Write("->"); int userSelection = int.Parse(Console.ReadLine());

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
                    //Call Login Admin Menu
                    AdminLogInMenu();
                    break;
                default:
                    //Unnexpected action from the user
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
                    //Closing Application
                    CloseApp(); 
                    break;
                default:
                    //Unnexpected action from the user
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
            int Tries = 3;

            while (Tries <= 3)
            {
                //User input for Pin
                Console.Write("->"); Pin = int.Parse(Console.ReadLine());

                if (Pin == pinCode) { Tries = 3; AdminMenu(); }
                else if (Pin != pinCode && Tries > 0 && Tries <= 3)
                {
                    Console.WriteLine();
                    Console.WriteLine(" -------------------------------------------------------------------");
                    Console.WriteLine("| !!!       Your Pin is Incorrect! Please try again.           !!! |");
                    Console.WriteLine(" -------------------------------------------------------------------");
                    Console.WriteLine("| !!! Failing 3 times, you will be sent back to the main Menu. !!! |");
                    Console.WriteLine(" -------------------------------------------------------------------");
                    Tries--;
                }
                else { MainMenu(); Tries = 3; }
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
                    //Unnexpected action from the user
                    Switchdefault();
                    break;
            }
        }

        //========================= Close the application nor console =========================//
        //Command to Close App
        public static void CloseApp() 
        {
            Environment.Exit(0); 
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
            Console.Write("->"); string carPlateZone1 =  Console.ReadLine();
            CarPlate.listaZona1.Add(carPlateZone1); 

            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            double insertMoneyZone1;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Check the time
            //Variable to accept the same amount of cash inserted in the MoneyMachine method
            double total; 
            ParkPayment paidpark = new ParkPayment();

            //Creating a time span to be added
            Schedule timeZone1 = new Schedule();
            TimeSpan tSpanZone1 = new TimeSpan();

            //Days of the week and schedule rules
            do
            {
                //The client insert the cash and the time is calculated
                Console.WriteLine("|________________>Insert your cash:<________________|");
                Console.Write("->"); insertMoneyZone1 = moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));
                /*if(insertMoneyZone1 == 0) { stop = false; }//If the user input is Zero(0) coins it stops counting
                else 
                {
                    total = paidpark.PayInZone1(insertMoneyZone1);
                    timeZone1.CalculateTime(total);
                    tSpanZone1 = new TimeSpan(Convert.ToInt32(timeZone1.Day), Convert.ToInt32(timeZone1.Hour), Convert.ToInt32(timeZone1.Minute), Convert.ToInt32(timeZone1.Second));
                    //If it's a day of the week, bettween 9 am and 8 pm and if the time counted is less than 45 min         
                    if (DateTime.Now.DayOfWeek != DayOfWeek.Sunday && DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 20 && tSpanZone1.Minutes <= 45)
                    {
                        Console.WriteLine(">>>You have now paid for {0} minutes.\n", tSpanZone1.Minutes);
                        Console.WriteLine("|   You can be parked until: {0}    |", DateTime.Now.Add(tSpanZone1));
                        Console.WriteLine("|                                                   |");
                        Console.WriteLine("|__________Press zero(0) to stop counting___________|");
                    }
                    //If it's a saturday, bettween 9 am and 2 pm and if the time counted is less than 45 min  
                    else if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday && DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 14 && tSpanZone1.Minutes <= 45)
                    {
                        Console.WriteLine(DateTime.Now);
                        Console.WriteLine(">>>You have now paid for {0} minutes.\n", tSpanZone1.Minutes);
                        Console.WriteLine("|   You can be parked until: {0}    |", DateTime.Now.Add(tSpanZone1));
                        Console.WriteLine("|                                                   |");
                        Console.WriteLine("|__________Press zero(0) to stop counting___________|");
                    }
                    //If it's a sunday
                    else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                    {
                        Console.WriteLine(" >You can Park for Free on Sundays.<\n>You will be refunded if you don´t print the ticket!< ");
                        stop = false;
                    }
                    //If exceeds the time allowed for the zone 
                    else
                    {
                        Console.WriteLine(" !!!You can only be parked for 45 min máx! Don´t print the ticket to receive a refund!!!\n");
                        //stop = false;
                    }
                }*/

                //Console.WriteLine("|________________>Insert your cash:<________________|");
                total = paidpark.PayInZone1(insertMoneyZone1);
                timeZone1.CalculateTime(total);
                tSpanZone1 = new TimeSpan(Convert.ToInt32(timeZone1.Day), Convert.ToInt32(timeZone1.Hour), Convert.ToInt32(timeZone1.Minute), Convert.ToInt32(timeZone1.Second));

                //If it's a day of the week, bettween 9 am and 8 pm and if the time counted is less than 45 min
                if (DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.Hour > 9 && DateTime.Now.Hour < 20)
                    {
                        if (tSpanZone1.Minutes > 0 && tSpanZone1.Minutes <= 45)
                        {

                            Console.WriteLine(">>>You have now paid for {0} minutes.\n", tSpanZone1.Minutes);
                            Console.WriteLine("|   You can be parked until: {0}    |", DateTime.Now.Add(tSpanZone1));
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
                        if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 14)
                        {
                            if (tSpanZone1.Minutes >0 && tSpanZone1.Minutes <= 45)
                            {
                                Console.WriteLine(DateTime.Now);
                                Console.WriteLine(">>>You have now paid for {0} minutes.\n", tSpanZone1.Minutes);
                                Console.WriteLine("|   You can be parked until: {0}    |", DateTime.Now.Add(tSpanZone1));
                                Console.WriteLine("|                                                   |");
                                Console.WriteLine("|__________Press zero(0) to stop counting___________|");
                            }
                            else
                            {
                                Console.WriteLine(" !!!You can only be parked for 45 min máx! Don´t print the ticket to receive a refund!!!\n");
                                moneyMachine.refundCash();
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
                else
                {
                    Console.WriteLine(" >You can Park for Free on Sundays.<\n>You will be refunded if you don´t print the ticket!< ");
                    stop = false;
                }
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
                Console.WriteLine("|----------------------zone 1-----------------------|");
                Console.WriteLine("|                " + DateTime.Now + "                |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("  >>>Car Plate: {0}                                 ", carPlateZone1);
                Console.WriteLine("  >>>You can be parked until: {0}                   ", DateTime.Now.Add(tSpanZone1));
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|______Press X if you want to park another car______|");
                Console.WriteLine("|______or press other key if you want to leave._____|");

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
                else { AllMenus.Zone1(); }
            }
            //By default the user is sent to menu zone 1
            else { Switchdefault(); AllMenus.Zone1(); }
            
        }

        //========================= Client Zone2 ========================//
        //ref. https://www.xsprogram.com/content/how-to-jump-to-another-case-statement-in-a-switch-case-condition-with-the-value.html
        public static void Zone2() //Zone2 Interactive Menu
        {
            //Call prints for Zone2 Menu
            ConsolePrints.PrintZone2();

            //Ask the user for a Car Plate
            string carPlateZone2 = Console.ReadLine();
            Console.Write("->"); CarPlate.listaZona2.Add(carPlateZone2);

            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            double insertMoneyZone2;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Cheak the time
            double total; //Variable to accept the same amount of cash inserted in the MoneyMachine method
            ParkPayment paidpark = new ParkPayment();

            //Creating a time span to be added
            Schedule timeZone2 = new Schedule();
            TimeSpan tSpanZone2 = new TimeSpan();

            DateTime novaData = new DateTime();
            //Days of the week and schedule rules
            do
            {
                //The client insert the cash and the time is calculated
                Console.WriteLine("|________________>Insert your cash:<________________|");
                Console.Write("->"); insertMoneyZone2 = moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));
                total = paidpark.PayInZone2(insertMoneyZone2);
                timeZone2.CalculateTime(total);
                tSpanZone2 = new TimeSpan(Convert.ToInt32(timeZone2.Day), Convert.ToInt32(timeZone2.Hour), Convert.ToInt32(timeZone2.Minute), Convert.ToInt32(timeZone2.Second));
                novaData.Add(tSpanZone2);
                //If it's a day of the week, bettween 9 am and 8 pm and if the time counted is less than 120 min         
                if ((int)DateTime.Now.DayOfWeek != 0 && (int)DateTime.Now.DayOfWeek != 6 && DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 20 && total <= 120)
                {
                    Console.WriteLine(">>>You have now paid for {0} minutes.\n", tSpanZone2.Minutes);
                    Console.WriteLine("|   You can be parked until: {0}    |", DateTime.Now.Add(tSpanZone2));
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|__________Press zero(0) to stop counting___________|");
                }
                //If it's a saturday, bettween 9 am and 2 pm and if the time counted is less than 120 min  
                else if ((int)DateTime.Now.DayOfWeek == 6 && DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 14 && total <= 120)
                {
                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine(">>>You have now paid for {0} minutes.\n", tSpanZone2.Minutes);
                    Console.WriteLine("|   You can be parked until: {0}    |", DateTime.Now.Add(tSpanZone2));
                    Console.WriteLine("|                                                   |");
                    Console.WriteLine("|__________Press zero(0) to stop counting___________|");
                }
                //If it's a sunday
                else if ((int)DateTime.Now.DayOfWeek == 0)
                {
                    Console.WriteLine(" >You can Park for Free on Sundays.<\n>You will be refunded if you don´t print the ticket!< ");
                    stop = false;
                }
                //If exceeds the time allowed for the zone 
                else
                {
                    timeZone2.CompareDate(novaData);
                    Console.WriteLine(" !!!You can only be parked for 2 hours max! Don´t print the ticket to receive a refund!!!\n");
                    stop = false;
                }
                //If the user input is Zero(0) coins it stops counting
                if (insertMoneyZone2 == 0) { stop = false; }
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
                Console.WriteLine("  >>>You can be parked until: {0}                   ", DateTime.Now.Add(tSpanZone2));
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|______Press X if you want to park another car______|");
                Console.WriteLine("|______or press other key if you want to leave______|");

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

        //========================= Client Zone3 ========================//
        //ref. https://docs.microsoft.com/en-us/dotnet/api/system.timespan?view=net-6.0
        //ref. https://docs.microsoft.com/en-us/dotnet/api/system.timespan.days?view=net-6.0
        //ref. https://docs.microsoft.com/en-us/dotnet/api/system.datetime.subtract?view=net-6.0
        //ref. https://iditect.com/guide/csharp/csharp_howto_convert_datetime.html
        //ref. https://stackoverflow.com/questions/8702603/merging-two-objects-in-c-sharp
        //ref. https://www.xsprogram.com/content/how-to-jump-to-another-case-statement-in-a-switch-case-condition-with-the-value.html
        public static void Zone3() 
        {
            //Call prints for Zone3 Menu
            ConsolePrints.PrintZone3();

            //Ask the user for a Car Plate
            Console.Write("->"); string carPlateZone3 = Console.ReadLine();
            CarPlate.listaZona3.Add(carPlateZone3);

            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            double insertMoney;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Cheak the time
            double total = 0;
            ParkPayment paidpark = new ParkPayment();
            Schedule newSchedule = new Schedule();

            //TimeSpan to change date based on paid hours
            TimeSpan _TimeSpan = new TimeSpan();
            DateTime _loopDate = DateTime.Now;
            DateTime result = new DateTime();
            
            do
            {
                //the user inserts the coins and it gives the total paid
                //Console.WriteLine("data inicial = _loopDate " + _loopDate);
                Console.WriteLine("\nInsert your cash:");
                Console.Write("->"); insertMoney = Convert.ToDouble(Console.ReadLine());
                total = paidpark.PayInZone3(moneyMachine.insertingCash(insertMoney));

                if (insertMoney != 0) 
                {
                    //Calculate time of parking
                    newSchedule.CalculateTime(Math.Round(total));
                    Console.WriteLine("\n Tempos Calculados {0}d, {1}h, {2}m", newSchedule.Day, newSchedule.Hour, newSchedule.Minute);

                    result = newSchedule.ScheduleForZone(_loopDate, newSchedule.Day, newSchedule.Hour, newSchedule.Minute);
                    Console.WriteLine("\nData saida " + result);
                    //newSchedule.CompareDate(result);
                }
                else 
                {
                    Console.WriteLine(" >You can Park for Free before 9 and after 20h.");
                    stop = false;
                }
            } while (stop == true);

            //Asks if the user wants to print the ticket
            ConsolePrints.PrintTicket();

            //user input to navigate through the Menu
            Console.Write("->"); string ticket = Console.ReadLine(); 
            if (ticket == "y")
            {
                Console.Clear();
                Console.WriteLine(" ___________________________________________________ ");
                Console.WriteLine("|                      TICKET                       |");
                Console.WriteLine("|----------------------zone 3-----------------------|");
                Console.WriteLine("|                " + DateTime.Now + "                |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("  >>>Car Plate: {0}                                 ", carPlateZone3);
                Console.WriteLine("  >>>You can be parked until: {0}                   ", result);
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|______Press X if you want to park another car______|");
                Console.WriteLine("|______or press other key if you want to leave______|");



                //If the user wants to park another car, will be sent to menu start
                Console.Write("->"); string done = Console.ReadLine();
                if (done == "x") { AllMenus.ClientMenu(); }
                else { AllMenus.Start(); }
            }
            //If the user doesn't want to park and want's a refund
            if (ticket == "n")
            {
                Console.WriteLine("You will be refounded.");
                moneyMachine.refundCash();
                Console.WriteLine("Are you sure you want to leave? y or n");
                Console.Write("->"); string sure = Console.ReadLine();
                if (sure == "y") { AllMenus.ClientMenu(); }
                else { AllMenus.Zone3(); }
            }
            //By default the user is sent to menu zone 3
            else { Switchdefault(); AllMenus.Zone3(); }
        }

        //============================================= Admin Report In Zone1 =============================================//
        //Need to create a new void with switch, otherwise the program go to start();
        public static void ZoneAdmin1()
        {
            //Call Prints Admin Report Zone1 Menu
            ConsolePrints.ReportZone1();

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

        //============================================= Admin Report In Zone2 =============================================//
        public static void ZoneAdmin2()
        {
            //Call Prints Admin Report Zone2 Menu
            ConsolePrints.ReportZone2();

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

        //============================================= Admin Report In Zone3 =============================================//
        public static void ZoneAdmin3()
        {
            //Call Prints Admin Report Zone3 Menu
            ConsolePrints.ReportZone3();

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
