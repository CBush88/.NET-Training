<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FrameworkWebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <input id="Text1" type="text" />
    <asp:Button ID="Button1" runat="server" Text="Button" UseSubmitBehavior="False" OnClick="Button1_Click" />

    <asp:CheckBox ID="CheckBox1" runat="server" Text="InActive" AutoPostBack="True" />

</asp:Content>
