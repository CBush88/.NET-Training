<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" MasterPageFile="~/Site.Master" Inherits="FrameworkWebApplication1.WebForm1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


<!DOCTYPE html>

    <div>
        <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Description: "></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" UseSubmitBehavior="False" />
        <br />
        <br />
        <asp:Label ID="Output" runat="server"></asp:Label>

    </div>
</asp:Content>
