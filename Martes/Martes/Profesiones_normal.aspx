<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Profesiones_normal.aspx.vb" Inherits="Profesiones_normal" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DropDownList ID="list_profesiones" runat="server">
    </asp:DropDownList>&nbsp;<br />
    <asp:Button ID="Button1" runat="server" Text="Button" /><br />
    <asp:Label ID="Label1" runat="server" Text="Valor Seleccionado"></asp:Label>
    <asp:TextBox ID="txt_valor" runat="server"></asp:TextBox><br />
    <br />
</asp:Content>

