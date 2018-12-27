using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System;
using Mystays.TripAdvisor.Business.API.ApiModels.Activity;
using Mystays.TripAdvisor.Business.Constants;
using Mystays.TripAdvisor.Business.API.ApiModels.Location;
using Mystays.TripAdvisor.Business.API.ApiModels.Attraction;
using Mystays.TripAdvisor.Business.API.ApiModels.Hotel;
using Mystays.TripAdvisor.Business.API.ApiModels.Restaurant;
using Mystays.TripAdvisor.Business.API.ApiModels;
using Mystays.TripAdvisor.Business.API.ApiModels.Review;

namespace Mystays.TripAdvisor.Business.API.APIInvoker
{
    public  class TripAdvisorAPIService: IAPIInvokerService
    {
        public APIReturnModel CallTripAdvisorAPI()
        {
            APIReturnModel returnModel = new APIReturnModel();

            try
            {
                string TAkey = TripAdvisorSettings.TripAdvisorKey;
                using (var httpClient = new HttpClient())
                {

                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    foreach (var locationID in TripAdvisorSettings.TripAdvisorLocationIDs.Split('|'))
                    {
                        foreach (var language in TripAdvisorSettings.TripAdvisorLanguages.Split('|'))
                        {
                            LocationModel model = new LocationModel();
                            model.LocationID = locationID;
                            model.Language = language;

                            if (TripAdvisorSettings.TripAdvisorLocationURL != null)
                            {
                                string url = string.Format(TripAdvisorSettings.TripAdvisorLocationURL, locationID, TAkey, language);
                                var response = httpClient.GetAsync(url).Result;
                                LocationRootObject locationrootObject = JsonConvert.DeserializeObject<LocationRootObject>(response.Content.ReadAsStringAsync().Result);
                                model.LocationDetails = locationrootObject;
                            }

                            if (TripAdvisorSettings.TripAdvisorActivityURL != null)
                            {
                                string url = string.Format(TripAdvisorSettings.TripAdvisorActivityURL, locationID, TAkey, language);
                                var response = httpClient.GetAsync(url).Result;
                                ActivityRootObject activitiesrootObject = JsonConvert.DeserializeObject<ActivityRootObject>(response.Content.ReadAsStringAsync().Result);
                                model.ActivitiesDetails = activitiesrootObject;
                            }

                            if (TripAdvisorSettings.TripAdvisorAttractionsURL != null)
                            {
                                string url = string.Format(TripAdvisorSettings.TripAdvisorAttractionsURL, locationID, TAkey, language);
                                var response = httpClient.GetAsync(url).Result;
                                AttractionRootObject attractionsrootObject = JsonConvert.DeserializeObject<AttractionRootObject>(response.Content.ReadAsStringAsync().Result);
                                model.AttractionDetails = attractionsrootObject;
                            }

                            if (TripAdvisorSettings.TripAdvisorHotelsURL != null)
                            {
                                string url = string.Format(TripAdvisorSettings.TripAdvisorHotelsURL, locationID, TAkey, language);
                                var response = httpClient.GetAsync(url).Result;
                                HotelRootObject hotelsrootObject = JsonConvert.DeserializeObject<HotelRootObject>(response.Content.ReadAsStringAsync().Result);
                                model.HotelDetails = hotelsrootObject;
                            }

                            if (TripAdvisorSettings.TripAdvisorRestaurantsURL != null)
                            {
                                string url = string.Format(TripAdvisorSettings.TripAdvisorRestaurantsURL, locationID, TAkey, language);
                                var response = httpClient.GetAsync(url).Result;
                                RestaurantRootObject restaurantrootObject = JsonConvert.DeserializeObject<RestaurantRootObject>(response.Content.ReadAsStringAsync().Result);
                                model.RestaurantDetails = restaurantrootObject;
                            }

                            if (TripAdvisorSettings.TripAdvisorReviewsURL != null)
                            {
                                string url = string.Format(TripAdvisorSettings.TripAdvisorReviewsURL, locationID, TAkey, language);
                                var response = httpClient.GetAsync(url).Result;
                                ReviewRootObject reviewrootObject = JsonConvert.DeserializeObject<ReviewRootObject>(response.Content.ReadAsStringAsync().Result);
                                model.ReviewDetails = reviewrootObject;
                            }

                            returnModel.locationModels.Add(model);
                        }


                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return returnModel;
        }
    }
}
