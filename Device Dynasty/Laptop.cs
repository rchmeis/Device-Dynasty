using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Device_Dynasty
{
    internal class Laptop : ElectronicDevice
    { 
        /// <summary>
        /// Represents a laptop, which inherits from the base class <see cref="ElectronicDevice"/>.
        /// </summary>
        double _screenSize; // in inches        

        /// <summary>
        /// Initialize a new instance of <see cref="Laptop"/> class with specified screen size, brand, model, and battery capacity."/>
        /// </summary>
        /// <param name="screensize">The screen size of the laptop in inches</param>
        /// <param name="brand">The manufacturer or brand name of the laptop.</param>
        /// <param name="model">The specific model name or number.</param>
        /// <param name="battery">The battery capacity in mAh.</param>
        public Laptop(string screensize, string brand, string model, int battery): base(brand, model, battery)
        {
            ScreenSize = double.Parse(screensize);
        }
        /// <summary>
        /// Gets or sets the screen size of the laptop.
        /// </summary>
        public double ScreenSize
        {
            get { return _screenSize; }
            set { _screenSize = value; }
        }
        /// <summary>
        /// Returns a formatted string representing the device's details.
        /// </summary>
        /// <returns>A string containing the brand, model, and battery capacity.</returns>
        public string GetLaptopDetails()
        {
            return $"Laptop Details:\nBrand: {Brand}\nModel: {Model}\nScreen Size: {ScreenSize} inches\nBattery Capacity: {BatteryCapacity} mAh";
        }

        //public override string ToString()
        //{
        //    return $"Laptop Details:\nBrand: {Brand}\nModel: {Model}\nScreen Size: {ScreenSize} inches\nBattery Capacity: {BatteryCapacity} mAh";
        //}
    }
}
