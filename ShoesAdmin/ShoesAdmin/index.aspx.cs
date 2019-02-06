using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace ShoesAdmin
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int Id = Convert.ToInt32(Request.QueryString["ID"]);


                UserTable U = class1.selectProductByID(Id);
                txtpname.Text = U.p_name;
                txtpcategory.Text = U.p_category;
                txtpprice.Text = U.p_price;
                txtpstock.Text = U.p_stock;
                //FileUploadPhoto. = U.Photo;

            }

        }
        protected void btn_submit(object sender, EventArgs e)
        {
            
            UserTable u = new UserTable();
            u.p_name = txtpname.Text;
            u.p_category = txtpcategory.Text;
            u.p_price= txtpprice.Text;
            u.p_stock = txtpstock.Text;

            class1.insert(u);
            MessageBox.Show("Product Added");
            Response.Redirect("index.aspx");
        }
        }
    }