using OOS18;
using System;

namespace CPiste
{
    class Program
    {
        static void Main(string[] args)
        {
            //luodaan Piste-olioita ja tulostetaan niiden etäisyydet origosta
            Piste piste1 = new Piste(); //oletusmuodostimella muodostettu, nimetty olio
            double pituus1 = piste1.Pituus(); //olion palvelua kutsutaan ja palautusarvo asetetaan muuttujan arvoksi
            Console.WriteLine($"pisteen 1 etäisyys origosta on {pituus1}");
            Piste piste2 = new Piste(3, 4); //parametroidulla muodostimella muodostettu, nimetty olio
            double pituus2 = piste2.Pituus(); //olion palvelua kutsutaan ja palautusarvo asetetaan muuttujan arvoksi
            Console.WriteLine($"pisteen 2 etäisyys origosta on {pituus2}");
            double pituus3 = new Piste().Pituus(); //oletusmuodostimella muodostettu, nimetty olio, 
                                                   //jonka palvelua kutsutaan ja palautusarvo asetetaan muuttujan arvoksi
            Console.WriteLine($"pisteen 3 etäisyys origosta on {pituus3}");
            double pituus4 = new Piste(7, 1).Pituus(); //parametroidulla muodostimella muodostettu, nimetön olio, 
                                                       //jonka palvelua kutsutaan ja palautusarvo asetetaan muuttujan arvoksi
            Console.WriteLine($"pisteen 3 etäisyys origosta on {pituus4}");           
        }
    }
}