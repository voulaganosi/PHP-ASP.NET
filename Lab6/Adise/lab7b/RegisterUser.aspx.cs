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

namespace lab7b
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sign_Up(object sender, EventArgs e)
        {
            if (AcceptCB.Checked)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                P2NameTB.Text = NameTB.Text;
                P2LNameTB.Text = LNameTB.Text;
                P2MailTB.Text = EmailTB.Text;
                P2AdrressTB.Text = AddressTB.Text;
                P2PhoneTB.Text = PhoneTB.Text;
                P2TkTB.Text = TkTB.Text;
                P2CityTB.Text = CityTB.Text;
                P2CountryTB.Text = DropDownList2.SelectedItem.Text;
                P2SexTB.Text = RadioButton1.Text;
            }

        }
    }
}
