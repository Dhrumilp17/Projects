using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShoesAdmin
{
    public class class1
    {
        public static int insert(UserTable u)
        {
            string query = @"INSERT INTO [Product] VALUES(@p_name,@p_category,@p_price,@p_stock)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@p_name", u.p_name));
            par.Add(new SqlParameter("@p_category", u.p_category));
            par.Add(new SqlParameter("@p_price", u.p_price));
            par.Add(new SqlParameter("@p_stock", u.p_stock));
            return DB.modifyData(query, par);

        }

        public static int insertuser(UserTable u)
        {
            string query = @"INSERT INTO [User] VALUES(@Name,@Username,@Password,@Email)";
            List<SqlParameter> par = new List<SqlParameter>();
            par.Add(new SqlParameter("@Name", u.Name));
            par.Add(new SqlParameter("@Username", u.Username));
            par.Add(new SqlParameter("@Password", u.Password));
            par.Add(new SqlParameter("@Email", u.Email));

            return DB.modifyData(query, par);

        }
        public static int validate(String Username, String Password)
        {
            String query = @"SELECT * FROM [User] WHERE UserName=@Username";
            List<SqlParameter> par = new List<SqlParameter>();

            par.Add(new SqlParameter("@Username", Username));

            DataTable dt = DB.ModifyData(query, par);
            if (dt.Rows.Count == 1)
            {
                String passwrd = dt.Rows[0]["Password"].ToString();
                if (passwrd == Password)
                    return Convert.ToInt32(dt.Rows[0]["Id"]);
                else
                    return 0;
            }
            else
                return 0;
        }

        public static UserTable selectproducts()
        {
            String query = @"SELECT * FROM [Product]";
            List<SqlParameter> par = new List<SqlParameter>();


            DataTable dt = DB.ModifyData(query, par);
            if (dt.Rows.Count == 1)
            {
                UserTable CM = new UserTable();
                CM.p_name = dt.Rows[0]["p_name"].ToString();
                CM.p_category = dt.Rows[0]["p_category"].ToString();
                CM.p_price = dt.Rows[0]["p_price"].ToString();
                CM.p_stock = dt.Rows[0]["p_stock"].ToString();

                return CM;
            }
            else
            {
                return new UserTable();
            }

        }


        public static DataTable selectproduct()
        {
            //   String query = @"Select * from [User],[Friend]";
            string query = @"select * from [Product]";
            List<SqlParameter> par = new List<SqlParameter>();


            DataTable dt = DB.ModifyData(query, par);
            return dt;
        }


        public static int update(UserTable D)
        {
            String query = @"UPDATE Product SET p_name=@p_name,p_category=@p_category,p_price=@p_price,p_stock=@p_stock WHERE p_id=@p_id";
            List<SqlParameter> par = new List<SqlParameter>();

            par.Add(new SqlParameter("@p_id", D.p_id));
            par.Add(new SqlParameter("@p_name", D.p_name));
            par.Add(new SqlParameter("@p_category", D.p_category));
            par.Add(new SqlParameter("@p_price", D.p_price));
            par.Add(new SqlParameter("@p_stock", D.p_stock));
           
            return DB.modifyData(query, par);

        }



        public static UserTable selectProductByID(int Id)
        {
            String query = @"SELECT * FROM [Product] WHERE p_id=@Id";
            List<SqlParameter> par = new List<SqlParameter>();

            par.Add(new SqlParameter("@Id", Id));

            DataTable dt = DB.ModifyData(query, par);

            if (dt.Rows.Count == 1)
            {
                UserTable CM = new UserTable();
                CM.p_id = Convert.ToInt32(dt.Rows[0]["p_id"]);
                CM.p_name = dt.Rows[0]["p_name"].ToString();
                CM.p_category = dt.Rows[0]["p_category"].ToString();
                CM.p_price = dt.Rows[0]["p_price"].ToString();
                CM.p_stock = dt.Rows[0]["p_stock"].ToString();
                return CM;

            }
            else
            {
                return new UserTable();
            }
        }
    }
}