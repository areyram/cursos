using System;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web.UI.WebControls;

namespace Ventus
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var t = typeof(HatchStyle);
            TableRow tr = null;
            var i = 0;
            foreach (var v in t.GetEnumNames().Where(o => !o.Equals("Min") && !o.Equals("Max")).OrderBy(o => o))
            {
                if (i % 8 == 0)
                    tr = new TableRow();
                var td = new TableCell { HorizontalAlign = HorizontalAlign.Center };
                td.Controls.Add(new Image { ImageUrl = "HatchImage.ashx?v=" + v });
                td.Controls.Add(new Label { Text = v });
                tr.Cells.Add(td);
                if (i % 8 == 0)
                    table.Rows.Add(tr);
                i++;
            }
        }
    }
}
