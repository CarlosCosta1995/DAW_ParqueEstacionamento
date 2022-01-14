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

    //============================== Class MoneyMachine ==============================//
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
                      
            _timePaidForZone1 = (_addCash * _maxMinutesInZone1) / _timePerHourZone1;
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
    public class Schedule
    {
        
        private static List<int> _dayOfWeek = new List<int> { 0, 1, 2, 3, 4, 5, 6 };

        //private double _timePaid;
        private double _days;
        private double _hour;
        private double _minute;
        private double _second = 0;
        private double timeConvertMinutes;
       
        public Schedule()
        {
            this._days = new double();
            this._hour = new double();
            this._minute = new double();
            this._second = new double();
        }

        public double Day
        {
            get { return _days; }
            set { _days = value; }
        }

        public double Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        public double Minute
        {
            get { return _minute; }
            set { _minute = value; }
        }

        public double Second
        {
            get { return _second; }
            set { _second = value; }
        }


        public void CalculateTime(double _timePaid)
        {
            for (int i = 0; i < _timePaid; i++)
            {
                //Console.WriteLine("TimePaid" + _timePaid);
                if (_timePaid >= 1440) //24 (hours in a day) x 60 (minutes in an hour) = 1440 minutes.
                {
                    _days += 1;
                    _timePaid = _timePaid - 1440;
                }
                /*else if (_timePaid >= 60)
                {
                    _hour += 1;
                    _timePaid = _timePaid - 60;
                }
                else if (_timePaid < 60)
                {
                    _minute = _timePaid;
                }*/
            }

           var time = TimeSpan.FromMinutes(_timePaid);
            _hour = (int)time.TotalHours;
            _minute = time.Minutes;
        }

        public DateTime ScheduleForZone(DateTime _dateForTimeCount, double day, double hour, double minute)
        {
            int _todayDay = 0;
            int _todayHour = 0;
            int _todayMinute = 0;

            //Store the result in a TimeSpan
            TimeSpan tSpan;
            DateTime resultado = _dateForTimeCount;

            while (minute > 0)
            {
                if (minute > 59)
                {
                    _todayHour += 1;
                    minute -= 59;
                }
                else
                {
                    if ((int)_dateForTimeCount.DayOfWeek != 0 && _dateForTimeCount.Hour >= 9 && _dateForTimeCount.Hour < 20)
                    {
                        _todayMinute += 1;
                    }
                    else if ((int)_dateForTimeCount.DayOfWeek == 6 && _dateForTimeCount.Hour >= 9 && _dateForTimeCount.Hour < 14)
                    {
                        _todayMinute += 1;
                    }
                }
                minute--;
            }

            while (hour > 0)
            {
                if (hour > 23)
                {
                    _todayDay += 1;
                    hour -= 23;
                }
                else
                {
                    if ((int)_dateForTimeCount.DayOfWeek != 0 && _dateForTimeCount.Hour >= 9 && _dateForTimeCount.Hour < 20)
                    {
                        _todayHour += 1;
                    }
                    else if ((int)_dateForTimeCount.DayOfWeek == 6 && _dateForTimeCount.Hour >= 9 && _dateForTimeCount.Hour < 14)
                    {
                        _todayHour += 1;
                    }
                    else
                    {
                        _todayHour += 11;
                    }
                }
                hour--;
            }

            while (day > 0)
            {
                if ((int)_dateForTimeCount.DayOfWeek != 6 && (int)_dateForTimeCount.DayOfWeek != 0)
                {
                    _todayDay += 1;
                }
                else if ((int)_dateForTimeCount.DayOfWeek == 6)
                {
                    _todayDay += 1;
                }
                else
                {
                    _todayDay = 1;
                }
                day--;
            }

            tSpan = new TimeSpan(_todayDay, _todayHour, _todayMinute, 0);
            resultado = _dateForTimeCount + tSpan;

            return resultado;
        }

        public void CompareDate(DateTime data)
        {
            //Comparar a data do resultado e imprimir as duas datas
            //tempo pago desde dia e tempo pago no proximo dia

            DateTime _dateTimePaid = data;
            DateTime _openTimeWeek = new DateTime(data.Year, data.Month, data.Day, 9, 0, 0);
            DateTime _closeTimeWeek = new DateTime(data.Year, data.Month, data.Day, 20, 0, 0);
            DateTime _closeTimeSaturday = new DateTime(data.Year, data.Month, data.Day, 14, 0, 0);
            DateTime _dateAtMidnight = new DateTime(data.Year, data.Month, data.Day, 0, 0, 0);
            TimeSpan _CompareDates = new TimeSpan();
            TimeSpan _timePaid = new TimeSpan();
            //if it is a day of the week after 8 pm
            if ((int)_dateTimePaid.DayOfWeek != 0 && (int)_dateTimePaid.DayOfWeek != 6 && _dateTimePaid.Hour >= 20)
            {
                _CompareDates = _closeTimeWeek.Subtract(_dateTimePaid);
                //Console.WriteLine("timeSPan comparado" + _CompareDates);

                _openTimeWeek.AddDays(1);
                _openTimeWeek.Add(_CompareDates);
                _dateTimePaid = _closeTimeWeek;

                Console.WriteLine("\n >>>You can be park until {0} until from 9am to {1}", _dateTimePaid, _openTimeWeek);
            }
            //If it is Saturdays after 2pm
            else if ((int)data.DayOfWeek == 6 && _dateTimePaid.Hour >= 14)
            {
                _CompareDates = _closeTimeSaturday.Subtract(_dateTimePaid);
                //Console.WriteLine("timeSPan comparado" + _CompareDates);

                _openTimeWeek.AddDays(2);
                _openTimeWeek.Add(_CompareDates);
                _dateTimePaid = _closeTimeSaturday;

                Console.WriteLine("\n >>>You can be park until {0} until from 9am to {1}", _dateTimePaid, _openTimeWeek);
            }
            //If it is Sundays between 9am to 8pm, it that schedule because that way we can only add a day and it is ready for monday 9am
            else if ((int)_dateTimePaid.DayOfWeek == 0 && _dateTimePaid.Hour >= 9 && _dateTimePaid.Hour < 20)
            {
                Console.WriteLine("\n >>>You can be park until {0}", _dateTimePaid.AddDays(1));

            }
            //If it is on the Week between Midnight to 9am
            else if ((int)_dateTimePaid.DayOfWeek != 0 && _dateTimePaid.Hour >= 0 && _dateTimePaid.Hour <= 9) 
            {
                /*tempopago = _dateTimePaid.Hour - houraPrimeiraMoeda;
                tempoEntre0HoraPago = (9 - (9 - _dateTimePaid.Hour));
                houraPrimeiraMoeda = _dateTimePaid.Hour - (tempoEntre0HoraPago);
                houraPrimeiraMoeda = _dateTimePaid.Hour - ((9 - (9 - _dateTimePaid.Hour)));
                _hourFirstCoinInserted = _dateTimePaid.Hour - (_dateTimePaid.Hour - ((9 - (9 - _dateTimePaid.Hour))));
                9 + horaspagas;*/

                _CompareDates = _dateTimePaid.Subtract(_dateTimePaid.Subtract(_dateAtMidnight.Subtract(_dateTimePaid)));//Determine the TimeSpan of the first coin inserted
                _dateAtMidnight.Add(_CompareDates); //add TimeSpan with the midnight date [fixed date in time]
                _timePaid = _dateTimePaid.Subtract(_dateAtMidnight); //Gives the time paid by the user
                _openTimeWeek.Add(_timePaid); //add to the open hour the time paid
                Console.WriteLine("\n >>>You can be park from this date time {0}", _openTimeWeek);
            }
            //If it is the Week between the 9am to 8pm and Saturdays 9am to 2pm
            else 
            {
                Console.WriteLine("\n >>>You can be park until {0}", _dateTimePaid);
            }
        }
    }
}
