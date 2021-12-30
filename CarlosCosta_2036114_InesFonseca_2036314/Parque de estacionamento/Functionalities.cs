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

        //Receive Car Plates and store in the next variables.
        public string _carPlateZone1 { get; set; }
        public string _carPlateZone2 { get; set; }
        public string _carPlateZone3 { get; set; }

        //Creating an Array to store the plates.
        public string[] _plateArrayZone1 = { };
        public string[] _plateArrayZone2 = { };
        public string[] _plateArrayZone3 = { };

        //Stores the arrays.Length into a variable
        public int carsInZone1 { get; set; }
        public int carsInZone2 { get; set; }
        public int carsInZone3 { get; set; }

        //Atributing values to the current class from outside sources.
        public CarPlate(string carPlateZone1, string carPlateZone2, string carPlateZone3)
        {
            this._carPlateZone1 = carPlateZone1;
            this._carPlateZone2 = carPlateZone2;
            this._carPlateZone3 = carPlateZone3;
        }

        //Store and Counts Array elements for Zone1
        public Array GetCarPlateZone1(string _carPlateZone1) //Store a car plate into the array, in Zone1.
        {
            _plateArrayZone1 = new string[] { _carPlateZone1 };
            return _plateArrayZone1;
        }
        public int occupiedSlotsZone1(string carPlateZone1) //Counts how many plates are in the array and removes one if reaches the zone full capacity for Zone1.
        {
            //https://www.javatpoint.com/program-to-count-the-total-number-of-characters-in-a-string

            if (carPlateZone1.Length < 50)
            {
                return carsInZone1 = carsInZone1 + 1;
            }
            else
            {
                return carsInZone1 = carsInZone1 - 1;
            }
        }
        public static void occupiedZone1(int carsInZone1)
        {
            Console.WriteLine(carsInZone1);
        }

        //Store and count Array elements for Zone2
        public Array GetCarPlateZone2(string _carPlateZone2) //Store a car plate into the array, in Zone2.
        {
            _plateArrayZone2 = new string[] { _carPlateZone2 };
            return _plateArrayZone2;
        }
        public int occupiedSlotsZone2(string _carPlateZone2) //Counts how many plates are in the array and removes one if reaches the zone full capacity for Zone2.
        {
            if (_carPlateZone2.Length < 50)
            {
                return carsInZone2 = carsInZone2 + 1;
            }
            else
            {
                return carsInZone2 = carsInZone2 - 1;
            }
        }

        //Store and count Array elements for Zone3
        public Array GetCarPlateZone3(string _carPlateZone3) //Store a car plate into the array, in Zone3.
        {
            _plateArrayZone3 = new string[] { _carPlateZone3 };
            return _plateArrayZone3;
        }
        public int occupiedSlotsZone3(string _carPlateZone3) //Counts how many plates are in the array and removes one if reaches the zone full capacity for Zone3.
        {
            if (_carPlateZone3.Length < 50)
            {
                return carsInZone3 = carsInZone3 + 1;
            }
            else
            {
                return carsInZone3 = carsInZone3 - 1;

            }
        }
    }

    public class ZoneAvailability
    {
        //Method that receives the arrays from CarPlate Method
        //Calculates the available car slots (Quantity of zone slots - occupied slots in the zone given by the CarsInZoneX)
        //Outputs the Available slots

        //Define and atribute variables for each zone
        public int carSlotsZone1 = 50;
        public int carSlotsZone2 = 100;
        public int carSlotsZone3 = 70;

        //Quantity of cars in the zone
        public int _numCarInZone1 { get; set; }
        public int _numCarInZone2 { get; set; }
        public int _numCarInZone3 { get; set; }

        public ZoneAvailability(int carsInZone1, int carsInZone2, int carsInZone3)
        {
            this._numCarInZone1 = carsInZone1;
            this._numCarInZone2 = carsInZone2;
            this._numCarInZone3 = carsInZone3;
        }
        public int AvailableSlotsZone1(int _numCarInZone1, int carSlotsZone1) //Calculate the number of slots available a car in the Zone1.
        {
            if (carSlotsZone1 - _numCarInZone1 == carSlotsZone1)
            {
                Console.WriteLine("Zone is full, {0} out of {1}. Returning to back to Menu.", _numCarInZone1, carSlotsZone1);
                AllMenus.ClientMenu();
                carSlotsZone1 = carSlotsZone1 + 1;
                return carSlotsZone1;

            }
            else
            {
                return carSlotsZone1 - _numCarInZone1;
            }
        }

        public int AvailableSlotsZone2(int _numCarInZone2, int carSlotsZone2) //Calculate the number of slots available in the Zone2.
        {
            if (carSlotsZone2 - _numCarInZone2 == carSlotsZone2)
            {
                Console.WriteLine("Zone is full, {0} out of {1}. Returning to back to Menu.", _numCarInZone2, carSlotsZone2);
                AllMenus.ClientMenu();
                carSlotsZone2 = carSlotsZone2 + 1;
                return carSlotsZone2;

            }
            else
            {
                return carSlotsZone2 - _numCarInZone2;
            }
        }

        public int CountingCarsZone3(int _numCarInZone3, int carSlotsZone3) //Calculate the number of slots available in the Zone3.
        {
            if (carSlotsZone3 - _numCarInZone3 == carSlotsZone3)
            {
                Console.WriteLine("Zone is full, {0} out of {1}. Returning to back to Menu.", _numCarInZone3, carSlotsZone3);
                AllMenus.ClientMenu();
                carSlotsZone3 = carSlotsZone3 + 1;
                return carSlotsZone3;

            }
            else
            {
                return carSlotsZone3 - _numCarInZone3;
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
        public double _addCash { get; set; }
        public double _machineTotalAmount { get; set; }
        public double[] acceptedCash = { 0.00, 0.01, 0.02, 0.05, 0.10, 0.20, 0.50, 1.00, 2.00, 5.00, 10.00, 20.00 };

        public double insertingCash(double amount) //Asks the user to insert an amount of money
        {

            //Verify if the amount inserted is contained in the AcceptedCash Array
            //https://stackoverflow.com/questions/13257458/check-if-a-value-is-in-an-array-c
            //https://stackoverflow.com/questions/61448526/java-checking-if-a-variable-is-equal-to-any-of-the-array-elements
            if (acceptedCash.Contains(amount))
            {
                Console.WriteLine("\nYou insert {0} €\n", amount);
                _cash = amount;
            }
            else
            {
                Console.WriteLine("\nYou insert {0} €", amount);
                Console.WriteLine("You money is not accepted by the machine!");
                Console.WriteLine("The coins accepted are {0.00, 0.01, 0.02, 0.05, 0.10, 0.20, 0.50} cents and {1.00, 2.00, 5.00, 10.00, 20.00} euros. \n");
            }

            //calculates the addiion of the cash
            _addCash += _cash;
            machineTotalMoney(_addCash); //To _addCash to the total money inside the machine by calling the method
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

    public class ParkPayment
    {
        //Zone Payments time rules
        

        //Zone1: 1.15 euros/h => max 45min
        public double _timePerHourZone1 = 1.15/60;//Convert price per hour to price per minutes
        public double _maxMinutesInZone1 = 45;// Time already in minutes
        private double MaxTimePaidInZone1 = ((1.15 * 45) / 60);// Calculates the maximum money to stay for 45min
        public double _timePaidForZone1 { get; set; } //Stores the value Calculated by the function PayZone1()


        //Zone2: 1.00 euros/h => max 2h
        public double _timePerHourZone2 = 1.00/60;//Convert price per hour to price per minutes
        public double _maxMinutesInZone2 = 2 * 60;//Convert time in minutes
        private double MaxTimePaidInZone2 = ((1.00 * 120) / 60);// Calculates the maximum money to stay for 45min
        public double _timePaidForZone2 { get; set; } //Stores the value Calculated by the function PayZone1()

        //Zone3: 0.62 euros/h => unlimited time
        public double _timePerHourZone3 = 0.62/60;//Convert price per hour to price per minutes
        public double _timePaidForZone3 { get; set; } //Stores the value Calculated by the function PayZone1()

        public double PayInZone1(double _addCash) //Payment for Zone 1
        {
            _timePaidForZone1 = ((_addCash * _maxMinutesInZone1) / _timePerHourZone1);
            if (_timePaidForZone1 <= MaxTimePaidInZone1)
            {
                Console.WriteLine(_timePaidForZone1);
                return _timePaidForZone1;
            }
            else
            {
                AllMenus.ClientMenu(); //Replace for Zone Menu
                return _timePaidForZone1 = 0;
            }
        }

        public double PayInZone2(double _addCash, double _timePerHourZone2, double _maxMinutesInZone2) //Payment for Zone 2
        {
            _timePaidForZone2 = ((_addCash * _maxMinutesInZone2) / _timePerHourZone2);
            if (_timePaidForZone2 <= MaxTimePaidInZone2)
            {
                _timePaidForZone2 = ((_addCash * _maxMinutesInZone2) / _timePerHourZone2);
                Console.WriteLine(_timePaidForZone2);
                return _timePaidForZone2;
            }
            else
            {
                AllMenus.ClientMenu(); //Replace for Zone Menu
                return _timePaidForZone2 = 0;
            }
        }

        public double PayInZone3(double _addCash, double _timePerHourZone3) //Payment for Zone 2
        {
            return _timePaidForZone3 = (_addCash / _timePerHourZone3);
        }
    }
}