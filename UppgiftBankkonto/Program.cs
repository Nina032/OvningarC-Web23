namespace UppgiftBankkonto
{
    public class Bankkonto
    {
        private string kontonummer;
        private string kontoinnehavare;
        private double saldo;

        public Bankkonto(string kontonummer, string kontoinnehavare)
        {
            this.kontonummer = kontonummer;
            this.kontoinnehavare = kontoinnehavare;
            this.saldo = 0;
        }
        public void SättSaldo (double saldo)
        {
            this.saldo = saldo; 
        }
        public double HämtaSaldo() 
        {
            return saldo;
        }
        public void Insättning(double belopp)
        {
            saldo += belopp;
        }
        public void Uttag(double belopp)
        {
            if (saldo >= belopp)
            {
                saldo -= belopp;
            }
            else
            {
                Console.WriteLine("Otillräckligt saldo för uttag!");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankkonto konto = new Bankkonto("123456", "John Doe");
            konto.SättSaldo(1000);
            Console.WriteLine("Saldo före insättning: " + konto.HämtaSaldo());
            Console.WriteLine("Sätt pengar: ");
            double insatt = double.Parse(Console.ReadLine());
            konto.Insättning(insatt);
            Console.WriteLine("Saldo efter insättning: " + konto.HämtaSaldo());
            konto.Uttag(200);
            Console.WriteLine("Saldo efter uttag: " + konto.HämtaSaldo());
        }
    }
}