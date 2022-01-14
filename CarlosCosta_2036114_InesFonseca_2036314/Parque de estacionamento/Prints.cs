using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Menus;
using Functionalities;

namespace ConsolePrint
{
    public class ConsolePrints
    {
        //All the console write will be grouped in this Print class

        //========================= Print for the Main Menu ========================//

        public static void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine(" -----------------------------------------------------------------------");
            Console.WriteLine("|                    Welcome to CarSlot Parking Agency!                 |");
            Console.WriteLine("|-----------------------------------------------------------------------|");
            Console.WriteLine("|___________________________"+(DateTime.Now)+"_________________________|"); //display date and time
            Console.WriteLine("|                                                                       |");
            Console.WriteLine("|  >Navigate through the Menus by pressing the representative number!<  |"); 
            Console.WriteLine("|                                                                       |");
            Console.WriteLine("|                            _Client Menu [1]_                          |");
            Console.WriteLine("|                            _Admin Menu [2]_                           |");
            Console.WriteLine("|                                                                       |");
            Console.WriteLine("|_____________________________Close Menu [0]____________________________|");
        }

        //========================= Print for the Client Menu ========================//
        public static void PrintClientMenu()
        {
            Console.Clear();
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|          Client Menu selected!          |");
            Console.WriteLine("|                                         |");
            Console.WriteLine("|___________" + (DateTime.Now) + "___________|");
            Console.WriteLine("|                                         | ");
            Console.WriteLine("|               >Schedule<                |");
            Console.WriteLine("|--------------working days---------------|");
            Console.WriteLine("|            9:00 am - 8:00 pm            |");
            Console.WriteLine("|----------------saturdays----------------|");
            Console.WriteLine("|            9:00 am - 2:00 pm            |");
            Console.WriteLine("|                                         | ");
            Console.WriteLine("|         >Choose a zone number<          |");
            Console.WriteLine("|              _zone [1]_                 |");
            Console.WriteLine("|              _zone [2]_                 |");
            Console.WriteLine("|              _zone [3]_                 |");
            Console.WriteLine("|                                         | ");
            Console.WriteLine("|__________Back to main menu [4]__________|");
        }
        //========================= Print for the Zone1 Menu ========================//
        public static void PrintZone1()
        {
            Console.Clear();
            Console.WriteLine(" ___________________________________________________");
            Console.WriteLine("|                  Zone 1 selected                  |");
            Console.WriteLine("|                " + DateTime.Now + "                |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|------------------Price/max.Hour-------------------|");
            Console.WriteLine("|                1.15€/h  max.45 min                |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|________________>Insert your Plate:<_______________|");
        }

        //========================= Print for the Zone2 Menu ========================//
        public static void PrintZone2()
        {
            Console.Clear();
            Console.WriteLine(" ___________________________________________________");
            Console.WriteLine("|                  Zone 2 selected                  |");
            Console.WriteLine("|                " + DateTime.Now + "                |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|------------------Price/max.Hour-------------------|");
            Console.WriteLine("|                1€/h  max.2 hours                  |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|________________>Insert your Plate:<_______________|");
        }

        //========================= Print for the Zone3 Menu ========================//
        public static void PrintZone3()
        {
            Console.Clear();
            Console.WriteLine(" ___________________________________________________");
            Console.WriteLine("|                  Zone 3 selected                  |");
            Console.WriteLine("|                " + DateTime.Now + "                |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|------------------Price/max.Hour-------------------|");
            Console.WriteLine("|               0.62€/h - no max.hours              |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("|________________>Insert your Plate:<_______________|");
        }

        //========================= Print Ticket commum in all Zones ========================//
        public static void PrintTicket()
        {
            Console.WriteLine("\n___________________________________________________ ");
            Console.WriteLine("|         Do you want to print your ticket?         |");
            Console.WriteLine("|__________________yes(y) or no(n)__________________|");
        }


        //========================= Print for the Admin Main Menu ========================//
        public static void PrintAdminMenu()
        {
            
            Console.Clear();
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|           Admin Menu selected!          |");
            Console.WriteLine("|                                         |");
            Console.WriteLine("|___________" + (DateTime.Now) + "___________|");
            Console.WriteLine("|                                         | ");
            Console.WriteLine("|           >Report of the day<           |");
            Console.WriteLine("|                                         | ");
            Console.WriteLine("|          >Choose a zone number<         |");
            Console.WriteLine("|            _Report zone [1]_            |");
            Console.WriteLine("|            _Report zone [2]_            |");
            Console.WriteLine("|            _Report zone [3]_            |");
            Console.WriteLine("|                                         | ");
            Console.WriteLine("  >>>Total money of the day is:{0}         ", MoneyMachine._machineTotalAmount);
            Console.WriteLine("  >>>Total of slots occupied:{0}         ", CarPlate.TotalCarsInZones);
            Console.WriteLine("  >>>Total of slots available:{0}         ", ZoneAvailability.TotalAvailableCarSlotsInZones);
            Console.WriteLine("|                                         | ");
            Console.WriteLine("|__________Back to main menu [4]__________|");
            Console.WriteLine("|_____________Stand By UI [0]_____________|");
        }

        //========================= Print for the Admin Report Zone1 Menu ========================//
        public static void ReportZone1() 
        {
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|       >Report of the day: Zone1<        |");
            Console.WriteLine("|___________" + (DateTime.Now) + "___________|");
            Console.WriteLine("|                                         |");
            //Console.WriteLine(av1.AvailableSlotsZone1(0, 0) - 1);//Available Slots
            Console.WriteLine("   >>>There are {0} available slots.", ZoneAvailability.AvailableCarSlotsInZone1);//Available Slots (50)
            //Console.WriteLine(car1.occupiedSlotsZone1("00") - 1);//Occupied Slots
            Console.WriteLine("   >>>There are {0} ocupied slots", CarPlate.CarsInZone1);//Occupied Slots
            Console.WriteLine(); //Cars that exceed the time allowed, HOW TO COUNT?
            Console.WriteLine("|_____________End of Report_______________| ");
            Console.WriteLine("|________Back to Admin menu [0]___________|");
            Console.WriteLine("|________Back to Main menu [1]____________|");
            Console.WriteLine("|________Back to standby menu [2]_________|");

        }

        //========================= Print for the Admin Report Zone2 Menu ========================//
        public static void ReportZone2() 
        {
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|       >Report of the day: Zone2<        |");
            Console.WriteLine("|___________" + (DateTime.Now) + "___________|");
            Console.WriteLine("|                                         |");
            //Console.WriteLine(av1.AvailableSlotsZone1(0, 0) - 1);//Available Slots
            Console.WriteLine("   >>>There are {0} available slots.", ZoneAvailability.AvailableCarSlotsInZone2);//Available Slots (50)
            //Console.WriteLine(car1.occupiedSlotsZone1("00") - 1);//Occupied Slots
            Console.WriteLine("   >>>There are {0} ocupied slots", CarPlate.CarsInZone2);//Occupied Slots
            Console.WriteLine(); //Cars that exceed the time allowed, HOW TO COUNT?
            Console.WriteLine("|_____________End of Report_______________| ");
            Console.WriteLine("|________Back to Admin menu [0]___________|");
            Console.WriteLine("|________Back to Main menu [1]____________|");
            Console.WriteLine("|________Back to standby menu [2]_________|");
        }

        //========================= Print for the Admin Report Zone3 Menu ========================//
        public static void ReportZone3() 
        {
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|       >Report of the day: Zone3<        |");
            Console.WriteLine("|___________" + (DateTime.Now) + "___________|");
            Console.WriteLine("|                                         |");
            //Console.WriteLine(av1.AvailableSlotsZone1(0, 0) - 1);//Available Slots
            Console.WriteLine("   >>>There are {0} available slots.", ZoneAvailability.AvailableCarSlotsInZone3);//Available Slots (50)
            //Console.WriteLine(car1.occupiedSlotsZone1("00") - 1);//Occupied Slots
            Console.WriteLine("   >>>There are {0} ocupied slots", CarPlate.CarsInZone3);//Occupied Slots
            Console.WriteLine(); //Cars that exceed the time allowed, HOW TO COUNT?
            Console.WriteLine("|_____________End of Report_______________| ");
            Console.WriteLine("|________Back to Admin menu [0]___________|");
            Console.WriteLine("|________Back to Main menu [1]____________|");
            Console.WriteLine("|________Back to standby menu [2]_________|");
        }
    }
}