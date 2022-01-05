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

        TimeSpan ticket_;

        public static long ConvertDatetimeToUnixTimeStamp(DateTime date)
        {
            DateTime originDate = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - originDate;
            return (long)Math.Floor(diff.TotalSeconds);
        }
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

        //============================================= Zones for Client =============================================//
        public static void Zone1() //Zone1 Interactive Menu
        {
            Console.Clear();
            Console.WriteLine("Zone 1 selected");
            Console.WriteLine("---Price/max.Hour---");
            Console.WriteLine("1.15€/h - max.45 min");

            //Ask the user for a Car Plate
            Console.WriteLine("Insert your Plate:");
            string carPlateZone1 = Console.ReadLine();


            CarPlate.listaZona1.Add(carPlateZone1); //ALTERAR!!
            
            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Cheak the time
            double total; //Variable to accept the same amount of cash inserted in the MoneyMachine method
            ParkPayment paidpark = new ParkPayment();


            do
            {
                Console.WriteLine("\nInsert your cash:");
                total = moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));

                //FALTA!!!!!!!!
                //definir os dias em que pode usar o park, DateTime... , colocar de 7 em 7 dias seria é domingo. 
                //Console.WriteLine("====!!===== " + total);
                Console.WriteLine("\nInsert your cash:");

                if (DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.Hour > 9 && DateTime.Now.Hour < 20)
                    {
                        if (paidpark.PayInZone1(total) <= 45)
                        {
                            Console.WriteLine(DateTime.Now);
                            Console.WriteLine("You have now paid for {0} minutes.", Math.Round(paidpark.PayInZone1(total)));  
                            Console.WriteLine("You can be parked until: {0}", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone1(total))));
                            Console.WriteLine("Press zero(0) to stop counting.");
                        }
                        else
                        {
                            Console.WriteLine("You can only be parked for 45 min máx! Don´t print the ticket to receive a refund.");
                            stop = false;
                        }
                    }
                    else
                    {
                        if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 14) 
                        {
                            if (paidpark.PayInZone1(total) <= 45)
                            {
                                Console.WriteLine(DateTime.Now);
                                Console.WriteLine("You have now paid for {0} minutes.", Math.Round(paidpark.PayInZone1(total)));
                                Console.WriteLine("You can be parked until: {0}", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone1(total))));
                                Console.WriteLine("Press zero(0) to stop counting.");
                            }
                            else
                            {
                                Console.WriteLine("You can only be parked for 45 min máx! Don´t print the ticket to receive a refund.");
                                stop = false;
                            }
                        }
                        else 
                        {
                            Console.WriteLine("You can Park for Free before 9 and after 20h. You will be refunded!");
                            stop = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You can Park for Free on Sundays.\nIf you inserted money you will be refounded!");
                    stop = false;
                }
                //Console.WriteLine("You can be parked for {0} time.",Math.Round(paidpark.PayInZone1(total))); //Returns the aproximated time for the amount of inserted coins
                if (moneyMachine._cash == 0) { stop = false;}
            } while (stop == true);

            //=============== When the user wants to Print a ticket =============== 
            Console.WriteLine("Do you want to print your ticket? \n yes(y) or no(n)");
            string ticket = Console.ReadLine(); //user input to navigate through the Menu
            if (ticket == "y")
            {
                Console.Clear();
                Console.WriteLine("ticket");
                Console.WriteLine("----zone 1----");
                Console.WriteLine(DateTime.Now);
                //Console.WriteLine("array novo, devia dar matricula -> " + CarPlate._plateArrayZone1.Count());
                //Console.WriteLine("array novo, devia dar matricula -> " + CarPlate.listaZona1.Count());
                //Console.WriteLine("array novo, devia dar matricula -> " + CarPlate.listaZona1[0]);
                Console.WriteLine("Car Plate: {0}", carPlateZone1);
                Console.WriteLine("You can be parked until: {0}", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone1(total))));
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


            CarPlate.listaZona2.Add(carPlateZone2); //ALTERAR!!

            //Do the cicle of adding coin into the machine by invoking the MoneyMachine Class
            bool stop = true;
            MoneyMachine moneyMachine = new MoneyMachine();

            //Cheak the time
            double total; //Variable to accept the same amount of cash inserted in the MoneyMachine method
            ParkPayment paidpark = new ParkPayment();

            do
            {
                Console.WriteLine("\nInsert your cash:");
                total = moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));


                if (DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.Hour > 9 && DateTime.Now.Hour < 20)
                    {
                        if (paidpark.PayInZone2(total) <= 120)
                        {
                            Console.WriteLine(DateTime.Now);
                            Console.WriteLine("You have now paid for {0} minutes.", Math.Round(paidpark.PayInZone2(total)));
                            Console.WriteLine("You can be parked until: {0}", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone2(total))));
                            Console.WriteLine("Press zero(0) to stop counting.");
                        }
                        else
                        {
                            Console.WriteLine("You can only be parked for 2 hours máx! Don´t print the ticket to receive a refund.");
                            stop = false;
                        }
                    }
                    else
                    {
                        if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 14)
                        {
                            if (paidpark.PayInZone2(total) <= 120)
                            {
                                Console.WriteLine(DateTime.Now);
                                Console.WriteLine("You have now paid for {0} minutes.", Math.Round(paidpark.PayInZone2(total)));
                                Console.WriteLine("You can be parked until: {0}", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone2(total))));
                                Console.WriteLine("Press zero(0) to stop counting.");
                            }
                            else
                            {
                                Console.WriteLine("You can only be parked for 2 hours máx! Don´t print the ticket to receive a refund.");
                                stop = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You can Park for Free before 9 and after 20h. You will be refunded!");
                            stop = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You can Park for Free on Sundays.\nIf you inserted money you will be refounded!");
                    stop = false;
                }

                /*moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("You can be parked for {0} time.", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone2(total))));
                Console.WriteLine("Press zero(0) if you want to stop counting.");*/
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
                Console.WriteLine("\nYou can be parked for {0} time.", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone2(total))));
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

            //TimeSpan to change date based on paid hours
            //https://docs.microsoft.com/en-us/dotnet/api/system.timespan?view=net-6.0
            //https://docs.microsoft.com/en-us/dotnet/api/system.timespan.days?view=net-6.0
            //https://docs.microsoft.com/en-us/dotnet/api/system.datetime.subtract?view=net-6.0

            int days = 0;
            int hour = 0;
            int minute = 0;
            int second = 0;
            TimeSpan timeSpan;

            int PaidTotalTime;
            object dataNow;
            do
            {
                Console.WriteLine("\nInsert your cash:");
                total = moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));
                PaidTotalTime = Convert.ToInt32(Math.Round(paidpark.PayInZone3(total)));
               

                //======== Calculate time ======
                /*if (paidpark.PayInZone3(total) < 60)
                {
                    minute = PaidTotalTime;
                }
                if (paidpark.PayInZone3(total) == 60)
                {
                    hour += 1;

                    if(hour > 0 && PaidTotalTime < 60) 
                    {
                        
                        minute = PaidTotalTime - 60;
                    }
                    else 
                    {
                        hour += 1;
                        minute = PaidTotalTime - 60;
                    }
                }
                if (paidpark.PayInZone3(total) >= 1440) //24 (hours in a day) x 60 (minutes in an hour) = 1440 minutes.
                {
                    days += 1;
                    PaidTotalTime = PaidTotalTime - 1440;
                }
                timeSpan = new TimeSpan(days, hour, minute, second);*/


                while (PaidTotalTime > 0) {

                    if (PaidTotalTime >= 1440) //24 (hours in a day) x 60 (minutes in an hour) = 1440 minutes.
                    {
                        days += 1;
                        PaidTotalTime = PaidTotalTime - 1440;
                    }
                    else if (PaidTotalTime >= 60)
                    {
                        hour += 1;
                        PaidTotalTime = PaidTotalTime - 60;
                    }
                    if (PaidTotalTime < 60)
                    {
                        minute = PaidTotalTime;
                        break;
                    }

                }
                timeSpan = new TimeSpan(days, hour, minute, second);

                /*if (DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
                {
                    if (DateTime.Now.DayOfWeek != DayOfWeek.Saturday ) //Week schedule
                    {
                        Console.WriteLine(DateTime.Now);
                        Console.WriteLine("You have now paid for {0} minutes.", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone3(total))));
                        Console.WriteLine("You can be parked until: {0}", DateTime.Now.Add(timeSpan));
                        Console.WriteLine("Press zero(0) to stop counting.");

                    }
                    else
                    {
                        if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 14) //Saturdays Open Hours
                        {
                            Console.WriteLine(DateTime.Now);
                            Console.WriteLine("You have now paid for {0} minutes.", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone3(total))));
                            Console.WriteLine("You can be parked until: {0}", DateTime.Now.Add(timeSpan));
                            Console.WriteLine("Press zero(0) to stop counting.");

                        }
                        else
                        {
                            Console.WriteLine("You can Park for Free before 9 and after 20h. You will be refunded!"); //the client can´t be refunded
                            stop = false;
                        }
                    }
                }
                else //domingo
                {
                    
                    

                    Console.WriteLine(DateTime.Now);
                    Console.WriteLine("You have now paid for {0} minutes.", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone3(total))));
                    Console.WriteLine("You can be parked until: {0}", DateTime.Now.Add(timeSpan));
                    Console.WriteLine("Press zero(0) to stop counting.");
                }*/

                /*
                //TimeSpan timesub = new TimeSpan(0, 13, 0, 0);
                //dataNow = DateTime.Now - DateTime.Now.Subtract(0, 0, DayOfWeek.Monday, DateTime.Now.AddHours(13), 0, 0);
                //dataNow = ObjectMerger.MergeObjects(dataNow, DateTime.Now.Add(timeSpan));
                //dataNow = DateTime.Now.Add(timeSpan);


                //TimeSpan timeSpan = new TimeSpan(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, Math.Abs(DateTime.Now.Hour - 9), 0, 0)
                DateTime diaSeguinte = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(1), DateTime.Now.Hour + Math.Abs(DateTime.Now.Hour - 13), DateTime.Now.Minute + Math.Abs(DateTime.Now.Minute - 0), 0);
                DateTime Realtime = DateTime.Now - DateTime.Now.Subtract(diaSeguinte);

                TimeSpan span = (TimeZoneInfo.ConvertTimeToUtc(Realtime) - diaSeguinte); //+ timeSpan;
                DateTime Nova = DateTime.Now.Add(span);
               // Nova = Nova.Add(timeSpan);

                //span = TimeZoneInfo.ConvertTimeToUtc(Realtime) - diaSeguinte;
                //unixTimestamp = span.TotalHours;



                Console.WriteLine("===!!=!=!=!=!=!=!" + Nova);*/

                //Se o dateTime.Now = sabado dps das 14h, ele salta dois dias. Depois adiciona o tempo pago restante
                //Se o dateTime.Now = domingo a qualquer hora entre as 00h (sabado) e as 24h (domingo)
                //https://iditect.com/guide/csharp/csharp_howto_convert_datetime.html
                //https://stackoverflow.com/questions/8702603/merging-two-objects-in-c-sharp
               




                //ALERT DONT DELETE!!!
                /*  Console.WriteLine(DateTime.Now);
                  Console.WriteLine("You have now paid for {0} minutes.", Math.Round(paidpark.PayInZone3(total))); //===!!!=!=!=!
                  Console.WriteLine("You can be parked until: {0}", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone3(total))));//DateTime.Now.Add(timeSpan));
                  Console.WriteLine("Press zero(0) to stop counting.");*/



                /*moneyMachine.insertingCash(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("You can be parked for {0} time.", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone3(total))));
                Console.WriteLine("Press zero(0) if you want to stop counting.");*/
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
                Console.WriteLine("\nYou can be parked for {0} time.", DateTime.Now.AddMinutes(Math.Round(paidpark.PayInZone3(total))));
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

        //============================================= Zones for the Admin =============================================//
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
