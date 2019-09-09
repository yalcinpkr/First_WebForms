using MyFirstWebForm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebForm
{
    public partial class OgrenciDuzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var id = int.Parse(Request.QueryString["Id"].ToString());
                using (var db=new ApplicationDbContext())
                {
                    var student = db.Students.Where(x => x.Id == id).FirstOrDefault();
                    if (student!=null)
                    {
                        txtFirstName.Text = student.FirstName;
                        txtLastName.Text = student.LastName;
                        txtPhone.Text = student.Phone;
                        txtEmail.Text = student.Email;
                        cldBirthDate.SelectedDate = student.BirthDate;
                        cldBirthDate.VisibleDate = student.BirthDate;
                        txtAge.Text = student.Age.ToString();
                        ViewState["Id"] = id;
                    }
                }
            }
        }

        protected void btnDuzenle_Click(object sender, EventArgs e)
        {
            using (var db=new ApplicationDbContext())
            {

                var id = Convert.ToInt32(ViewState["Id"]);
                var student = db.Students.Where(x => x.Id == id).FirstOrDefault();
                student.FirstName = txtFirstName.Text;
                student.LastName = txtLastName.Text;
                student.Phone = txtPhone.Text;
                student.Email = txtEmail.Text;
                student.BirthDate = cldBirthDate.SelectedDate;
                student.Age = Convert.ToInt32(txtAge.Text);

                db.SaveChanges();

                Response.Redirect("Ogrenciler");

            }
        }

        
    }
}