namespace Fabrika_2._0
{
    public class Rabotnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Plata { get; set; }

       public Rabotnik()
        { 
        }

        public Rabotnik(string ime, string prezime, int plata)
        {
            Ime = ime;
            Prezime = prezime;
            Plata = plata;

        }

      public int getPlata()
        {
            return Plata;
        }

        public void pecati()
        {

            System.Console.Write($"Rabotnikot so ime i prezime {Ime} {Prezime} zema plata od {Plata}");

        }

    }
}
