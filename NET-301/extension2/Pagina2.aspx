<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Pagina2.aspx.cs" Inherits="Ventus.Pagina2" %>

<html>
<head>
	<title></title>
</head>
<body>
	<form runat="server">
	<ul>
		<li><a href="Pagina1.aspx">Pagina 1</a></li>
		<li>Pagina 2</li>
	</ul>
	<asp:Label ID="Label1" runat="server" Font-Size="18pt" Text="Label" />
	<br />
	<asp:Repeater runat="server" ID="rpt" OnItemDataBound="rpt_ItemDataBound">
		<ItemTemplate>
			<div>
				<asp:Label runat="server" ID="descripcion" />
				<input type="button" runat="server" id="boton" />
			</div>
		</ItemTemplate>
	</asp:Repeater>
	</form>
</body>
</html>
