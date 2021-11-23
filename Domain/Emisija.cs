using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Emisija
    {
        public int EmisijaId { get; set; }
        public string Naziv { get; set; }
        public DateTime VremePocetka { get; set; }
        public DateTime VremeZavrsetka { get; set; }
        public Producent Producent { get; set; }
        public Radnik Voditelj { get; set; }
        public List<Angazovanje> Angazovanja { get; set; }

        public override string ToString()
        {
            return Naziv;
        }

    }
}
