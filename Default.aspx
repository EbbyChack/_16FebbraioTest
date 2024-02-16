<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_16FebbraioTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h1>Prodotti</h1>
        <%--CREO 4 CARD DI PRODOTTI--%>
        <div class="container">
            <div class="row">
                <div class="col-3">
                    <div class="card">
                        <img class="card-img-top" src="https://www.tradeshopitalia.com/61773-large_default/martello-curvo-con-manico-in-legno-testa-tonda-250gr-per-muratore-carpentiere.jpg" id="Img1" runat="server" alt="Card image cap">
                        <div class="card-body">
                            <h5 class="card-title" runat="server" id="Prodotto1">Martello</h5>
                            <p class="card-text" runat="server" id="Prezzo1">20 euro</p>
                            <p class="d-none" runat="server" id="Dettagli1">Un buon martello</p>
                            <asp:Button class="btn btn-light" ID="Button1" runat="server" Text="Pagina dettagli" OnClick="Button1_Click"/>
                        </div>
                    </div>
                </div>
                <div class="col-3">
                    <div class="card">
                        <img class="card-img-top" src="https://www.faccohotel.com/foto/prodotti/750/750/061523-piatto-pasta-napoli-bowl-cm-26-5-saturnia.jpg" id="Img2" runat="server" alt="Card image cap">
                        <div class="card-body">
                            <h5 class="card-title" runat="server" id="Prodotto2">Piatto</h5>
                            <p class="card-text" runat="server" id="Prezzo2">5 euro</p>
                            <p class="d-none" runat="server" id="Dettagli2">Fatto di ceramica</p>
                            <asp:Button class="btn btn-light" ID="Button2" runat="server" Text="Pagina dettagli" OnClick="Button2_Click" />
                        </div>
                    </div>
                </div>
                <div class="col-3">
                    <div class="card">
                        <img class="card-img-top" src="https://medias.maisonsdumonde.com/image/upload/f_auto,q_auto,w_732/v1/img/tavolo-per-sala-da-pranzo-in-massello-di-legno-di-sheesham-180-cm-1000-2-7-140473_3.jpg" id="Img3" runat="server" alt="Card image cap">
                        <div class="card-body">
                            <h5 class="card-title" runat="server" id="Prodotto3">Tavolo</h5>
                            <p class="card-text" runat="server" id="Prezzo3">50 euro</p>
                            <p class="d-none" runat="server" id="Dettagli3">Fatto di legno</p>
                            <asp:Button class="btn btn-light" ID="Button3" runat="server" Text="Pagina dettagli" OnClick="Button3_Click" />
                        </div>
                    </div>
                </div>
                <div class="col-3">
                    <div class="card">
                        <img class="card-img-top" src="https://www.ikea.com/it/it/images/products/blidvaeder-lampada-da-tavolo-bianco-sporco-ceramica-beige__1059594_pe849715_s5.jpg?f=s" id="Img4" runat="server" alt="Card image cap">
                        <div class="card-body">
                            <h5 class="card-title" runat="server" id="Prodotto4">Lampada</h5>
                            <p class="card-text" runat="server" id="Prezzo4">30 euro</p>
                            <p class="d-none" runat="server" id="Dettagli4">Si accende e si spegne</p>
                            <asp:Button class="btn btn-light" ID="Button4" runat="server" Text="Pagina dettagli" OnClick="Button4_Click" />
                        </div>
                    </div>
                </div>

            </div>

        </div>

    </main>

</asp:Content>
