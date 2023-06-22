using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BLL2
{
    public class FacturasBLL
    {
        Acceso ConectarBD;
        public FacturasBLL()
        {
            ConectarBD = new Acceso();
        }

        public List<FacturaBE> Listar(int id)
        {
            Hashtable Hdatos = new Hashtable();
            List<FacturaBE> ListaFacturas = new List<FacturaBE>();

            DataTable Tabla;
            ConectarBD = new Acceso();
            string Consulta = "S_ObtenerFacturasCliente";
            Hdatos.Add("@IdCliente", id);
            Tabla = ConectarBD.Leer(Consulta, Hdatos);


            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    FacturaBE factura = new FacturaBE();
                    factura.NroFactura= Convert.ToInt32(fila["NroFactura"]);
                    factura.Fecha = Convert.ToDateTime(fila["Fecha"]);
                    factura.IdCliente = Convert.ToInt32(fila["ClienteID"]);
                    factura.Total = float.Parse (fila["Total"].ToString());


                    ListaFacturas.Add(factura);
                }
            }
            else
            {
                ListaFacturas = null;
            }
            return ListaFacturas;
        }
    }
}
