using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Ventus
{
    public partial class Pagina2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            rpt.DataSource = new List<Entidad>
            {
                new Entidad {ID = 1, Descripcion = "Descripcion 1"},
                new Entidad {ID = 2, Descripcion = "Descripcion 2"},
                new Entidad {ID = 3, Descripcion = "Descripcion 3"},
                new Entidad {ID = 4, Descripcion = "Descripcion 4"},
                new Entidad {ID = 5, Descripcion = "Descripcion 5"},
            };
            rpt.DataBind();
        }

        protected void rpt_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            var o = e.Item.DataItem as Entidad;

            e.With<HtmlInputButton>("boton",
                boton => boton.Attributes["onclick"] = "alert('Editar " + o.ID + "')");
            e.With<Label>("descripcion",
                descripcion => descripcion.Text = string.Format("[{0}] {1}", o.ID, o.Descripcion));
        }
    }
}
