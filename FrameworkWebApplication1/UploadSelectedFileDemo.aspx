<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadSelectedFileDemo.aspx.cs" Inherits="FrameworkWebApplication1.UploadSelectedFileDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Yes" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" />
    </p>
</asp:Content>
