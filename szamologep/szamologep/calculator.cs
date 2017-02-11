using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
    class calculator
    {
        public static double Osszead(double egyikszam, double masikszam)
        {
            return egyikszam + masikszam;
        }
        public static double Kivon(double egyikszam, double masikszam)
        {
            return egyikszam - masikszam;
        }
        public static double Szorzas(double egyikszam, double masikszam)
        {
            return egyikszam * masikszam;
        }
        public static double Osztas(double egyikszam, double masikszam)
        {
            return egyikszam / masikszam;
        }
        public static double C(double egyikszam, double masikszam)
        {
            return 0;
                       
        }
        public static double CE(double egyikszam, double masikszam)
        {
            return egyikszam;
            
        }
    }
}

