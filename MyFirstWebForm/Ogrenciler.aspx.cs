using MyFirstWebForm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebForm
{
    public partial class Ogrenciler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                using (var db = new ApplicationDbContext())
                {
                    this.GridView1.DataSource = db.Students.ToList();
                    this.GridView1.DataBind();
                }
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var id = int.Parse(this.GridView1.Rows[e.RowIndex].Cells[0].Text.ToString());
            using (var db=new ApplicationDbContext())
            {
                var student = db.Students.Where(x=>x.Id==id).FirstOrDefault();

                if (student!=null)
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                    this.GridView1.DataSource = db.Students.ToList();
                    this.GridView1.DataBind();
                }
            }
        }
    }
}