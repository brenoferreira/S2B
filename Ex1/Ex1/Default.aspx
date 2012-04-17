<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Ex1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
        <asp:Label Text="Dia" runat="server" />
        <asp:DropDownList ID="diaDrpDwn" runat="server" />
    </div>

    <div>
        <asp:Label ID="Label1" Text="Mes" runat="server" />
        <asp:DropDownList ID="mesDrpDwn" runat="server" />
    </div>

    <div>
        <asp:Label ID="Label2" Text="Ano" runat="server" />
        <asp:DropDownList ID="anoDrpDwn" runat="server" />
    </div>
</asp:Content>
