using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoesAdmin
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsubmit(object sender, EventArgs e)
        {
            UserTable u = new UserTable();
            u.Name = txtname.Text;
            u.Username = txtusername.Text;
            u.Password = txtpassword.Text;
            u.Email = txtemail.Text;
           
           // String prefix = DateTime.Now.Ticks.ToString();
          //  u.Photos = prefix + FileUploadPhoto.FileName;
          //  FileUploadPhoto.SaveAs(Server.MapPath("img\\" + prefix + FileUploadPhoto.FileName));

            class1.insertuser(u);
            Response.Redirect("Login.aspx");

        }
    }
}