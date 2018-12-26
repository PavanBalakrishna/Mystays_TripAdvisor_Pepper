using System;
using System.Collections.Generic;
using System.Text;
using Mystays.TripAdvisor.Business.API.ApiModels.Activity;
using Mystays.TripAdvisor.Business.Constants;
using Mystays.TripAdvisor.Business.API.ApiModels.Location;
using Mystays.TripAdvisor.Business.API.ApiModels.Attraction;
using Mystays.TripAdvisor.Business.API.ApiModels.Hotel;
using Mystays.TripAdvisor.Business.API.ApiModels.Restaurant;

namespace Mystays.TripAdvisor.Business.API.ApiModels
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
