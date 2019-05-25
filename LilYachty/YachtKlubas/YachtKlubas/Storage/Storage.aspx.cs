using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YachtKlubas.Storage
{
    public partial class Storage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Edit_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Storage/Edit/EditItem.aspx");
        }
    }
}