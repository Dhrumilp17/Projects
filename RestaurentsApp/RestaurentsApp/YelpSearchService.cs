using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurentsApp
{
    public class YelpSearchService
    {
        public const string YELP_TOKEN_ENDPOINT = "https://api.yelp.com/oauth2/token";

        private readonly string ClientID;
        private readonly string ClientSecret;

        public YelpSearchService(string clientID, string clientSecret)
        {
            this.ClientID = "2dBXjZt4fkpntyG1uWsuA";
            this.ClientSecret = "r_RIHzKnBklCI-z35QRuloijgPxlegl8H1ijC1dGruBDK5kl9PIyZBbQoKsYCpGDEcK3uSjRJ7D-BL7tUUo-2e4DD0RxmX0OkdVxK7411nJhjvVJR69CYLahTLfLW3Yx";
            
        }

    }
}