using System;
using System.Collections.Generic;
using System.Text;

namespace Mystays.TripAdvisor.ConsumerService.Models.Attraction
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

    public class Time
    {
        public string open_time { get; set; }
        public string close_time { get; set; }
    }

    public class WeekRange
    {
        public string localized_day_name { get; set; }
        public List<Time> times { get; set; }
        public string day_name { get; set; }
    }

    public class Hours
    {
        public List<WeekRange> week_ranges { get; set; }
        public string timezone { get; set; }
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

    public class AttractionType
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
        public object ranking_string_detail { get; set; }
    }

    public class Images
    {
        public string tiny { get; set; }
        public string small { get; set; }
        public string large { get; set; }
    }

    public class Award
    {
        public string award_type { get; set; }
        public string year { get; set; }
        public Images images { get; set; }
        public List<Category> categories { get; set; }
        public string display_name { get; set; }
    }

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

    public class Images2
    {
        public Small small { get; set; }
        public Large large { get; set; }
        public Medium medium { get; set; }
    }

    public class Category2
    {
        public string name { get; set; }
        public string localized_name { get; set; }
    }

    public class Group2
    {
        public string name { get; set; }
        public List<Category2> categories { get; set; }
        public string localized_name { get; set; }
    }

    public class ActivityList
    {
        public string title { get; set; }
        public string price { get; set; }
        public string currency { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public bool hotel_pickup { get; set; }
        public Images2 images { get; set; }
        public string departure_point { get; set; }
        public string return_details { get; set; }
        public List<string> inclusions { get; set; }
        public List<string> exclusions { get; set; }
        public List<Group2> groups { get; set; }
    }

    public class AttractionBooking
    {
        public bool bookable { get; set; }
        public string total_results { get; set; }
        public string results { get; set; }
        public string activity_list_url { get; set; }
        public List<ActivityList> activity_list { get; set; }
    }

    public class Category3
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

    public class Attraction
    {
        public AddressObj address_obj { get; set; }
        public Hours hours { get; set; }
        public object percent_recommended { get; set; }
        public string latitude { get; set; }
        public string rating { get; set; }
        public string description { get; set; }
        public List<Group> groups { get; set; }
        public List<AttractionType> attraction_types { get; set; }
        public string location_id { get; set; }
        public RankingData ranking_data { get; set; }
        public string api_detail_url { get; set; }
        public string location_string { get; set; }
        public string web_url { get; set; }
        public string rating_image_url { get; set; }
        public List<Award> awards { get; set; }
        public string name { get; set; }
        public AttractionBooking attraction_booking { get; set; }
        public string num_reviews { get; set; }
        public string write_review { get; set; }
        public Category3 category { get; set; }
        public List<Subcategory> subcategory { get; set; }
        public List<Ancestor> ancestors { get; set; }
        public string see_all_photos { get; set; }
        public string longitude { get; set; }
    }

    public class Paging
    {
        public string next { get; set; }
        public string previous { get; set; }
        public string results { get; set; }
        public string total_results { get; set; }
        public string skipped { get; set; }
    }

    public class AttractionRootObject
    {
        public List<Attraction> data { get; set; }
        public Paging paging { get; set; }
    }

}
