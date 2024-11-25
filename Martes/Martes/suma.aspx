<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="suma.aspx.vb" Inherits="suma" title="Untitled Page" %>

<%@ Register Src="controls/wuc_profesiones_lista.ascx" TagName="wuc_profesiones_lista"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="txt_valor2" runat="server"></asp:TextBox>
    <asp:TextBox ID="txt_valor1" runat="server" Font-Bold="True"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:TextBox ID="txt_resultado" runat="server"></asp:TextBox><br />
    <br />
    <uc1:wuc_profesiones_lista ID="Wuc_profesiones_lista1" runat="server" />
    <uc1:wuc_profesiones_lista ID="Wuc_profesiones_lista2" runat="server" />
    <uc1:wuc_profesiones_lista ID="Wuc_profesiones_lista3" runat="server" />
    <br />
    <uc1:wuc_profesiones_lista ID="Wuc_profesiones_lista4" runat="server" />
    <br />
    <br />
    <asp:TextBox ID="txt_valores" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Button" />
</asp:Content>

