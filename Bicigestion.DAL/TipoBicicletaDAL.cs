using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BiciGestion.Entidades;
using System.Configuration;

namespace BiciGestion.DAL
{
    public class TipoBicicletaDAL
    {
        private readonly string connectionString =
    ConfigurationManager.ConnectionStrings["BiciGestion"].ConnectionString;

        public List<Bicicleta> GetAll()
        {
            List<Bicicleta> lista = new List<Bicicleta>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID_TIPO_BICICLETA, DESCRIPCION FROM TIPO_BICICLETA";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["ID_TIPO_BICICLETA"]);
                            string descripcion = reader["DESCRIPCION"].ToString();

                            if (id == 1)
                                lista.Add(new BicicletaUrbana());
                            else if (id == 2)
                                lista.Add(new BicicletaMontana());
                            else if (id == 3)
                                lista.Add(new BicicletaElectrica());
                        }
                    }
                }
            }

            return lista;
        }
    }
}
