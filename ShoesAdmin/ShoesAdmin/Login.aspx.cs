using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoesAdmin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            int Id = class1.validate(Username, Password);
            if (Id != 0)
            {
                Response.Redirect("index.aspx");
            }
        }
        protected void btnreg(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

    }
}