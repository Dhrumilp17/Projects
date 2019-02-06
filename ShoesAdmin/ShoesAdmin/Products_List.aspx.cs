using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoesAdmin
{
    public partial class Products_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            DataTable dt = class1.selectproduct();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}