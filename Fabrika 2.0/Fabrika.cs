using System;
using System.Collections.Generic;

namespace Fabrika_2._0
{
    class Fabrika
    {
        public Rabotnik Vraboten { get; set; }
        public int BrojNaVraboteni { get; set; }

         public Fabrika()
        {


        }

      public  Fabrika(Rabotnik vraboten, int brojNaVraboteni)
        {
            Vraboten = vraboten;
            BrojNaVraboteni = brojNaVraboteni;
        }

        Rabotnik rabotnik = new Rabotnik();
        public void PecatiVraboteni(Rabotnik Vraboten)
        {

            foreach (var item in Vrabotenii)
            {
                Console.WriteLine(Vraboten);

            }
        }

        public string VnesiBrojNaVraboteni(string vraboteni)
            {
                vraboteni = Console.ReadLine();
                return vraboteni;

            }
        
        public void KreirajObjekti()
        {
            
            for (int i = 0; i < BrojNaVraboteni; i++)
            {
                Console.WriteLine("Vnesi Ime");
                rabotnik.Ime = Console.ReadLine();
                Console.WriteLine("Vnesi Prezime");
                rabotnik.Prezime = Console.ReadLine();
                Console.WriteLine("Vnesi Plata");
                
            }
            
        }

        List<string> Vrabotenii = new List<string>();


        public int Parsiranje(string vraboteni)
        {
                if (int.TryParse(VnesiBrojNaVraboteni(vraboteni), out int Vraboteni))
                    return Vraboteni;
                return 0;
            
        }

        public void VnesiMinimalnaPlata (string minimalnaPlata)
        {
            Console.WriteLine("Vnesi minimalna plata");
            minimalnaPlata = Console.ReadLine();

        }
        
        public void PecatiSoMinimalna (string minimalnaPlata)
        {
            foreach (var vraboten in Vrabotenii)
            {
                Console.WriteLine($"Vraboteniot {Vraboten} ima pogolema" +
                    $"minimalna plata od {minimalnaPlata}");
            }

        }
    }
    }

