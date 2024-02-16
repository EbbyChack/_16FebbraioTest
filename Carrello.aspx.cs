using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _16FebbraioTest
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<HttpCookie> CartList = (List<HttpCookie>)Session["CartList"];
                if (CartList != null)
                {
                    string cartItemsHtml = "";

                    foreach (HttpCookie cookie in CartList)
                    {
                        cartItemsHtml += $@" <div class='col-3'>
                                             <div class='card'>
                                                 <img class='card-img-top' src='{cookie["img"]}' alt='Card image cap'>
                                                 <div class='card-body'>
                                                     <h5 class='card-title'>{cookie["prodotto"]}</h5>
                                                     <p class='card-text' runat='server' id='Prezzo1'>{cookie["prezzo"]}</p>
                                                    
                                                </div>
                                             </div>
                                          </div>";
                    }
                    cartItems.InnerHtml = cartItemsHtml;
                }
            }

        }



        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Session.Remove("CartList");
            Response.Redirect(Request.Url.AbsoluteUri);

        }
    }
}