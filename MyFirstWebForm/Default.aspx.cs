using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.Literal1.Text = "Lütfen Sol Tarafa adınızı yazınız.";
            }
        }
        protected string TarihDondur()
        {
            return DateTime.Now.ToShortDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Literal1.Text = "Merhaba " + this.TextBox1.Text + " Nasılsın ?";
        }
    }
}