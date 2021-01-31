using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ventus
{
	public partial class Class1
	{
		private delegate int Binario(int a, int b);

		public static void Test()
		{
			Binario suma = (a, b) => a + b;
			var x = suma(10, 20);
		}

		public static void Test3()
		{
			var item = new Label();
			var cliente = new Cliente();

			var txtNombre = item.FindControl("txtNombre") as TextBox;
			if (txtNombre != null)
				txtNombre.Text = cliente.Nombre;

			item.With<TextBox>("txtNombre", o => o.Text = cliente.Nombre);
		}
	}



	public class Cliente
	{
		public string Nombre { get; set; }
	}


    internal static class Extension
    {
		public delegate void DoSomething<T>(T o);

		public static void With<T>(this Control item, string id, DoSomething<T> fn) where T : class
		{
			var o = item.FindControl(id) as T;
			if (o != null && fn != null) fn(o);
		}
	}


}
