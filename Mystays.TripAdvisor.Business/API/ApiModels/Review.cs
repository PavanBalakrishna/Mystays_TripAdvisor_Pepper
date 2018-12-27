using System;
using System.Collections.Generic;
using System.Text;

namespace Mystays.TripAdvisor.Business.API.ApiModels.Review
{

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
        public object owner_response { get; set; }
        public List<object> subratings { get; set; }
    }

    public class Paging
    {
        public object next { get; set; }
        public object previous { get; set; }
        public string results { get; set; }
        public string total_results { get; set; }
        public string skipped { get; set; }
    }

    public class ReviewRootObject
    {
        public List<Review> data { get; set; }
        public Paging paging { get; set; }
    }

}
