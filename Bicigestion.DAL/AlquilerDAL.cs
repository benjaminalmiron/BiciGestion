using BiciGestion.Entidades;
using BiciGestion.Mapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace BiciGestion.DAL
{
    public class AlquilerDAL
    {
        private readonly string connectionString =
        ConfigurationManager.ConnectionStrings["BiciGestion"].ConnectionString;

        public List<Alquiler> GetAll()
        {
            List<Alquiler> lista = new List<Alquiler>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT A.ID_ALQUILER,
                                        A.ID_TIPO_BICICLETA,
                                        T.DESCRIPCION,
                                        A.DNI_CLIENTE,
                                        A.IMPORTE_TOTAL,
                                        A.FECHA_REGISTRO,
                                        A.FECHA_ALQUILER
                                    FROM ALQUILER A
                                    INNER JOIN TIPO_BICICLETA T
                                    ON A.ID_TIPO_BICICLETA = T.ID_TIPO_BICICLETA";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(Mapear(reader));
                        }
                    }
                }
            }

            return lista;
        }

        public Alquiler GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT A.ID_ALQUILER,
                                        A.ID_TIPO_BICICLETA,
                                        T.DESCRIPCION,
                                        A.DNI_CLIENTE,
                                        A.IMPORTE_TOTAL,
                                        A.FECHA_REGISTRO,
                                        A.FECHA_ALQUILER
                                 FROM ALQUILER A
                                 INNER JOIN TIPO_BICICLETA T
                                 ON A.ID_TIPO_BICICLETA = T.ID_TIPO_BICICLETA
                                 WHERE A.ID_ALQUILER = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                            return Mapear(reader);
                    }
                }
            }

            return null;
        }

        public void Insert(Alquiler alquiler)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO ALQUILER
                                (ID_TIPO_BICICLETA, DNI_CLIENTE, IMPORTE_TOTAL,
                                 FECHA_REGISTRO, FECHA_ALQUILER)
                                VALUES
                                (@TIPO, @DNI, @IMPORTE, @FECHA_REGISTRO, @FECHA_ALQUILER)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TIPO", SqlDbType.Int).Value =
                       alquiler.Bicicleta.IdTipoBicicleta;

                    command.Parameters.Add("@DNI", SqlDbType.VarChar, 20).Value =
                        alquiler.DniCliente;

                    SqlParameter importe = command.Parameters.Add("@IMPORTE", SqlDbType.Decimal);
                    importe.Precision = 10;
                    importe.Scale = 2;
                    importe.Value = alquiler.ImporteTotal;

                    command.Parameters.Add("@FECHA_REGISTRO", SqlDbType.DateTime).Value =
                        alquiler.FechaRegistro;

                    command.Parameters.Add("@FECHA_ALQUILER", SqlDbType.Date).Value =
                        alquiler.FechaAlquiler;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Alquiler alquiler)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE ALQUILER
                         SET DNI_CLIENTE = @DNI,
                             IMPORTE_TOTAL = @IMPORTE,
                             FECHA_ALQUILER = @FECHA
                         WHERE ID_ALQUILER = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@DNI", SqlDbType.VarChar, 20).Value =
                        alquiler.DniCliente;

                    SqlParameter importe = command.Parameters.Add("@IMPORTE", SqlDbType.Decimal);
                    importe.Precision = 10;
                    importe.Scale = 2;
                    importe.Value = alquiler.ImporteTotal;

                    command.Parameters.Add("@FECHA", SqlDbType.Date).Value =
                        alquiler.FechaAlquiler;

                    command.Parameters.Add("@ID", SqlDbType.Int).Value =
                        alquiler.IdAlquiler;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM ALQUILER WHERE ID_ALQUILER = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private Alquiler Mapear(SqlDataReader reader)
        {
            return AlquilerMapper.Mapear(
                Convert.ToInt32(reader["ID_ALQUILER"]),
                Convert.ToInt32(reader["ID_TIPO_BICICLETA"]),
                reader["DESCRIPCION"].ToString(),
                reader["DNI_CLIENTE"].ToString(),
                Convert.ToDecimal(reader["IMPORTE_TOTAL"]),
                Convert.ToDateTime(reader["FECHA_REGISTRO"]),
                Convert.ToDateTime(reader["FECHA_ALQUILER"])
            );
        }
    }
}