<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmitData.aspx.cs" MasterPageFile="~/Site.Master" Inherits="FrameworkWebApplication1.SubmitData" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>
            Transferring Data to Another Page
        </h1>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Send Data" OnClick="Button1_Click" />
    </div>
</asp:content>
