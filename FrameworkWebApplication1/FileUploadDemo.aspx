<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="FileUploadDemo.aspx.cs" Inherits="FrameworkWebApplication1.FileUploadDemo" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <hr />
        <asp:Button ID="Button1" runat="server" Text="Upload File" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

    </div>
</asp:Content>