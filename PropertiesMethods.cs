using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nimiavaruus on luokkien kokoelma
namespace PropertiesMethods
{
    // class = luokka. sisältää koodia (ominaisuuksia ja metodeja)
    class Program
    {
        // Main on Program-luokan metodi (pääohjelma)
        // Ohjelman suoritus (run) alkaa pääohjelmasta
        static void Main(string[] args)
        {
            // Console on luokka ja WriteLine on metodi Console-luokan sisällä
            // Metodin lopussa on kaarisulkumerkit (parenthesis)
            // Sulkujen sisällä olevaa sanotaan (parametriksi, argument)
            Console.WriteLine(); // rivinvaihto
            // WriteLine yhdellä parametrillä
            Console.WriteLine("Mukava aamu");
            // WriteLine kahdella parametrillä
            Console.WriteLine("Luku {0}", 1234);
            // Beep metodin ensimmäinen parametri on äänen korkeus
            // ja toinen parametri on kesto (ms)
            Console.Beep(442, 2000);
            // Consoleen liittyvät ominaisuudet (properties, jakoavain)
            // Ominaisuuden BackgroundColor arvo (get osa)
            // Ominaisuuden BackgroundColor arvo
            Console.WriteLine(Console.BackgroundColor); // >> Black
            // Asetetaan ominaisuudelle uusi arvo (set osa)
            Console.BackgroundColor = ConsoleColor.Magenta;
            // Asetetaan kirjoitusväri
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("So Much Wow"); // Magenta tausta, teksti musta
            // aikaa käsittelevä luokka DateTime
            // Ominaisuus Today
            Console.WriteLine(DateTime.Today);
            // Ominaisuus now
            Console.WriteLine(DateTime.Now);




        }
    }
}
