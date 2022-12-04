using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assi6
{
    public partial class Desig : System.Web.UI.Page
    {
        Opeartions obj=new Opeartions();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DropDownList1.DataSource = obj.exedataset("SELECT * FROM department");
                DropDownList1.DataTextField = "deptname";
                DropDownList1.DataValueField = "deptid";
                DropDownList1.DataBind();

                DataSet ds = obj.showGrid("SELECT * FROM designation");
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = DropDownList1.SelectedItem.Text;
            obj.insertdesig("insert into designation values('" + TextBox1.Text + "','" + id + "')");
            TextBox1.Text = "";
            DataSet ds = obj.showGrid("SELECT * FROM designation");
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            DataSet ds = obj.showGrid("SELECT * FROM designation");
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            DataSet ds = obj.showGrid("SELECT * FROM designation");
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            //TextBox txtname = new TextBox();
            //txtname = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string v = id.ToString();

            GridViewRow row = GridView1.Rows[e.RowIndex];

            TextBox txtname = new TextBox();
            txtname = (TextBox)(row.Cells[0].Controls[0]);

            obj.updategrid("update designation set designame='" + txtname.Text + "' where did='" + id + "'");
            GridView1.EditIndex = -1;
            DataSet ds = obj.showGrid("SELECT * FROM designation");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            obj.deleteGrid("Delete from designation where did='" + id + "'");
            DataSet ds = obj.showGrid("SELECT * FROM designation");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}