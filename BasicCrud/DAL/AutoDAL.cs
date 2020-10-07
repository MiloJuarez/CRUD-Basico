using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BasicCrud.BLL;

namespace BasicCrud.DAL
{
    class AutoDAL
    {
        public bool InsertAuto(Auto auto, SqlConnection connection)
        {
            try {
                string stmt = "INSERT INTO autos(marca,modelo,anio,precio,fecha_venta) VALUES('" +
                    auto.Marca +"','"+ auto.Modelo + "'," + auto.Anio + "," +  auto.Precio + ",'" +
                    auto.FechaVenta + "')";

                SqlCommand command = new SqlCommand();
                command.CommandText = stmt;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
        } catch
            {
                return false;
            } finally
            {
                connection.Close();
            }

        }

        public bool UpdateAuto(Auto auto, SqlConnection connection)
        {
            try
            {
                string stmt = "UPDATE autos SET marca = '" + auto.Marca + "', modelo='" + auto.Modelo +"',anio="
                    + auto.Anio +",precio=" + auto.Precio +",fecha_venta='" + auto.FechaVenta +"' WHERE id = " + auto.ID;
                SqlCommand command = new SqlCommand();
                command.CommandText = stmt;
                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            } catch
            {
                return false;
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

        public DataSet QueryData(SqlConnection connection, string field, string value)
        {
            string campo = field, valor = value;
            string stmt = "";
            if(field.Length > 0 && value.Length > 0)
            {
                if (campo.Contains("ñ"))
                {
                    campo = "anio";
                }
                else if (campo.Contains(" "))
                {
                    campo = "fecha_venta";
                }
                stmt = "SELECT * FROM autos WHERE "+campo+" LIKE '%"+valor+"%'";
            }
            else
            {
                stmt = "SELECT * FROM autos";
            }
                DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(stmt);
                sqlCommand.Connection = connection;
                adapter.SelectCommand = sqlCommand;
                connection.Open();
                adapter.Fill(dataSet);
                connection.Close();
                return dataSet;
            } catch
            {
                return dataSet;
            }
        }


    }
}
