using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace Lab8
{
    public partial class ProductInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ProsthikiB_Click(object sender, EventArgs e)
        {
            SortedList cart = new SortedList();
        //    if (Session["user"] != null)
          //  {
                //Session["user"]["proion"] = Request.QueryString("id");
                //Session["user"]["posotita"] = PosotitaTB.Text;
            String p = Request.QueryString["id"];
           if(Session["cart"]!=null) {
               cart = (SortedList)Session["cart"];
           }
            cart[p] = PosotitaTB.Text;
            
               Session["cart"] = cart;
                Response.Redirect("Products.aspx");
          //  }
        }
    }
}
