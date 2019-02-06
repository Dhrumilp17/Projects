using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*
namespace RestaurentsApp
{
    public class Yelp
    {
    }
}
*/



public class Rootobject
{
    public Data data { get; set; }
}

public class Data
{
    public Business business { get; set; }
}

public class Business
{
    public string name { get; set; }
    public string id { get; set; }
    public string alias { get; set; }
    public float rating { get; set; }
    public string url { get; set; }
}
