using System;
using System.Collections;
using System.Configuration;
//Librerias SQL
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso
    {
        private SqlConnection ConectarBD = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaConexionSQL"].ToString());
        private SqlTransaction Transaction;
        private SqlCommand Cmd;

        public string TestConnection()
        {
            ConectarBD.Open();
            if (ConectarBD.State == ConnectionState.Open)
            {
                return "Conexion a la BD OK";
            }
            else
            {
                return "No se pudo conectar a la BD, que pacho???";
            }
        }

        public DataTable Leer(string Consulta, Hashtable Hdatos)
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da;

            try
            {
                //paso la consulta y el objeto conection en el constructor
                Cmd = new SqlCommand(Consulta, ConectarBD);
                Cmd.CommandType = CommandType.StoredProcedure;
                Da = new SqlDataAdapter(Cmd);

                if ((Hdatos != null))
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in Hdatos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }
            }

            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Da.Fill(Dt);
            return Dt;

        }

    }
}
