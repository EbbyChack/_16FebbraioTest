<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="_16FebbraioTest.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div class="container">
            <div class="row justify-content-center bg-light p-4 rounded-5">
                <div class="col-auto bg-white p-4 rounded-5 ">
                   <%--CREO UN CONTENITORE VUOTO PER INSERIRE TRAMITE DOM MANIPULATION I DETTAGLI DEL PRODOTTO--%>
                     <div id="content" runat="server" >
                         
                     </div>
                   
                    <asp:Button class="btn btn-light" ID="carello" runat="server" Text="Aggiungi al carrello" OnClick="carello_Click" />
                </div>
            </div>
        </div>
       
    </main>
</asp:Content>
