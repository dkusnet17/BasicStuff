using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saippuakauppias
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "saippuakauppias";
            // tulosta s:n 3. merkki
            Console.WriteLine(s[2]); // >> 1
            // 1. merkki alkaa indeksistä nolla
            // sanan pituus
            Console.WriteLine(s.Length); // 15
            // s:n viimeinen merkki
            Console.WriteLine(s[s.Length - 1]); // >> 5
            // Osamerkkijono
            Console.WriteLine(s.Substring(2, 4)); // >> ippu
                                                  // Ville-tehtävissä Substring toimii eri tavalla
                                                  // 2 on alkuindeksi, mutta 4-1 on loppuindeksi
                                                  // Tulos on Javassa ip
        }
    }
}
