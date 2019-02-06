using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SimpleJson;

namespace RestaurentsApp
{
    public partial class Homepage : System.Web.UI.Page
    {


        public class Rootobject
        {
            public Business[] businesses { get; set; }
            public int total { get; set; }
            public Region region { get; set; }
        }

        public class Region
        {
            public Center center { get; set; }
        }

        public class Center
        {
            public float longitude { get; set; }
            public float latitude { get; set; }
        }

        public class Business
        {
            public string id { get; set; }
            public string alias { get; set; }
            public string name { get; set; }
            public string image_url { get; set; }
            public bool is_closed { get; set; }
            public string url { get; set; }
            public int review_count { get; set; }
            public Category[] categories { get; set; }
            public float rating { get; set; }
            public Coordinates coordinates { get; set; }
            public string[] transactions { get; set; }
            public string price { get; set; }
            public Location location { get; set; }
            public string phone { get; set; }
            public string display_phone { get; set; }
            public float distance { get; set; }
        }

        public class Coordinates
        {
            public float latitude { get; set; }
            public float longitude { get; set; }
        }

        public class Location
        {
            public string address1 { get; set; }
            public string address2 { get; set; }
            public string address3 { get; set; }
            public string city { get; set; }
            public string zip_code { get; set; }
            public string country { get; set; }
            public string state { get; set; }
            public string[] display_address { get; set; }
        }

        public class Category
        {
            public string alias { get; set; }
            public string title { get; set; }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
           
           

        }

       
        protected void searchBtn_Click(object sender, EventArgs e)
        {
            var x = searchBtn.Text;
            var client = new RestClient("https://api.yelp.com/v3/businesses/search?location=" + x+"/");

            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "8153f32d-7ab8-40b5-b03f-7934ddba0775");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Authorization", "Bearer r_RIHzKnBklCI-z35QRuloijgPxlegl8H1ijC1dGruBDK5kl9PIyZBbQoKsYCpGDEcK3uSjRJ7D-BL7tUUo-2e4DD0RxmX0OkdVxK7411nJhjvVJR69CYLahTLfLW3Yx");
            IRestResponse response = client.Execute(request);

            string content = response.Content;
            dynamic response1 = JsonConvert.DeserializeObject(content);
            List<Business> organizations = response1.businesses.ToObject<List<Business>>();
            GridView1.DataSource = organizations;
            GridView1.DataBind();
        }
    }
}




