namespace ZakladyOOP_I2B1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Clovek Jonas = new Clovek("Jonáš", "Macoun", 5);
            Clovek Honza = new Clovek("Jan", "Novák", 6);

            string vystup = Jonas.Pozdrav("Ahoj", Honza.Jmeno);
            Console.WriteLine(vystup);
            vystup = Honza.Pozdrav("Nazdárek", Jonas.Jmeno);
            Console.WriteLine(vystup);


        }
    }
}
