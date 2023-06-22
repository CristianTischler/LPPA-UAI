using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class ClienteBLL
    {
        Acceso ConectarBD;
        public ClienteBLL()
        {
            ConectarBD = new Acceso();
        }
        public ClienteBE BuscarCliente(int id)
        {
            Hashtable Hdatos = new Hashtable();
            string Consulta = "S_Cliente_BuscarPorCodigo";
            Hdatos.Add("@ID", id);
            DataTable Tabla = ConectarBD.Leer(Consulta, Hdatos);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    ClienteBE NuevoClienteBE = new ClienteBE();
                    NuevoClienteBE.Id = Convert.ToInt32(fila["id"]);
                    NuevoClienteBE.Nombre = fila["Nombre"].ToString();
                    NuevoClienteBE.Cuit = fila["Cuit"].ToString();

                    return NuevoClienteBE;

                }
            }
            return null;
        }
    }
}
