using OOS18;
using System;

namespace CPiste
{
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan Piste-olioita ja tulostetaan niiden etäisyydet origosta
            //oletusmuodostimella muodostettu, nimetty olio
            Console.WriteLine("Tervetuloa pisteiden etäisyyttä laskevaan ohjelmaan!");

            Piste piste1 = new Piste(2, 3);
            Piste piste2 = new Piste(3, 4);

            Program p = new Program();
            p.Etäisyys(piste1, piste2);
            double pituus1 = piste1.Pituus(); //olion palvelua kutsutaan ja palautusarvo asetetaan muuttujan arvoksi
            Console.WriteLine($"pisteen 1 etäisyys origosta on {pituus1}");


            //parametroidulla muodostimella muodostettu, nimetty olio
            double pituus2 = piste2.Pituus(); //olion palvelua kutsutaan ja palautusarvo asetetaan muuttujan arvoksi
            Console.WriteLine($"pisteen 2 etäisyys origosta on {pituus2}");


            double pituus3 = new Piste().Pituus(); //oletusmuodostimella muodostettu, nimetty olio, 
                                                   //jonka palvelua kutsutaan ja palautusarvo asetetaan muuttujan arvoksi

            pituus3 = new Piste(4, 6).Pituus();

            Console.WriteLine($"pisteen 3 etäisyys origosta on {pituus3}");
            double pituus4 = new Piste(7, 1).Pituus(); //parametroidulla muodostimella muodostettu, nimetön olio, 
                                                       //jonka palvelua kutsutaan ja palautusarvo asetetaan muuttujan arvoksi
            Console.WriteLine($"pisteen 4 etäisyys origosta on {pituus4}");

            double Kolmionpintaala(Piste pituus5, Piste pituus6, Piste pituus7);
            {
                double pituus5 = new Piste(2, 3).Pituus();
                double pituus6 = new Piste(3, 4).Pituus();
                double pituus7 = new Piste(6, 8).Pituus();


                double kolmionpintaala = Math.Sqrt(piiri * (piiri - pituus5) * (piiri - pituus6) * (piiri - pituus7));

                return kolmionpintaala;
            }
        }
        private double Etäisyys(Piste piste1, Piste piste2)
        {
            double väli1 = Math.Pow((piste1.X - piste2.X), 2);
            double väli2 = Math.Pow((piste1.Y - piste2.Y), 2);
            double pituus = Math.Sqrt(väli1 + väli2);

            return pituus;
        }
    }
}
