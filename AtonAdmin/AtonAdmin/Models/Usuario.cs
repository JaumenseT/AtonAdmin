using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtonAdmin.Models {
    class Usuario {
        public Usuario(string name, string userName, int numSeries, int numEpisodios) {
            Name = name;
            UserName = userName;
            NumSeries = numSeries;
            NumEpisodios = numEpisodios;
        }

        public string Name { get; set; }
        public string UserName { get; set; }
        public int NumSeries { get; set; }
        public int NumEpisodios { get; set; }
    }
}
