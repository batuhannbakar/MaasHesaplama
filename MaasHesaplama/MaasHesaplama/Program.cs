using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasHesaplama
{
    class Program
    {

        private static double KESINTI = 0.1;

        private static double VERGI = 0.2;

        static void Main(string[] args)
        {
            Console.WriteLine("Net Maaş : "+netMaasHesapla(10000));

            Console.WriteLine("Brüt Maaş : " + recBrutHesapla(7000));

            Console.Read();

            double netMaasHesapla(double brutMaas)
             {
                double toplamKesinti = (brutMaas * KESINTI) + (brutMaas * VERGI);
                double netMaas = brutMaas - toplamKesinti;
                return netMaas;
             }

            double recBrutHesapla(double netMaas)
            {
                double netMaas_ = netMaasHesapla(netMaas * 1.5);
                if (netMaas_ == netMaas)
                    return 0;
                return netMaas + recBrutHesapla(netMaas / 3);
            }


        }
    }
}
