using MyFirstWebForm.Data;
using MyFirstWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebForm
{
    public partial class OgrenciEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationDbContext())
            {
                var item = new Student();
                item.FirstName = txtFirstName.Text;
                item.LastName = txtLastName.Text;
                item.Phone = txtPhone.Text;
                item.Email = txtEmail.Text;
                item.BirthDate =cldBirthDate.SelectedDate;
                item.Age = Convert.ToInt32(txtAge.Text);
                db.Students.Add(item);
                db.SaveChanges();
                Response.Redirect("Ogrenciler");
            }
        }
    }
}