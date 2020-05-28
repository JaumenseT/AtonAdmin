using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtonAdmin.Models {
    class Serie {
        public Serie(int idSerie, int seriesName) {
            IdSerie = idSerie;
            SeriesName = seriesName;
        }

        public int IdSerie { get; set; }
        public int SeriesName { get; set; }
    }
}
