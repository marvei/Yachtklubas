using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YachtKlubas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }

        protected void Items_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/items/items.aspx");
        }

        protected void Employees_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Employees/Employees.aspx");
        }

        protected void Storage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Storage/Storage.aspx");
        }

        protected void Packages_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Packages/Packages.aspx");
        }

        protected void Cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cart/Cart.aspx");
        }

        protected void Favorite_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Favorite/Favorite.aspx");
        }
    }
}