using System;
using System.Collections.Generic;
using System.Text;

namespace Device_Dynasty
{
   /// <summary>
   /// Represents an abstract base class for electronic devices, providing common properties for brand, model, and
   /// battery capacity.
   /// </summary>
   /// <remarks>This class is intended to be inherited by specific electronic device types, enabling consistent
   /// management of device information across derived classes.</remarks>
    abstract class ElectronicDevice
    {
        protected string _brand;
        protected string _model;
        protected int _batteryCapacity; // in mAh

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
        /// Displays the device's brand, model, and battery capacity in milliampere-hours (mAh) to the console.
        /// </summary>
        public void GetDeviceDetails()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Battery Capacity: {BatteryCapacity} mAh"); 
        }
    }
}

   

