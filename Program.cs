namespace ZakladyOOP_I2B1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Clovek Jonas = new Clovek("Jonáš", "Macoun", 5);
            Jonas.Jmeno = "Jonda"; // set
            Jonas.Vek = 155;
            Console.WriteLine(Jonas.Jmeno); // get

            Jonas.Pozdrav();
        }
    }
}
