using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YachtKlubas.Items
{
    public partial class Items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddNewItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Items/AddNew/AddNewItem.aspx");
        }

        protected void CreateNewPackage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Items/CreateNewPackage/CreateNewPackage.aspx");
        }

        protected void ChangePrice_Click(object sender, EventArgs e)
        {
            //ChangePriceMetodas

        }

        protected void AddFavorite_Click(object sender, EventArgs e)
        {

        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}