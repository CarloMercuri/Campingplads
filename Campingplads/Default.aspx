<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Campingplads._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div>
       <asp:Button ID="Button1" runat="server" Text="Button" OnClick="btnClick" />
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
     <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
     <asp:TextBox ID="txtTest" runat="server"></asp:TextBox>
 </div>

</asp:Content>

