using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtonAdmin.Models;
using MySql.Data.MySqlClient;

namespace AtonAdmin.Repositories {
    class UsuariosRepository {
        internal static List<Usuario> GetDatabaseUsers() {
            using (MySqlConnection con = Database.GetConnection()) {
                List<Usuario> usuarios = new List<Usuario>();
                con.Open();
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "select userName, name, (select count(*) from usuarioSeries us where us.idUsuario=u.id) as numSeries, " +
                    "(select count(*) from usuarioCapitulo uc where uc.IdUsuario=u.id) as numEpisodios from usuarios u order by userName";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    usuarios.Add(new Usuario(reader.GetString("name"), reader.GetString("userName"), 
                        reader.GetInt32("numSeries"), reader.GetInt32("numEpisodios")));
                }
                return usuarios;
            }
        }
    }
}
