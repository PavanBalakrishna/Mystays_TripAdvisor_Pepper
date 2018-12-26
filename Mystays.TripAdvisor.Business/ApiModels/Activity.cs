using System;
using System.Collections.Generic;
using System.Text;

namespace Mystays.TripAdvisor.Business.ApiModels.Activity
{

    public class Small
    {
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }

    public class Large
    {
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }

    public class Medium
    {
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }

    public class Images
    {
        public Small small { get; set; }
        public Large large { get; set; }
        public Medium medium { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public string localized_name { get; set; }
    }

    public class Group
    {
        public string name { get; set; }
        public List<Category> categories { get; set; }
        public string localized_name { get; set; }
    }

    public class Activity
    {
        public string departure_point { get; set; }
        public Images images { get; set; }
        public string price { get; set; }
        public bool hotel_pickup { get; set; }
        public string description { get; set; }
        public List<Group> groups { get; set; }
        public string currency { get; set; }
        public List<string> exclusions { get; set; }
        public string title { get; set; }
        public string return_details { get; set; }
        public string url { get; set; }
        public List<string> inclusions { get; set; }
    }

    public class Paging
    {
        public string next { get; set; }
        public string previous { get; set; }
        public string results { get; set; }
        public string total_results { get; set; }
        public string skipped { get; set; }
    }

    public class ActivityRootObject
    {
        public List<Activity> data { get; set; }
        public Paging paging { get; set; }
    }


}
