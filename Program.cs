namespace ZakladyOOP_I2B1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Clovek Jonas = new Clovek("Jonáš", "Macoun", 5);
            Clovek Honza = new Clovek("Jan", "Novák", 6);
            Clovek Vasek = new("Vašek", "Doškář", 39);

            Console.WriteLine(Jonas.Pozdrav("Ahoj", Honza));          
            Console.WriteLine( Vasek.Pozdrav("Čusik", Jonas));


        }
    }
}
