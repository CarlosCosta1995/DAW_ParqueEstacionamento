using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Menus;
using ConsolePrint;

namespace Functionalities
{
    public class CarPlate
    {
        //Method that receives the car plates inserted by the user
        //Stores into the Arrays
        //Outputs a list of plates and a quantity of plate. 

        //Creating an Array to store the plates.
        public static List<string> listaZona1 = new List<string> { };
        public static List<string> listaZona2 = new List<string> { };
        public static List<string> listaZona3 = new List<string> { };


        //Atribute carsInZone, the value of the amount of cars (listaZona1.Count()) from the Zones List
        public int carsInZone1 = listaZona1.Count();
        public int carsInZone2 = listaZona2.Count();
        public int carsInZone3 = listaZona3.Count();

        //Define and atribute variables for each zone
        public static int carSlotsZone1 = 50;
        public static int carSlotsZone2 = 100;
        public static int carSlotsZone3 = 70;

        //Stores the variable of occupied cars by Zone.
        public static int CarsInZone1;
        public static int CarsInZone2;
        public static int CarsInZone3;

        //Atributes the arrays.Length variable to public satic variable
        //public static int CarsInZone1;// NÃO É NECESSÁRIO

        //public static string tteste = "qwe"; NÃO É NECESSÁRIO

        //Atributing values to the current class from outside sources.
        /*public CarPlate1(string carPlateZone1)
        {

            _carPlateZone1 = carPlateZone1;
        }

        public CarPlate2(string carPlateZone2)
        {

            _carPlateZone2 = carPlateZone2;
        }

        public CarPlate3(string carPlateZone3)
        {

            _carPlateZone3 = carPlateZone3;
        }*/

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

        public void occupiedSlotsZone1() //Counts how many plates are in the array and removes one if reaches the zone full capacity for Zone1.
        {
            //https://www.javatpoint.com/program-to-count-the-total-number-of-characters-in-a-string

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
        }      
    }

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
        }

    }

    public class MoneyMachine
    {
        //Receives the cash from the user input
        //Pre-define Money accepted by the Machine
        //Compares the User input with the accept Money ???
        //Make the addition os cash inserted by the user
        //Calculates all Money inserted in the machine
        //Reset the cash inserted
        //https://stackoverflow.com/questions/51007525/c-sharp-displaying-total-amount-of-money-in-a-class-instance
        //https://youtu.be/33czhZrH51s

        //Creating a varible to receive the cash
        public double _cash;
        public double _addCash;
        public double _machineTotalAmount;
        public double[] acceptedCash = { 0.00, 0.01, 0.02, 0.05, 0.10, 0.20, 0.50, 1.00, 2.00, 5.00, 10.00, 20.00 }; 
        //change coins: can´t accept more than 50 cent because- zone1 max. 45 min which is up to 85 cent - zone2 max 1h which is up to 2€
        //define what happens when the client uses other coins, letters or negative numbers
        public double AddMoney 
        {
            get { return _addCash; }
            set { _addCash = value; }
        }
       
        public double insertingCash(double amount) //Asks the user to insert an amount of money
        {

            //Verify if the amount inserted is contained in the AcceptedCash Array
            //https://stackoverflow.com/questions/13257458/check-if-a-value-is-in-an-array-c
            //https://stackoverflow.com/questions/61448526/java-checking-if-a-variable-is-equal-to-any-of-the-array-elements
            if (acceptedCash.Contains(amount))
            {
                Console.WriteLine("\nYou insert {0} €\n", amount);
                _cash += amount;
            }
            else
            {
                Console.WriteLine("\nYou insert {0} €", amount);
                Console.WriteLine("You money is not accepted by the machine!");
                Console.WriteLine("The coins accepted are {0.00, 0.01, 0.02, 0.05, 0.10, 0.20, 0.50} cents and {1.00, 2.00, 5.00, 10.00, 20.00} euros. \n");
            }

            //calculates the addiion of the cash
            _addCash += _cash;
            machineTotalMoney(_cash); //To _addCash to the total money inside the machine by calling the method
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
            Console.WriteLine("Refounding {0} euros", _addCash);
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
        public double _timePerHourZone1 = 1.15;//Convert price per hour to price per minutes
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
        public double _timePerHourZone2 = 1.00;//Convert price per hour to price per minutes
        public double _maxMinutesInZone2 = 120;//Convert time in minutes (120 min = 2h * 60min)
        public double _timePaidForZone2; //Stores the value Calculated by the function PayInZone2()
        public double PayInZone2(double _addCash) //Calculating the payment for Zone2
        {
            _timePaidForZone2 = (_addCash * _maxMinutesInZone2) / _timePerHourZone2;
            //Console.WriteLine("Tempo !!!#!" + _timePaidForZone2);
            return _timePaidForZone2;
        }


        //============================== Zone3: 0.62 euros/h => unlimited time =================================
        public double _timePerHourZone3 = 0.62;//Convert price per hour to price per minutes
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
        /*A Class needs:
         * Atributs
         * Selectors and Properties
         * Constructs
         * Methods
         * */

        //================= Atributs ===============================
        private static List<int> _dayOfWeek = new List<int> { 0, 1, 2, 3, 4, 5, 6 };

        //private double _timePaid;
        private double _days;
        private double _hour;
        private double _minute;
        private double _second = 0;
        private double timeConvertMinutes;

        //private DateTime _dateForTimeCount = new DateTime();
        //DateTime _dateAtOpen = new DateTime();
        //DateTime _dateAtClose = new DateTime();
        //public TimeSpan _TimePaid;



        //================= Selector and Properties ==============================
        /*public List<int> DayOfWeek 
        { 
            get { return _dayOfWeek; }
            set { _dayOfWeek = value; }
        }*/

        /*public double TimePaid 
        {
            get { return _timePaid; }
            set { _timePaid = value; }
        }*/

        //================= Constructs ==============================
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


        //=================== Methods =============================== seg a sex => 9h-20h // sab => 9h-14h //Doming => for free!?
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

            //double novo = _timePaid / 60;


            var time = TimeSpan.FromMinutes(_timePaid);
            Console.WriteLine("{0:00}:{1:00}", (int)time.TotalHours, time.Minutes);


            _hour = (int)time.TotalHours;
            _minute = time.Minutes;

            //Console.WriteLine("Novo valor " + novo);

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
                else if((int)_dateForTimeCount.DayOfWeek == 6) 
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
            TimeSpan _CompareDates = new TimeSpan();
            
            if ((int)data.DayOfWeek != 0 && (int)data.DayOfWeek != 6) 
            {
                if (data.Hour >= 20)
                {
                    _CompareDates = _closeTimeWeek.Subtract(data);
                    _openTimeWeek.AddDays(1);
                    _openTimeWeek.Add(_CompareDates);
                    _openTimeWeek.Add(_CompareDates);
                    data.Subtract(_CompareDates);

                    Console.WriteLine("You can be park until {0} until from 9am to {1}", data, _openTimeWeek);
                }
            }
            else if ((int)data.DayOfWeek != 6 && data.Hour >= 14) 
            {
                _CompareDates = _closeTimeWeek.Subtract(data);
                _openTimeWeek.AddDays(1);
                _openTimeWeek.Add(_CompareDates);
                data.Subtract(_CompareDates);

                Console.WriteLine("You can be park until {0} until from 9am to {1}", data, _openTimeWeek);
            }

            /*// Compare dates
            if (dateTimeNow != date)
            {
                Console.WriteLine("diferent date");
            }

            // compare hour, minutes and seconds
            if (dateTimeNow.Hour != date.Hour)
            {
                Console.WriteLine("diferent hour");
            }

            // if excedd the park schdule yours
            if (date.Hour >= 20)
            {
                // ...
            }*/

        }
    }

}
