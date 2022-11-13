using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje1
{
    class NebeskoTijelo
    {
        double brzinaOkoOsi, brzinaOkoSunca;

        public double BrzinaOkoOsi { get => brzinaOkoOsi; set => brzinaOkoOsi = value; }
        public double BrzinaOkoSunca { get => brzinaOkoSunca; set => brzinaOkoSunca = value; }

       
    }

    class Planet : NebeskoTijelo
    {
        public Planet(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi = brzinaOkoOsi;
            BrzinaOkoSunca = brzinaOkoSunca;
        }

        public override string ToString()
        {
            return "Zemlja se oko svoje osi okreće: " + BrzinaOkoOsi 
                + " m/s, a oko sunca se okreće: " + BrzinaOkoSunca + " km/s";
        }

    }

    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi = brzinaOkoOsi;
            BrzinaOkoSunca = brzinaOkoSunca;
        }

        public override string ToString()
        {
            return "Mjesec se oko svoje osi okreće: "+ BrzinaOkoOsi 
               + " km/s, a oko sunca se okreće: " + BrzinaOkoSunca + "km/s";
        }

    }

    internal class Program
    {
        static void Main()
        {
            Planet Zemlja = new Planet(460, 30);
            Satelit Mjesec = new Satelit(1, 30);

            Console.WriteLine(Zemlja.ToString());
            Console.WriteLine(Mjesec.ToString());

            Console.ReadKey();

        }
    }
}