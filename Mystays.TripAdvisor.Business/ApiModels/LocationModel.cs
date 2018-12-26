using System;
using System.Collections.Generic;
using System.Text;
using Mystays.TripAdvisor.Business.ApiModels.Activity;
using Mystays.TripAdvisor.Business.Constants;
using Mystays.TripAdvisor.Business.ApiModels.Location;
using Mystays.TripAdvisor.Business.ApiModels.Attraction;
using Mystays.TripAdvisor.Business.ApiModels.Hotel;
using Mystays.TripAdvisor.Business.ApiModels.Restaurant;

namespace Mystays.TripAdvisor.Business.ApiModels
{
    public class LocationModel
    {
        public string LocationID { get; set; }
        public string Language { get; set; }

        public LocationRootObject LocationDetails { get; set; }
        public ActivityRootObject ActivitiesDetails { get; set; }
        public AttractionRootObject AttractionDetails { get; set; }
        public HotelRootObject HotelDetails { get; set; }
        public RestaurantRootObject RestaurantDetails { get; set; }
    }
}
