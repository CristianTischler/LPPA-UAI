using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            string nombre= Request.Form["nombre"];
            txtNombre.Value= nombre;
            string apellido = Request.Form["apellido"];
            txtApellido.Value= apellido;
            string email = Request.Form["email"];
            txtEmail.Value= email;
            string musica = Request.Form["opcionMusica"];
            string deporte = Request.Form["opcionDeporte"];
            string tecnologia = Request.Form["opcionTecnologia"];
            string juego = Request.Form["opcionJuegos"];
            txtTemas.Value = (musica != "" ? (", " + musica) : "") + (deporte != "" ? (", " + deporte) : "") + (tecnologia != "" ? (", " + tecnologia): "") + (juego!="" ? (", "+juego) : "");
            string comentario = Request.Form["comentarios"];
            txtComentario.Value= comentario;
            string pais = Request.Form["pais"];
            txtPais.Value= pais;
        }
    }
}