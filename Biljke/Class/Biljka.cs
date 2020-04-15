using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljke
{
    class Biljka
    {
        public string NazivBiljke { get; set; }
        public Enumeracija.LjekovitostBiljke Ljekovitost { get; set; }
        public Enumeracija.VrstaBiljke Vrsta { get; set; }
        public string OpisBiljke { get; set; }
        public string TemperaturaOdrzavanja { get; set; }
        public string KolicinaVode { get; set; }


    }
}
