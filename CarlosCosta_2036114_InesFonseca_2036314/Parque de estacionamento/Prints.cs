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
            Console.WriteLine(" -----------------------------------------------------------------------");
            Console.WriteLine("|                    Welcome to CarSlot Parking Agency!                 |");
            Console.WriteLine("|-----------------------------------------------------------------------|");
            Console.WriteLine("|___________________________"+(DateTime.Now)+"_________________________|"); //display date and time
            Console.WriteLine("|                                                                       |");
            Console.WriteLine("|  >Navigate through the Menus by pressing the representative number!<  |"); ///n
            Console.WriteLine("|                                                                       |");
            Console.WriteLine("|                            _Client Menu [1]_                          |");
            Console.WriteLine("|                            _Admin Menu [2]_                           |");
            Console.WriteLine("|                                                                       |");
            Console.WriteLine("|_____________________________Close Menu [0]____________________________|");
        }

        public static void PrintClientMenu()//Print for the Main Menu
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

        public static void PrintAdminMenu()//Print for the Main Menu
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
            //Console.WriteLine();//Total Money from the 3 Zones ============FAZER!!!!!!!!!!!!!
            Console.WriteLine("|                                         | ");
            Console.WriteLine("|__________Back to main menu [4]__________|");
            Console.WriteLine("|_____________Stand By UI [0]_____________|");
        }

        //Print report Zones for Admin
        public static void ReportZone1() //Zone1 
        {
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|       >Report of the day: Zone1<        |");
            Console.WriteLine("|___________" + (DateTime.Now) + "___________|");
            Console.WriteLine("|                                         |");
            //Console.WriteLine(av1.AvailableSlotsZone1(0, 0) - 1);//Available Slots
            Console.WriteLine("   >>>There are {0} available slots.", CarPlate.carSlotsZone1 - CarPlate.listaZona1.Count());//Available Slots (50)
            //Console.WriteLine(car1.occupiedSlotsZone1("00") - 1);//Occupied Slots
            Console.WriteLine("   >>>There are {0} ocupied slots", CarPlate.listaZona1.Count());//Occupied Slots
            Console.WriteLine(); //Cars that exceed the time allowed, HOW TO COUNT?
            Console.WriteLine("|_____________End of Report_______________| ");
            
        }

        public static void ReportZone2() //Zone2
        {
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|       >Report of the day: Zone2<        |");
            Console.WriteLine("|___________" + (DateTime.Now) + "___________|");
            Console.WriteLine("|                                         |");
            //Console.WriteLine(av1.AvailableSlotsZone1(0, 0) - 1);//Available Slots
            Console.WriteLine("   >>>There are {0} available slots.", CarPlate.carSlotsZone2 - CarPlate.listaZona2.Count());//Available Slots (50)
            //Console.WriteLine(car1.occupiedSlotsZone1("00") - 1);//Occupied Slots
            Console.WriteLine("   >>>There are {0} ocupied slots", CarPlate.listaZona2.Count());//Occupied Slots
            Console.WriteLine(); //Cars that exceed the time allowed, HOW TO COUNT?
            Console.WriteLine("|_____________End of Report_______________| ");
        }

        public static void ReportZone3() //Zone3
        {
            Console.WriteLine(" _________________________________________");
            Console.WriteLine("|       >Report of the day: Zone3<        |");
            Console.WriteLine("|___________" + (DateTime.Now) + "___________|");
            Console.WriteLine("|                                         |");
            //Console.WriteLine(av1.AvailableSlotsZone1(0, 0) - 1);//Available Slots
            Console.WriteLine("   >>>There are {0} available slots.", CarPlate.carSlotsZone3 - CarPlate.listaZona3.Count());//Available Slots (50)
            //Console.WriteLine(car1.occupiedSlotsZone1("00") - 1);//Occupied Slots
            Console.WriteLine("   >>>There are {0} ocupied slots", CarPlate.listaZona3.Count());//Occupied Slots
            Console.WriteLine(); //Cars that exceed the time allowed, HOW TO COUNT?
            Console.WriteLine("|_____________End of Report_______________| ");
        }
    }
}