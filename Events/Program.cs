namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thermometer thermometer = new Thermometer("Cairo");
            Display display = new Display();

            display.subscriber(thermometer);

            thermometer.setTemprature(30);
            thermometer.setTemprature(32);
            thermometer.setTemprature(36);
            thermometer.setTemprature(36);
            Console.ReadLine();





        }
    }
}
