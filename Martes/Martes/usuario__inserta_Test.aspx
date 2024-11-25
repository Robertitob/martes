<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="usuario__inserta_Test.aspx.vb" Inherits="usuario__inserta_Test" title="Untitled Page" %>

<%@ Register Src="controls/wuc_profesiones_lista.ascx" TagName="wuc_profesiones_lista"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="txt_nombre" runat="server" ValidationGroup="1"></asp:TextBox>
    <asp:TextBox ID="txt_correo" runat="server" ValidationGroup="1"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="1" />&nbsp;<br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_nombre"
        ErrorMessage="Falta nombre" ValidationGroup="1"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_correo"
        ErrorMessage="Correo incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        ValidationGroup="1"></asp:RegularExpressionValidator><br />
    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_correo"
        ErrorMessage="falta correo" ValidationGroup="1"></asp:RequiredFieldValidator>
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="1" />
    <br />
    <uc1:wuc_profesiones_lista ID="Wuc_profesiones_lista1" runat="server" />
    <br />
    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84"
        BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    &nbsp;
    <asp:TextBox ID="txt_Cadena" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Button" /><br />
    <asp:Label ID="Label1" runat="server" Text="Resultados Busqueda"></asp:Label><br />
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="rpt_lista_usuarios.aspx"
        Target="_blank">Imprime Reporte</asp:HyperLink><br />
    <br />
</asp:Content>

