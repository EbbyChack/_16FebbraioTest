<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="_16FebbraioTest.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="d-flex justify-content-between">
            <h2>Carrello</h2>
            <asp:Button ID="DeleteButton" runat="server" Text="Svuota il carrello" OnClick="DeleteButton_Click" CssClass="btn btn-danger" />
        </div>
        <div class="row" id="cartItems" runat="server">
            <%--SE NON CI SONO PRODOTTI SI VEDE QUESTO MESSAGGIO--%>
            <h3>Non ci sono prodotti nel carrello.</h3>
        </div>
    </div>
</asp:Content>
