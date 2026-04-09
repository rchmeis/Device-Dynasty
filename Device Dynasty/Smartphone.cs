using System;
using System.Collections.Generic;
using System.Text;

namespace Device_Dynasty
{
    internal class Smartphone : ElectronicDevice
    {
        /// <summary>
        /// Represents a smartphone, inheriting core specifications from <see cref="ElectronicDevice"/>.
        /// </summary>
        private string _operatingSystem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Smartphone"/> class.
        /// </summary>
        /// <param name="operatingSystem">The operating system installed on the phone (e.g., Android, iOS).</param>
        /// <param name="brand">The manufacturer of the smartphone.</param>
        /// <param name="model">The specific model name or number.</param>
        /// <param name="battery">The battery capacity in mAh.</param>
        public Smartphone(string operatingSystem, string brand, string model, int battery) 
            :base(brand, model, battery)
        {
            OperatingSystem = operatingSystem;
        }

        /// <summary>
        /// Gets or sets the operating system of the smartphone.
        /// </summary>
        public string OperatingSystem
        {
            get { return _operatingSystem; }
            set { _operatingSystem = value; }
        }
        /// <summary>
        /// Displays detailed information about the smartphone, including its operating system, to the console.
        /// </summary>
        /// <remarks>This method is intended for informational or diagnostic purposes. It writes device
        /// details and the operating system to the standard output and does not return a value.</remarks>
        public void GetSmartphoneDetails()
        {
            GetDeviceDetails();
            Console.WriteLine($"\nOperating system: {OperatingSystem}");
        }
    }
}
