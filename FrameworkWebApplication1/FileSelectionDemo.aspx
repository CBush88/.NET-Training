<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FileSelectionDemo.aspx.cs" Inherits="FrameworkWebApplication1.FileSelectionDemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Label ID="Label1" runat="server" Text="Select a file to upload:"></asp:Label>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Next Step" OnClick="Button1_Click" />
    </div>
</asp:Content>
