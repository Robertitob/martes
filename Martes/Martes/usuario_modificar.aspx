<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="usuario_modificar.aspx.vb" Inherits="usuario_modificar" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    &nbsp;<asp:Label ID="lb_id" runat="server" Text="Label"></asp:Label><br />
    <asp:Label ID="lb_nombre" runat="server" Text="Label"></asp:Label>&nbsp;<br />
    <asp:Label ID="lb_fecha_registro" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:TextBox ID="txt_correo" runat="server" ValidationGroup="1"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_correo"
        ErrorMessage="Falta correo" ValidationGroup="1"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_correo"
        ErrorMessage="correo incorrecto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        ValidationGroup="1"></asp:RegularExpressionValidator><br />
    <br />
    &nbsp;<asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="1" /><br />
    <br />
</asp:Content>

