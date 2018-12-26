using System;
using System.Collections.Generic;
using System.Text;

namespace Mystays.TripAdvisor.Business.ApiModels.Location
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

    public class TripType
    {
        public string name { get; set; }
        public string value { get; set; }
        public string localized_name { get; set; }
    }

    public class UserLocation
    {
        public string name { get; set; }
        public string id { get; set; }
    }

    public class User
    {
        public string username { get; set; }
        public UserLocation user_location { get; set; }
    }

    public class Review
    {
        public string id { get; set; }
        public string lang { get; set; }
        public string location_id { get; set; }
        public DateTime published_date { get; set; }
        public int rating { get; set; }
        public string helpful_votes { get; set; }
        public string rating_image_url { get; set; }
        public string url { get; set; }
        public string trip_type { get; set; }
        public string travel_date { get; set; }
        public string text { get; set; }
        public User user { get; set; }
        public string title { get; set; }
    }

    public class Ancestor
    {
        public string abbrv { get; set; }
        public string level { get; set; }
        public string name { get; set; }
        public string location_id { get; set; }
    }

    public class ReviewRatingCount
    {
        public string __invalid_name__1 { get; set; }
        public string __invalid_name__2 { get; set; }
        public string __invalid_name__3 { get; set; }
        public string __invalid_name__4 { get; set; }
        public string __invalid_name__5 { get; set; }
    }

    public class Subrating
    {
        public string rating_image_url { get; set; }
        public string name { get; set; }
        public string value { get; set; }
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
        public string small { get; set; }
        public string large { get; set; }
    }

    public class Award
    {
        public string award_type { get; set; }
        public string year { get; set; }
        public Images images { get; set; }
        public List<string> categories { get; set; }
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

    public class LocationRootObject
    {
        public AddressObj address_obj { get; set; }
        public string latitude { get; set; }
        public string rating { get; set; }
        public string description { get; set; }
        public string location_id { get; set; }
        public List<TripType> trip_types { get; set; }
        public List<Review> reviews { get; set; }
        public string write_review { get; set; }
        public List<Ancestor> ancestors { get; set; }
        public string longitude { get; set; }
        public object hours { get; set; }
        public object percent_recommended { get; set; }
        public ReviewRatingCount review_rating_count { get; set; }
        public List<Subrating> subratings { get; set; }
        public RankingData ranking_data { get; set; }
        public string photo_count { get; set; }
        public string location_string { get; set; }
        public string web_url { get; set; }
        public string price_level { get; set; }
        public string rating_image_url { get; set; }
        public List<Award> awards { get; set; }
        public string name { get; set; }
        public string num_reviews { get; set; }
        public Category category { get; set; }
        public List<Subcategory> subcategory { get; set; }
        public string see_all_photos { get; set; }
    }
}
