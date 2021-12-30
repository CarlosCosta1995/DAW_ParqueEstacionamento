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

        public static void PrintMainMenu()//Print for the Main Menu
        {
            Console.Clear();
            Console.WriteLine("Welcome to CarSlot Parking Agency!");
            Console.WriteLine(DateTime.Now); //display date and time
            Console.WriteLine("Navigate through the Menus by presseing the representative number!");
            Console.WriteLine("Client Menu [1]");
            Console.WriteLine("Admin Menu [2]");
            Console.WriteLine("To close Menu [0]");
        }

        public static void PrintClientMenu()//Print for the Main Menu
        {
            Console.Clear();
            Console.WriteLine("Client Menu selected!");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("     >Schedule<    ");
            Console.WriteLine("----working days----");
            Console.WriteLine(" 9:00 am - 8:00 pm ");
            Console.WriteLine("-----saturdays------");
            Console.WriteLine(" 9:00 am - 2:00 pm ");
            Console.WriteLine(">Choose a zone number<");
            Console.WriteLine("_zone [1]");
            Console.WriteLine("_zone [2]");
            Console.WriteLine("_zone [3]");
            Console.WriteLine("Back to main menu [4]");
        }

        public static void PrintAdminMenu()//Print for the Main Menu
        {
            Console.Clear();
            Console.WriteLine("Admin Menu selected!");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(" >Report of the day< ");
            Console.WriteLine(">Choose a zone number<");
            Console.WriteLine("Report zone [1]");
            Console.WriteLine("Report zone [2]");
            Console.WriteLine("Report zone [3]");
            Console.WriteLine();//Total Money from the 3 Zones
            Console.WriteLine("Back to main menu [4]");
            Console.WriteLine("Stand By UI [0]");
        }

        //Print report Zones for Admin
        public static void ReportZone1() //Zone1 
        {
           // CarPlate car1 = new CarPlate("00", "00", "00");
           // ZoneAvailability av1 = new ZoneAvailability(0, 0, 0);

            Console.WriteLine(" >Report of the day: Zone1< ");
            Console.WriteLine(DateTime.Now);
            //Console.WriteLine(av1.AvailableSlotsZone1(0, 0) - 1);//Available Slots
            //Console.WriteLine(car1.occupiedSlotsZone1("00") - 1);//Occupied Slots
            Console.WriteLine(); //Cars that exceed the time allowed
            Console.WriteLine(" >End of Report< ");
            
        }

        public static void ReportZone2() //Zone2
        {
            Console.WriteLine(" >Report of the day: Zone2< ");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(); //Available and Occupied Slots
            Console.WriteLine(); //Cars that exceed the time allowed
            Console.WriteLine(" >End of Report< ");
        }

        public static void ReportZone3() //Zone3
        {
            Console.WriteLine(" >Report of the day: Zone3< ");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(); //Available and Occupied Slots
            Console.WriteLine(); //Cars that exceed the time allowed
            Console.WriteLine(" >End of Report< ");
        }
    }
}