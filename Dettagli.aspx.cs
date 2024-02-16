using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _16FebbraioTest
{
    public partial class About : Page
    {
        //AL CARICAMENTO DELLA PAGINA SI VISUALIZZANO I DETTAGLI
        protected void Page_Load(object sender, EventArgs e)
        {
            string cookie = Request.QueryString["prodotto"];

            if (Request.Cookies[cookie] != null)
            {
                content.InnerHtml = $"<h3>{Request.Cookies[cookie]["prodotto"]}</h3><img src='{Request.Cookies[cookie]["img"]}' /><p class='fw-bold mt-2'>{Request.Cookies[cookie]["prezzo"]}</p><p>{Request.Cookies[cookie]["dettagli"]}</p> ";
                
            }
        }

        protected void carello_Click(object sender, EventArgs e)
        {
            string cookie = Request.QueryString["prodotto"];
            
            //SE CARTLIST NON ESISTE LO CREA E POI AGGIUNGE I COOKIE ALTRIMENTI LO TROVA E AGGIUNGE I COOKIE
            if (Session["CartList"] == null)
            {
                //creo una lista per inserire i cookies dei prodotti da inserire nel carrello
                List<HttpCookie> CartList = new List<HttpCookie>();
                //aggiungo i cookies nella lista
                CartList.Add(Request.Cookies[cookie]);
                //per inserire la lista nella session
                Session["CartList"] = CartList;
            }
            else
            {
                List<HttpCookie> CartList = (List<HttpCookie>)Session["CartList"];
                CartList.Add(Request.Cookies[cookie]);

                Session["CartList"] = CartList;
            }



        }
    }
}