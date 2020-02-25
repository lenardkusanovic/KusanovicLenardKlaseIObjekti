using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KusanovicLenardKlaseIObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Zrakoplov x380 = new Zrakoplov();

            x380.setNaziv("Airbus");
            x380.setDometLeta(6000);
            x380.setSnagaMotora(2000);

            Console.WriteLine("\nNaziv: " + x380.getNaziv() + "\nSnaga: " + x380.getSnagaMotora()
                + "\nDomet leta: "+ x380.getDometLeta()+ "km");

            Zrakoplov PU123RO = new Zrakoplov("Cessna", 350, 125);

            
            Console.WriteLine(PU123RO.ToString());

            Zrakoplov x328 = new Zrakoplov("New Machine", 5000);
            Console.WriteLine("\nUpisite koliko km moze preci zrakoplov New Machine: ");
            x328.setDometLeta(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(x328.ToString());

            Console.ReadKey();
        }
    }
}
