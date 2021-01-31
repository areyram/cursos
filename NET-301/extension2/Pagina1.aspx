<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="Ventus.Pagina1" %>

<html>
<head>
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<ul>
		<li>Pagina 1</li>
		<li><a href="Pagina2.aspx">Pagina 2</a></li>
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
