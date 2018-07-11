using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace ebookstore
{
    public partial class MyFirst : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void HomeB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void ShopInfoB_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopInfo.aspx");
        }

        protected void ProductsB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Products.aspx");
        }

        protected void LoginB_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
