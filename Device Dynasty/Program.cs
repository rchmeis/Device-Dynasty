namespace Device_Dynasty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop("15.6", "Dell", "XPS 15", 8000);
            laptop1.GetLaptopDetails();
            //Console.WriteLine(laptop1.ToString());

            Smartphone smartphone1 = new Smartphone("6.5", "Apple", "iPhone 14 Pro Max", 12000);
            smartphone1.GetSmartphoneDetails();
        }
    }
}
