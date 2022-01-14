using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Menus;
using ConsolePrint;

namespace Functionalities

{
    //============================== Class CarPlate ==============================//
    //Method that receives the car plates inserted by the user
    //Stores into the Arrays
    //Outputs a list of plates and a quantity of plate.
    //ref. https://docs.microsoft.com/en-us/learn/modules/csharp-arrays-operations/3-exercise-clear-resize#code-try-9
    //ref. https://www.javatpoint.com/program-to-count-the-total-number-of-characters-in-a-string
    public class CarPlate

    {
        //Creating an Array to store the plates.
        public static List<string> listaZona1 = new List<string> { };
        public static List<string> listaZona2 = new List<string> { };
        public static List<string> listaZona3 = new List<string> { };

        //Atribute carsInZone, the value of the amount of cars (listaZona1.Count()) from the Zones List
        private static int carsInZone1 = 0;
        private static int carsInZone2 = 0;
        private static int carsInZone3 = 0;

        //Define and atribute variables for each zone
        public static int carSlotsZone1 = 50;
        public static int carSlotsZone2 = 100;
        public static int carSlotsZone3 = 70;

        //=============== Stores the variable of occupied cars ===============//
        //Cars in Zone1
        public static int CarsInZone1 
        {
            get { return listaZona1.Count(); }
            set { carsInZone1 = value; }
        }

        //Cars in Zone1
        public static int CarsInZone2
        {
            get { return listaZona2.Count(); }
            set { carsInZone2 = value; }
        }

        //Cars in Zone1
        public static int CarsInZone3
        {
            get { return listaZona3.Count(); }
            set { carsInZone3 = value; }
        }

        //Total amount of Cars in all Zones
        public static int TotalCarsInZones 
        {
            get { return listaZona1.Count() + listaZona2.Count() + listaZona3.Count(); }
            set { TotalCarsInZones = value; }
        }
        //THINGS WE TRIED 

        /* string[] pallets = { "B14", "A11", "B12", "A13" };
           Console.WriteLine("");

           Array.Clear(pallets, 0, 2);
           Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
           foreach (var pallet in pallets)
           {
           Console.WriteLine($"-- {pallet}");
           } */
        //we can use this code to clear the car plates when the park is full, ref.:https://docs.microsoft.com/en-us/learn/modules/csharp-arrays-operations/3-exercise-clear-resize#code-try-9



        //Store and Counts Array elements for Zone1
        /* public void occupiedSlotsZone1() //Counts how many plates are in the array and removes one if reaches the zone full capacity for Zone1.
         {
             

             if (carsInZone1 < ZoneAvailability.carSlotsZone1) //how to do a ramdom clear
             {
                 carsInZone1 = carsInZone1 + 1;
             }
             else
             {
                 carsInZone1 = carsInZone1 - 1;
             }
             CarsInZone1 = carsInZone1;
         }

         //Store and Counts Array elements for Zone2
         public void occupiedSlotsZone2() //Counts how many plates are in the array and removes one if reaches the zone full capacity for Zone2.
         {
             if (carsInZone2< ZoneAvailability.carSlotsZone2)
             {
                 carsInZone2 = carsInZone2 + 1;
             }
             else
             {
                 carsInZone2 = carsInZone2 - 1;
             }
             CarsInZone2 = carsInZone2;
         }

         //Store and Counts Array elements for Zone3
         public void occupiedSlotsZone3() //Counts how many plates are in the array and removes one if reaches the zone full capacity for Zone3.
         {

             if (carsInZone2 < ZoneAvailability.carSlotsZone3)
             {
                 carsInZone3 = carsInZone3 + 1;
             }
             else
             {
                 carsInZone3 = carsInZone3 - 1;
             }
             CarsInZone3 = carsInZone3;
         }*/
    }
    //============================== Class ZoneAvailability ==============================//
    //Method that receives the arrays from CarPlate Method
    //Calculates the available car slots (Quantity of zone slots - occupied slots in the zone given by the CarsInZoneX)
    //Outputs the Available slots
    
    public class ZoneAvailability
    {
        //Method that receives the arrays from CarPlate Method
        //Calculates the available car slots (Quantity of zone slots - occupied slots in the zone given by the CarsInZoneX)
        //Outputs the Available slots

        //Define and atribute variables for each zone
        public static int carSlotsZone1 = 50;
        public static int carSlotsZone2 = 100;
        public static int carSlotsZone3 = 70;

        //Quantity of cars in the zone
        public static int _numOccupiedCarInZone1;
        public static int _numOccupiedCarInZone2;
        public static int _numOccupiedCarInZone3;

        //=============== Stores the variable for available car slots ===============//
        //Available car slots in Zone1
        public static int AvailableCarSlotsInZone1
        {
            get { return carSlotsZone1 - CarPlate.CarsInZone1; }
            set { AvailableCarSlotsInZone1 = value; }
        }

        //Available car slots in Zone1
        public static int AvailableCarSlotsInZone2
        {
            get { return carSlotsZone2 - CarPlate.CarsInZone2; }
            set { AvailableCarSlotsInZone2 = value; }
        }

        //Available car slots in Zone1
        public static int AvailableCarSlotsInZone3
        {
            get { return carSlotsZone3 - CarPlate.CarsInZone3; }
            set { AvailableCarSlotsInZone3 = value; }
        }

        //Available car slots for all Zones
        public static int TotalAvailableCarSlotsInZones
        {
            get { return AvailableCarSlotsInZone1 + AvailableCarSlotsInZone2 + AvailableCarSlotsInZone3; }
            set { TotalAvailableCarSlotsInZones = value; }
        } 

    }

    public partial class MoneyMachine
    {
        //Receives the cash from the user input
        //Pre-define Money accepted by the Machine
        //Compares the User input with the accept Money coins
        //Make the addition of cash inserted by the user
        //Calculates all Money inserted in the machine for all Zones
        //Reset the cash inserted
        //Refounds the money inserted if the user ask for it
        //https://stackoverflow.com/questions/51007525/c-sharp-displaying-total-amount-of-money-in-a-class-instance
        //https://youtu.be/33czhZrH51s
        //******************************************************//

        //Varible to receive the cash
        public double _cash;

        //Varible to continue add received cash
        public double _addCash { get; set; }

        //Varible to continue add received cash provided by all Zones
        public static double _machineTotalAmount { get; set; }

        //Acceptance Money coins for the machine
        //Don't accept coins out the array, letters or negative numbers written by the user
        public double[] acceptedCash = { 0.00, 0.01, 0.02, 0.05, 0.10, 0.20, 0.50, 1.00, 2.00, 5.00, 10.00, 20.00 };


        //=============== Asking the user if he wants to Print a ticket ===============//
        //Asks the user to insert an amount of money
        public double insertingCash(double amount)
        {
            //Verify if the amount inserted is contained in the AcceptedCash Array
            //https://stackoverflow.com/questions/13257458/check-if-a-value-is-in-an-array-c
            //https://stackoverflow.com/questions/61448526/java-checking-if-a-variable-is-equal-to-any-of-the-array-elements
            if (acceptedCash.Contains(amount))
            {
                Console.WriteLine("\n>>>You inserted {0} €\n", amount);
                _cash = amount;
            }
            else
            {
                Console.WriteLine("\n>>>You inserted {0} €\n", amount);
                Console.WriteLine("   !!! You money is not accepted by the machine !!!");
                Console.WriteLine("   The coins accepted are:\n   {0.00, 0.01, 0.02, 0.05, 0.10, 0.20, 0.50} cents \n   and {1.00, 2.00, 5.00, 10.00, 20.00} euros. \n");
            }

            //calculates the addiion of the cash
            _addCash += _cash;
            machineTotalMoney(_cash); //To _addCash to the total money inside the machine by calling the method
            return _addCash;
        }

        public double machineTotalMoney(double _addCash) //Calculates the total of cash inside the Machine
        {
            _machineTotalAmount += _addCash;
            return _machineTotalAmount;
        }

        public void printTotalMoney() 
        {
            Console.WriteLine("The total amount from all zones is" +_machineTotalAmount);
        }

        public void refundCash() //Gives the feeback of the amount inserted, reset the cash and subtracts the amount returned.
        {
            Console.WriteLine("               >>>Refunding {0} euros      ", _addCash);
            if (_machineTotalAmount != 0)
            {
                _machineTotalAmount -= _addCash;
                _cash = 0;
                _addCash = 0;
            }
            else
            {
                _machineTotalAmount = 0;
            }
        }
    }
    
    /* int[] inventory = { 200, 450, 700, 175, 250 };
       int sum = 0;
       int bin = 0;
       foreach (int items in inventory)
       {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
       }
       Console.WriteLine($"We have {sum} items in inventory.");*/
    //this code can be used to calculate the total amount of money, ref.:https://docs.microsoft.com/en-us/learn/modules/csharp-arrays/3-exercise-foreach#code-try-13

    public class ParkPayment
    {
        //Zone Payments time rules

        //============================== Zone1: 1.15 euros/h => max 45min =================================
        public double _timePerHourZone1 = ((1.15 * 45) / 60);//Convert price per hour to price per minutes
        public double _maxMinutesInZone1 = 45;// Time already in minutes
        public double _timePaidForZone1;//Stores the value Calculated by the function PayInZone1()
        public double PayInZone1(double _addCash) //Calculating the payment for Zone1
        {
            //Verificar o dia da semana, e horario de estacionamento DONE!
            //Tempo maximo limite dos 45 DONE!
            //Somar os minutos do resultado com a data e hora actual. DONE!
            //[extra]o restante addicionar ao dia seguinte ZONA3


            //Console.WriteLine("POOAWKAOw" + _addCash);
            _timePaidForZone1 = (_addCash * _maxMinutesInZone1) / _timePerHourZone1;
            //Console.WriteLine("Tempo !!!#!" + _timePaidForZone1);
            return _timePaidForZone1;
            
        }


        //============================== Zone2: 1.00 euros/h => max 2h =================================
        public double _timePerHourZone2 = ((1.00 * 120) / 60);//Convert price per hour to price per minutes
        public double _maxMinutesInZone2 = 120;//Convert time in minutes (120 min = 2h * 60min)
        public double _timePaidForZone2; //Stores the value Calculated by the function PayInZone2()
        public double PayInZone2(double _addCash) //Calculating the payment for Zone2
        {
            _timePaidForZone2 = (_addCash * _maxMinutesInZone2) / _timePerHourZone2;
            //Console.WriteLine("Tempo !!!#!" + _timePaidForZone2);
            return _timePaidForZone2;
        }


        //============================== Zone3: 0.62 euros/h => unlimited time =================================
        public double _timePerHourZone3 = ((0.62 * 60) / 60);//Convert price per hour to price per minutes
        public double _maxMinutesInZone3 = 60;//Convert time in minutes (60 min = 1h)
        public double _timePaidForZone3; //Stores the value Calculated by the function PayInZone3()

        public double PayInZone3(double _addCash) //Calculating the payment for Zone3
        {
            _timePaidForZone3 = (_addCash * _maxMinutesInZone3) / _timePerHourZone3; // (20.00 * 0.62) / 60;
            //Console.WriteLine("Tempo !!!#!" + _timePaidForZone3);
            return _timePaidForZone3;
        }
    }
}
