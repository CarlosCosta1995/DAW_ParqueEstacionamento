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
        public static int carsInZone1 = listaZona1.Count();
        public static int carsInZone2 = listaZona2.Count();
        public static int carsInZone3 = listaZona3.Count();

        //Define and atribute variables for each zone
        public static int carSlotsZone1 = 50;
        public static int carSlotsZone2 = 100;
        public static int carSlotsZone3 = 70;

        //Stores the variable of occupied cars by Zone.
        public static int CarsInZone1;
        public static int CarsInZone2;
        public static int CarsInZone3;


    //============================== Class ZoneAvailability ==============================//
    //Method that receives the arrays from CarPlate Method
    //Calculates the available car slots (Quantity of zone slots - occupied slots in the zone given by the CarsInZoneX)
    //Outputs the Available slots
    /*public class ZoneAvailability
    {

        //Define and atribute variables for each zone
        public static int carSlotsZone1 = 50;
        public static int carSlotsZone2 = 100;
        public static int carSlotsZone3 = 70;

        //Quantity of cars in the zone
        public static int _numOccupiedCarInZone1;
        public static int _numOccupiedCarInZone2;
        public static int _numOccupiedCarInZone3;

        public static void AvailableSlotsZone1() //Calculate the number of slots available a car in the Zone1.
        {
            if (CarPlate.listaZona1.Count() == carSlotsZone1)
            {
                //======= Zone is full, Occupiedslots(_numOccupiedCarInZone1) out of Free slots(carSlotsZone1).
                Console.WriteLine("Zone is full, {0} out of {1}. Returning to back to Menu.", _numOccupiedCarInZone1, carSlotsZone1);
                AllMenus.ClientMenu();
            }else 
            {
                _numOccupiedCarInZone1 = ZoneAvailability.carSlotsZone1 - CarPlate.listaZona1.Count();
            } 

           // return _numOccupiedCarInZone1;
        }

        public  void AvailableSlotsZone2() //Calculate the number of slots available in the Zone2.
        {

            if (CarPlate.listaZona2.Count() == carSlotsZone2)
            {
                //======= Zone is full, Occupiedslots(_numOccupiedCarInZone2) out of Free slots(carSlotsZone2).
                Console.WriteLine("Zone is full, {0} out of {1}. Returning to back to Menu.", _numOccupiedCarInZone2, carSlotsZone2);
                AllMenus.ClientMenu();
            }
            else
            {
                _numOccupiedCarInZone2 = ZoneAvailability.carSlotsZone2 - CarPlate.listaZona2.Count();
            }
        }

        public void CountingCarsZone3() //Calculate the number of slots available in the Zone3.
        {
            if (CarPlate.listaZona3.Count() == carSlotsZone3)
            {
                //======= Zone is full, Occupiedslots(_numOccupiedCarInZone3) out of Free slots(carSlotsZone3).
                Console.WriteLine("Zone is full, {0} out of {1}. Returning to back to Menu.", _numOccupiedCarInZone3, carSlotsZone3);
                AllMenus.ClientMenu();
            }
            else
            {
                _numOccupiedCarInZone3 = ZoneAvailability.carSlotsZone3 - CarPlate.listaZona3.Count();
            }
        }*/

    /* //Store and Counts Array elements for Zone1
        public static int occupiedSlotsZone1() //Counts how many plates are in the array and removes one if reaches the zone full capacity for Zone1.
        {
            if (carsInZone1 < ZoneAvailability.carSlotsZone1) //how to do a random clear
            {
                carsInZone1 = carsInZone1 + 1;
            }
            else
            {
                carsInZone1 = carsInZone1 - 1;
            }
            CarsInZone1 = carsInZone1;
            return CarsInZone1;
        }

        //Store and Counts Array elements for Zone2
        public static int occupiedSlotsZone2() //Counts how many plates are in the array and removes one if reaches the zone full capacity for Zone2.
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
            return CarsInZone2;
        }

        //Store and Counts Array elements for Zone3
        public static int occupiedSlotsZone3() //Counts how many plates are in the array and removes one if reaches the zone full capacity for Zone3.
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
            return CarsInZone3;
        } */
    }

    //============================== Class MoneyMachine ==============================//
    //Receives the cash from the user input
    //Pre-define Money accepted by the Machine
    //Compares the User input with the accept Money
    //Make the addition os cash inserted by the user
    //Calculates all Money inserted in the machine
    //Reset the cash inserted
    //ref. https://stackoverflow.com/questions/51007525/c-sharp-displaying-total-amount-of-money-in-a-class-instance
    //ref. https://youtu.be/33czhZrH51s
    //ref. https://stackoverflow.com/questions/13257458/check-if-a-value-is-in-an-array-c
    //ref. https://stackoverflow.com/questions/61448526/java-checking-if-a-variable-is-equal-to-any-of-the-array-elements
    //ref. https://docs.microsoft.com/en-us/learn/modules/csharp-arrays/3-exercise-foreach#code-try-13

    public partial class MoneyMachine
    {
        //Creating a varible to receive the cash
        public double _cash;
        public double _addCash { get; set; }
        public static double _machineTotalAmount { get; set; }
        public double[] acceptedCash = { 0.00, 0.01, 0.02, 0.05, 0.10, 0.20, 0.50, 1.00, 2.00, 5.00, 10.00, 20.00 }; 
        //change coins: can´t accept more than 50 cent because- zone1 max. 45 min which is up to 85 cent - zone2 max 1h which is up to 2€
        //define what happens when the client uses other coins, letters or negative numbers
       
        public double insertingCash(double amount) //Asks the user to insert an amount of money
        {

            //Verify if the amount inserted is contained in the AcceptedCash Array
            if (acceptedCash.Contains(amount) && amount != 0)
            {
                Console.WriteLine("\n>>>You inserted {0} €\n", amount);
                _cash = amount;

                //calculates the addiion of the cash
                _addCash += _cash;
                machineTotalMoney(_cash); //To _addCash to the total money inside the machine by calling the method
            }
            else if(amount == 0) 
            {
                Console.WriteLine("Counting processing your time.");
            }
            else
            {
                Console.WriteLine("\n>>>You inserted {0} €\n", amount);
                Console.WriteLine("   !!! You money is not accepted by the machine !!!");
                Console.WriteLine("   The coins accepted are:\n   {0.00, 0.01, 0.02, 0.05, 0.10, 0.20, 0.50} cents \n   and {1.00, 2.00, 5.00, 10.00, 20.00} euros. \n");
            }
            return _cash;
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
    //========================= Class ParkPayment =========================//
    public class ParkPayment
    {
        //Zone Payments time rules

        //============================== Zone1: 1.15 euros/h => max 45min ==============================//
        public double _timePerHourZone1 = 1.15;//Convert price per hour to price per minutes
        public double _maxMinutesInZone1 = 45;// Time already in minutes
        public double _timePaidForZone1;//Stores the value Calculated by the function PayInZone1()
        public double PayInZone1(double _addCash) //Calculating the payment for Zone1
        {
            _timePaidForZone1 = (_addCash * _maxMinutesInZone1) / _timePerHourZone1;
            return _timePaidForZone1;
            
        }

        //============================== Zone2: 1.00 euros/h => max 2h ==============================//
        public double _timePerHourZone2 = 1.00;//Convert price per hour to price per minutes
        public double _maxMinutesInZone2 = 120;//Convert time in minutes (120 min = 2h * 60min)
        public double _timePaidForZone2; //Stores the value Calculated by the function PayInZone2()
        public double PayInZone2(double _addCash) //Calculating the payment for Zone2
        {
            _timePaidForZone2 = (_addCash * _maxMinutesInZone2) / _timePerHourZone2;
            return _timePaidForZone2;
        }

        //============================== Zone3: 0.62 euros/h => unlimited time =================================//
        public double _timePerHourZone3 = 0.62;//Convert price per hour to price per minutes
        public double _maxMinutesInZone3 = 60;//Convert time in minutes (60 min = 1h)
        public double _timePaidForZone3; //Stores the value Calculated by the function PayInZone3()
        public double PayInZone3(double _addCash) //Calculating the payment for Zone3
        {
            _timePaidForZone3 = (_addCash * _maxMinutesInZone3) / _timePerHourZone3;
            return _timePaidForZone3;
        }
    }

    //========================= Class Schedule =========================//
    public class Schedule
    {
        //================= Atributs ===============================
        private static List<int> _dayOfWeek = new List<int> { 0, 1, 2, 3, 4, 5, 6 };

        //private double _timePaid;
        private double _days;
        private double _hour;
        private double _minute;
        private double _second = 0;

        //private DateTime _dateForTimeCount = new DateTime();
        //DateTime _dateAtOpen = new DateTime();
        //DateTime _dateAtClose = new DateTime();
        //public TimeSpan _TimePaid;

        //================= Constructs ==============================

        public Schedule()
        {
            this._days = new double();
            this._hour = new double();
            this._minute = new double();
            this._second = new double();
        }

        //================= Selector and Properties ==============================//
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


        //=================== Methods ===============================//
        //Monday to Friday => 9h-20h // Saturday => 9h-14h //Sunday => free
        public void CalculateTime(double _timePaid)
        {
            for (int i = 0; i < _timePaid; i++)
            {
                if (_timePaid >= 1440) //24 (hours in a day) x 60 (minutes in an hour) = 1440 minutes.
                {
                    _days += 1;
                    _timePaid -= 1440;
                }
            } 

            //ref: Prof Ana
            var time = TimeSpan.FromMinutes(_timePaid);
            //Console.WriteLine("{0:00}:{1:00}", (int)time.TotalHours, time.Minutes);

            _hour = (int)time.TotalHours;
            _minute = (int)time.Minutes;
            _second = 0;
        }

        public DateTime ScheduleForZone(DateTime _dateForTimeCount, double day, double hour, double minute)
        {
            int _todayDay = 0;
            int _todayHour = 0;
            int _todayMinute = 0;

            //Store the result in a TimeSpan
            //Store the date of entrance to further add the calculated TimeSpan tSpan
            TimeSpan tSpan;           
            DateTime resultado = new DateTime(); 

            //Determine the Minutes, Hour and Days to be store in the TimeSpan tSpan
            while (day > 0)
            {
                if ((int)_dateForTimeCount.DayOfWeek != 6 && (int)_dateForTimeCount.DayOfWeek != 0 && _dateForTimeCount.Hour >= 9 && _dateForTimeCount.Hour < 20)
                {
                    _todayDay += 1;
                }
                else if ((int)_dateForTimeCount.DayOfWeek == 6 && _dateForTimeCount.Hour >= 9 && _dateForTimeCount.Hour < 14)
                {
                    _todayDay += 1;
                }
                else
                {
                    _todayDay = 1;
                }
                day--;
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
                        _todayHour += 13;
                    }
                }
                hour--;
            }

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

            //Create the tSpan based on the schedule written before
            tSpan = new TimeSpan(_todayDay, _todayHour, _todayMinute, 0);

            //Add Date to the TimeSpan

            resultado = _dateForTimeCount.Add(tSpan);
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

            if ((int)_dateTimePaid.DayOfWeek != 0 && (int)_dateTimePaid.DayOfWeek != 6 && _dateTimePaid.Hour >= 20)
            {
                _CompareDates = _closeTimeWeek.Subtract(_dateTimePaid);
                Console.WriteLine("timeSPan comparado" + _CompareDates);

                _openTimeWeek.AddDays(1);
                _openTimeWeek.Add(_CompareDates);
                _dateTimePaid = _closeTimeWeek;

                Console.WriteLine("You can be park until {0} until from 9am to {1}", _dateTimePaid, _openTimeWeek);
            }
            else if ((int)data.DayOfWeek == 6 && _dateTimePaid.Hour >= 14)
            {
                _CompareDates = _closeTimeSaturday.Subtract(_dateTimePaid);
                Console.WriteLine("timeSPan comparado" + _CompareDates);

                _openTimeWeek.AddDays(2);
                _openTimeWeek.Add(_CompareDates);
                _dateTimePaid = _closeTimeSaturday;

                Console.WriteLine("You can be park until {0} until from 9am to {1}", _dateTimePaid, _openTimeWeek);
            }
            else if ((int)_dateTimePaid.DayOfWeek == 0 && _dateTimePaid.Hour >= 9 && _dateTimePaid.Hour < 20) 
            {
                    _dateTimePaid.AddDays(1);
                    Console.WriteLine("You can be park until {0}", _dateTimePaid);

            }
            else //Pass time between Midnight to 9am
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
                //Console.WriteLine("You can be park from this date time {0}", _openTimeWeek);
            }
        }
    }
}
