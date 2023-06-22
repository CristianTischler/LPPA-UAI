using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class _Default : System.Web.UI.Page
{
    ClienteBLL GestorCliente = new ClienteBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            

        }
    }
    protected void Page_Unload(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session.Remove("ClienteEncontrado");
        }
    }

    protected void ButtonBuscar_Click(object sender, EventArgs e)
    {
        ClienteBE ClienteEncontrado = (ClienteBE) GestorCliente.BuscarCliente(Convert.ToInt32(TextBoxCodigo.Text));
        if (ClienteEncontrado != null)
        {
            Session.Add("ClienteEncontrado", ClienteEncontrado);
            LabelNombre.Text= ClienteEncontrado.Nombre;
        }
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //if(RadioButtonList1.SelectedIndex == 0)
        //{
        //    LabelNombre.Text = "Cookie";

        //}
        //if (RadioButtonList1.SelectedIndex == 1)
        //{
        //    LabelNombre.Text = "Session";

        //}
        //if (RadioButtonList1.SelectedIndex == 2)
        //{
        //    LabelNombre.Text = "Request";

        //}

    }

    protected void ButtonSiguiente_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            LabelNombre.Text = "Cookie";

            // Convertir el objeto en una cadena JSON
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(Session["ClienteEncontrado"]);

            HttpCookie cookie = new HttpCookie("Cliente");
            cookie.Value = json;
            Response.Cookies.Add(cookie);

            Session.Add("method", 1);
            Response.Redirect("FacturasCliente.aspx");
            
        }
        if (RadioButtonList1.SelectedIndex == 1)
        {
            //LabelNombre.Text = "Session";
            Session.Add("method", 2);
            Session.Add("codigo", TextBoxCodigo.Text);
            Response.Redirect("FacturasCliente.aspx");

        }
        if (RadioButtonList1.SelectedIndex == 2)
        {
            //LabelNombre.Text = "Request";
            Session.Add("method", 3);
            Response.Redirect("FacturasCliente.aspx?codigo="+ TextBoxCodigo.Text);

        }
    }
}