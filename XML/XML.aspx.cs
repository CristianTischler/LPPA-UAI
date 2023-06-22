using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class XML : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlTextReader miLector = new XmlTextReader(Server.MapPath("Inventario.xml"));
        int n;
        while (miLector.Read())
        { 
            Response.Write(miLector.NodeType.ToString() + ": " + miLector.Name + ": " + miLector.Value + "<br/>");
            if(miLector.HasAttributes)
            {
                for (n = 0; n < miLector.AttributeCount; n++)
                {
                    miLector.MoveToAttribute(n);
                    Response.Write("<br/>"+miLector.NodeType.ToString() + ": " + miLector.Name + ": " + miLector.Value + "<br/>");
                }
                miLector.MoveToElement();
            }
        }
        miLector.Close();
    }
}