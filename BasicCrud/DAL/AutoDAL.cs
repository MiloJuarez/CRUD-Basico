using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BasicCrud.BLL;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace BasicCrud.DAL
{
    class AutoDAL
    {
        public static string pathImageFolder = Path.GetDirectoryName(Application.StartupPath) + @"\CarImages\";
        public int InsertUpdateAuto(Auto auto, SqlConnection connection)
        {
            try
            {
                int rowAffected = 0;
                connection.Open();
                SqlCommand command = new SqlCommand("InsertUpdateAuto", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Id", SqlDbType.Int).Value = auto.ID;
                command.Parameters.Add("@Marca", SqlDbType.VarChar).Value = auto.Marca;
                command.Parameters.Add("@Modelo", SqlDbType.VarChar).Value = auto.Modelo;
                command.Parameters.Add("@Anio", SqlDbType.Int).Value = auto.Anio;
                command.Parameters.Add("@Precio", SqlDbType.Decimal).Value = auto.Precio;
                command.Parameters.Add("@FechaVenta", SqlDbType.VarChar).Value = auto.FechaVenta;
                command.Parameters.Add("@Imagen", SqlDbType.VarChar).Value = auto.Imagen;
                command.Parameters.Add("@Detalle", SqlDbType.Text).Value = auto.Detalles;
                rowAffected = command.ExecuteNonQuery();
                return rowAffected;
            } catch
            {
                return 0;
            } finally
            {
                connection.Close();
            }
        }

        public bool deleteAuto(int id, SqlConnection con)
        {
            try
            {
                string stmt = "DELETE FROM autos WHERE id="+id;
                SqlCommand command = new SqlCommand(stmt, con);
                command.CommandText = stmt;
                command.Connection = con;
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                return true;
            } catch
            {
                return false;
            }
        }

        public List<Auto> GetAll(SqlConnection connection)
        {

            List<Auto> _autos = new List<Auto>();
            using (SqlConnection con =  ConnectionDAL.GetConnection())
            {
                if (con != null)
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        string stmt = "SELECT * FROM autos ORDER BY id DESC";
                        SqlCommand command = new SqlCommand(stmt, con);
                        SqlDataReader dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            _autos.Add(GetAuto(dataReader));
                        }
                        con.Close();
                    }
                }
            }
            return _autos;
        }

        private Auto GetAuto(IDataReader reader)
        {
            Auto auto = new Auto
            {
                ID = Convert.ToInt32(reader["id"]),
                Marca = Convert.ToString(reader["marca"]),
                Modelo = Convert.ToString(reader["modelo"]),
                Anio = Convert.ToInt32(reader["anio"]),
                Precio = Convert.ToDouble(reader["precio"]),
                FechaVenta = Convert.ToString(reader["fecha_venta"]),
                Imagen = Convert.ToString(reader["imagen"]),
                Detalles = Convert.ToString(reader["detalle"]),
            };
            return auto;
        }
    }
}
