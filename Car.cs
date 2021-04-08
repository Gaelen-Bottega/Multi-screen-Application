// Customer.cs
// Author:  Gaelen Rhoads and Kyle Chapman's slides
// Date:    March 14, 2021
// Description:
//  A class to declare private variables, assign them to objects and have two constructors. It also contains the mutators and accessors for the
// populate list view function to work! It also contains the GetCarData() function where concatinates a string to describe a car.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Group3
{
    /// <summary>
    /// A class to handle the car inventory
    /// </summary>
    class Car
    {
        // Declarations
        private static int carCount = 0;
        private int carIdentificationNumber = 0;
        private string carMake = String.Empty;
        private string carModel = String.Empty;
        private int carYear = 0;
        private bool carNewStatus = false;
        private decimal carPrice = 0.0M;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Car()
        {
            carCount += 1;
            carIdentificationNumber = carCount;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="make">Make of the car</param>
        /// <param name="model">Model of the car</param>
        /// <param name="year">Year of car</param>
        /// <param name="newStatus">Boolean to set car as new or not</param>
        /// <param name="price">Price of car</param>
        public Car(string make, string model, int year, bool newStatus, decimal price): this()
        {
            // Call default constructor if we did not know about : this()
            //new Car();

            // Assign values based on what user passes in
            carMake = make;
            carModel = model;
            carYear = year;
            carNewStatus = newStatus;
            carPrice = price;
        }

        /// <summary>
        /// Count ReadOnly Property - Gets the number of cars that have been instantiated/created
        /// </summary>
        public int Count
        {
            get
            {
                return carCount;
            }
        }

        /// <summary>
        /// Get ID of the current car
        /// </summary>
        public int Id
        {
            get
            {
                return carIdentificationNumber;
            }
        }

        /// <summary>
        /// Returns whether a car is new or not.
        /// </summary>
        public bool NewStatus
        {
            get
            {
                return carNewStatus;
            }
            set
            {
                // The value passed in is always called "value" by default.
                carNewStatus = value;
            }
        }

        /// <summary>
        /// Returns make of car
        /// </summary>
        public string Make
        {
            get
            {
                return carMake;
            }
            set
            {
                // The value passed in is always called "value" by default - regardless of the data type.
                carMake = value;
            }
        }

        /// <summary>
        /// Returns model of car
        /// </summary>
        public string Model
        {
            get
            {
                return carModel;
            }
            set
            {
                carModel = value;
            }
        }

        /// <summary>
        /// Returns year of car
        /// </summary>
        public int Year
        {
            get
            {
                return carYear;
            }
            set
            {
                carYear = value;
            }
        }

        /// <summary>
        /// Returns price of car
        /// </summary>
        public decimal Price
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }

        /// <summary>
        /// GetCarData is a function that uses concatination on the private properties within the class scope
        /// </summary>
        /// <returns>string describing the customer</returns>
        public string GetCarData()
        {
            return "This is a " + carNewStatus + " " + carYear + " " + carMake + " " + carModel + ", that costs " + carPrice + ".";

        }
    }
}
