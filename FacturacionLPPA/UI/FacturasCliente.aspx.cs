using BE;
using BLL2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FacturasCliente : System.Web.UI.Page
{
    FacturasBLL GestorFacturas = new FacturasBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["method"] != null)
            {
                List<FacturaBE> ListaFacturas = new List<FacturaBE>();
                switch (Session["method"])
                {
                    case 1:
                        //COOKIE METHOD
                        if (Request.Cookies["Cliente"] != null)
                        {
                            string json = Request.Cookies["Cliente"].Value;

                            // Convertir la cadena JSON en una instancia de la clase
                            ClienteBE miObjeto = Newtonsoft.Json.JsonConvert.DeserializeObject<ClienteBE>(json);
                            LabelNombre.Text = miObjeto.Nombre;
                            ListaFacturas = GestorFacturas.Listar(miObjeto.Id);

                        }
                        break;
                    case 2:
                        int codigoo = Convert.ToInt32(Session["codigo"]);
                        ListaFacturas = GestorFacturas.Listar(codigoo);

                        break;
                    case 3:
                        string codigo = Request.QueryString["codigo"];
                        ListaFacturas = GestorFacturas.Listar(Convert.ToInt32( codigo));

                        break;
                }
                        GridView1.DataSource = ListaFacturas;
                        GridView1.DataBind();
            }
            
        }
    }
}