using System;
using System.Collections.Generic;
using System.Text;

namespace Mystays.TripAdvisor.Business.API.ApiModels.Restaurant
{
    public class AddressObj
    {
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string postalcode { get; set; }
        public string address_string { get; set; }
    }

    public class WeekRange
    {
        public string localized_day_name { get; set; }
        public List<object> times { get; set; }
        public string day_name { get; set; }
    }

    public class Hours
    {
        public List<WeekRange> week_ranges { get; set; }
        public string timezone { get; set; }
    }

    public class Cuisine
    {
        public string name { get; set; }
        public string localized_name { get; set; }
    }

    public class RankingData
    {
        public string ranking_string { get; set; }
        public string ranking_out_of { get; set; }
        public string geo_location_id { get; set; }
        public string ranking { get; set; }
        public string geo_location_name { get; set; }
        public List<string> ranking_string_detail { get; set; }
    }

    public class Images
    {
        public string small { get; set; }
        public string large { get; set; }
    }

    public class Award
    {
        public string award_type { get; set; }
        public string year { get; set; }
        public Images images { get; set; }
        public List<object> categories { get; set; }
        public string display_name { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public string localized_name { get; set; }
    }

    public class Subcategory
    {
        public string name { get; set; }
        public string localized_name { get; set; }
    }

    public class Ancestor
    {
        public string abbrv { get; set; }
        public string level { get; set; }
        public string name { get; set; }
        public string location_id { get; set; }
    }

    public class Restaurant
    {
        public AddressObj address_obj { get; set; }
        public Hours hours { get; set; }
        public object percent_recommended { get; set; }
        public string latitude { get; set; }
        public string rating { get; set; }
        public string description { get; set; }
        public List<Cuisine> cuisine { get; set; }
        public string location_id { get; set; }
        public RankingData ranking_data { get; set; }
        public string api_detail_url { get; set; }
        public string location_string { get; set; }
        public string web_url { get; set; }
        public string price_level { get; set; }
        public string rating_image_url { get; set; }
        public List<Award> awards { get; set; }
        public string name { get; set; }
        public string num_reviews { get; set; }
        public string write_review { get; set; }
        public Category category { get; set; }
        public List<Subcategory> subcategory { get; set; }
        public List<Ancestor> ancestors { get; set; }
        public string see_all_photos { get; set; }
        public string longitude { get; set; }
    }

    public class Paging
    {
        public object next { get; set; }
        public object previous { get; set; }
        public string results { get; set; }
        public string total_results { get; set; }
        public string skipped { get; set; }
    }

    public class RestaurantRootObject
    {
        public List<Restaurant> data { get; set; }
        public Paging paging { get; set; }
    }


}
