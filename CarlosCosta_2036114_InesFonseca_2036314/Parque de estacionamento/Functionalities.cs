using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Menus;

namespace Functionalities
{
    //Method that receives the car plates inserted by the user
    //Stores into the Arrays
    //Outputs a list of plates and a quantity of plate. 
    public class CarPlate 
    {
        //Receive Car Plates and store in the next variables.
        public string _carPlateZone1;
        public string _carPlateZone2;
        public string _carPlateZone3;

        //Creating an Array to store the plates.
        public string[] _plateArrayZone1 = { };
        public string[] _plateArrayZone2 = { };
        public string[] _plateArrayZone3 = { };

        //Stores the arrays.Length into a variable
        public int carsInZone1 = 0;
        private int carsInZone2 = 0;
        private int carsInZone3 = 0;

        //Atribute values to the current class from outside sources.
        public CarPlate(string carPlateZone1, string carPlateZone2, string carPlateZone3) 
        {
            this._carPlateZone1 = carPlateZone1;
            this._carPlateZone2 = carPlateZone2;
            this._carPlateZone3 = carPlateZone3;
        }
        //Store and Counts Array elements for Zone1
        public Array GetCarPlateZone1(string _carPlateZone1) 
        {
            _plateArrayZone1 = new string[] { _carPlateZone1 };
            return _plateArrayZone1;
        }
        public int occupiedSlotsZone1(string carPlateZone1) 
        {
            carsInZone1 = _carPlateZone1.Length;
            return carsInZone1;
            //return _carPlateZone1.Length;
        }

        //Store and count Array elements for Zone2
        public Array GetCarPlateZone2(string _carPlateZone2)
        {
            _plateArrayZone2 = new string[] { _carPlateZone2 };
            return _plateArrayZone2;
        }
        public int occupiedSlotsZone2()
        {
            carsInZone2 = _carPlateZone1.Length;
            return carsInZone2;
        }

        //Store and count Array elements for Zone3
        public Array GetCarPlateZone3(string _carPlateZone3)
        {
            _plateArrayZone3 = new string[] { _carPlateZone3 };
            return _plateArrayZone3;
        }
        public int occupiedSlotsZone3()
        {
            carsInZone3 = _carPlateZone1.Length;
            return carsInZone3;
        }
    }

    public class ZoneAvailability
    {
        //Define and atribute variables for each zone
        public int carSlotsZone1 = 50;
        public int carSlotsZone2 = 100;
        public int carSlotsZone3;

        //Quantity of cars in the zone
        public int _numCarInZone1;
        public int _numCarInZone2;
        public int _numCarInZone3;

        public ZoneAvailability(int carsInZone1, int carsInZone2, int carsInZone3) 
        {
            this._numCarInZone1 = carsInZone1;
            this._numCarInZone2 = carsInZone2;
            this._numCarInZone3 = carsInZone3;  
        }
        public static void CountingCarsZone1() 
        {
            
        }
        public static void CountingCarsZone2()
        {

        }
        public static void CountingCarsZone3()
        {

        }
    }
}