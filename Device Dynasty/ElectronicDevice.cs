using System;
using System.Collections.Generic;
using System.Text;

namespace Device_Dynasty
{
    /// <summary>
    /// Represents a generic electronic device with brand, model, and battery specifications.
    /// </summary>
    internal class ElectronicDevice
    {
        private string _brand;
        private string _model;
        private int _batteryCapacity; // in mAh

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectronicDevice"/> class.
        /// </summary>
        /// <param name="brand">The manufacturer or brand name of the device.</param>
        /// <param name="model">The specific model name or number of the device.</param>
        /// <param name="battery">The battery capacity in milliampere-hours (mAh).</param>
        protected ElectronicDevice(string brand, string model, int battery)
        {
            Brand = brand;
            Model = model;
            BatteryCapacity = battery;
        }

        /// <summary>
        /// Gets or sets the brand of the electronic device.
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        /// <summary>
        /// Gets or sets the model name of the electronic device.
        /// </summary>
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        /// <summary>
        /// Gets or sets the battery capacity of the device in mAh.
        /// </summary>
        public int BatteryCapacity
        {
            get { return _batteryCapacity; }
            set { _batteryCapacity = value; }
        }

        /// <summary>
        /// Returns a formatted string representing the device's details.
        /// </summary>
        /// <returns>A string containing the brand, model, and battery capacity.</returns>
        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Battery Capacity: {BatteryCapacity} mAh"; 
        }
    }
}

   

