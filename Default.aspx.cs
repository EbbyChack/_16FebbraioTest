using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _16FebbraioTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //ANDANDO A CLICCARE IL PULSANTE DETTAGLI VIENE CREATO UN COOKIE E TI PORTA SULLA PAGINA DEI DETTAGLI DI QUEL PRODOTTO
        protected void Button1_Click(object sender, EventArgs e)
        {
            //creo un cookie per inserire i dati
            HttpCookie cookie1 = new HttpCookie("prodotto1");
            cookie1.Values["prodotto"] = Prodotto1.InnerText;
            cookie1.Values["prezzo"] = Prezzo1.InnerText;
            cookie1.Values["dettagli"] = Dettagli1.InnerText;
            cookie1.Values["img"] = Img1.Attributes["src"];
            Response.Cookies.Add(cookie1);

            //per andare sulla pagina dettagli
            Response.Redirect("Dettagli.aspx?prodotto=" + Server.UrlEncode(cookie1.Name));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //creo un cookie per inserire i dati
            HttpCookie cookie2 = new HttpCookie("prodotto2");
            cookie2.Values["prodotto"] = Prodotto2.InnerText;
            cookie2.Values["prezzo"] = Prezzo2.InnerText;
            cookie2.Values["dettagli"] = Dettagli2.InnerText;
            cookie2.Values["img"] = Img2.Attributes["src"];
            Response.Cookies.Add(cookie2);

            //per andare sulla pagina dettagli
            Response.Redirect("Dettagli.aspx?prodotto=" + Server.UrlEncode(cookie2.Name));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //creo un cookie per inserire i dati
            HttpCookie cookie3 = new HttpCookie("prodotto3");
            cookie3.Values["prodotto"] = Prodotto3.InnerText;
            cookie3.Values["prezzo"] = Prezzo3.InnerText;
            cookie3.Values["dettagli"] = Dettagli3.InnerText;
            cookie3.Values["img"] = Img3.Attributes["src"];
            Response.Cookies.Add(cookie3);

            //per andare sulla pagina dettagli
            Response.Redirect("Dettagli.aspx?prodotto=" + Server.UrlEncode(cookie3.Name));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //creo un cookie per inserire i dati
            HttpCookie cookie4 = new HttpCookie("prodotto4");
            cookie4.Values["prodotto"] = Prodotto4.InnerText;
            cookie4.Values["prezzo"] = Prezzo4.InnerText;
            cookie4.Values["dettagli"] = Dettagli4.InnerText;
            cookie4.Values["img"] = Img4.Attributes["src"];
            Response.Cookies.Add(cookie4);

            //per andare sulla pagina dettagli
            Response.Redirect("Dettagli.aspx?prodotto=" + Server.UrlEncode(cookie4.Name));
        }
    }
}