using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngaji.Data
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Auth
    {
        public string type { get; set; }
        public List<Bearer> bearer { get; set; }
    }

    public class Bearer
    {
        public string key { get; set; }
        public string value { get; set; }
        public string type { get; set; }
    }
    public class Aggregator
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public object district_id { get; set; }
        public object logo { get; set; }
        public bool isCommunity { get; set; }
        public int ustad_price { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public object district { get; set; }
        public object city { get; set; }
        public object province { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string status { get; set; }
        public int role_id { get; set; }
        public bool is_approved { get; set; }
        public string registered_at { get; set; }
        public string updated_at { get; set; }
        public User user { get; set; }
        public Role role { get; set; }
        public Aggregator Aggregator { get; set; }
        public int? star { get; set; }
        public Ustadz Ustadz { get; set; }
        public List<object> courses { get; set; }
    }

    public class User
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public string name { get; set; }
        public string date_of_birth { get; set; }
        public string place_of_birth { get; set; }
        public string education { get; set; }
        public string occupation { get; set; }
        public string marriage_status { get; set; }
        public string phone_number { get; set; }
        public string user_image { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public object district_id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public object city_id { get; set; }
        public object district { get; set; }
        public object city { get; set; }
        public object province { get; set; }
    }

    public class Role
    {
        public int id { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string description { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }

    public class Root
    {
        public List<Datum> data { get; set; }
    }

    public class Ustadz
    {
        public string id { get; set; }
        public int user_id { get; set; }
        public string experience { get; set; }
        public object last_education { get; set; }
        public object last_school { get; set; }
        public object last_school_majoring { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public object level { get; set; }
    }


}
