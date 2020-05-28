using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtonAdmin.Models {
    class Capitulo {
        public Capitulo(int idCapitulo, int idSerie, int numEpisodio, int numTemporada) {
            IdCapitulo = idCapitulo;
            IdSerie = idSerie;
            NumEpisodio = numEpisodio;
            NumTemporada = numTemporada;
        }

        public int IdCapitulo { get; set; }
        public int IdSerie { get; set; }
        public int NumEpisodio { get; set; }
        public int NumTemporada { get; set; }
    }
}
