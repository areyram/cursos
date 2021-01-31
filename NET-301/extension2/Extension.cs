using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ventus
{
    public static class Extension
    {
        public static void With<T>(this Control item, string id, Action<T> action) where T : class
        {
            var o = item.FindControl(id) as T;
            if (o != null && action != null) action(o);
        }

        public static void With<T>(this RepeaterItemEventArgs e, string id, Action<T> action) where T : class
        {
            e.Item.With(id, action);
        }
    }
}