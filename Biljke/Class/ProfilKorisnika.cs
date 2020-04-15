using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljke
{
    class ProfilKorisnika
    {
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
        public Enumeracija.Obavijesti Obavijesti {get; set; }
    }
}
