using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assi6
{
    public partial class Dept : System.Web.UI.Page
    {
        Opeartions obj = new Opeartions();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            obj.insertdept("insert into department values('" + TextBox1.Text + "')");
            TextBox1.Text = "";

        }
    }
}