using AtonAdmin.Models;
using AtonAdmin.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtonAdmin {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            RefrescaDatos();
        }

        private void RefrescaDatos() {
            List<Usuario> datos = UsuariosRepository.GetDatabaseUsers();
            int totalSeries = 0;
            int totalEpisodios = 0;
            for (int i = 0; i < datos.Count; i++) {
                totalSeries += datos[i].NumSeries;
                totalEpisodios += datos[i].NumEpisodios;
            }
            this.SeriesVistas.Text = "" + totalSeries;
            this.EpisodiosVistos.Text = "" + totalEpisodios;
            this.ListaUsuarios.DataSource = datos;
        }

        private void button1_Click(object sender, EventArgs e) {
            RefrescaDatos();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
