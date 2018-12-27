using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mystays.TripAdvisor.Business.API.APIInvoker;
using Mystays.TripAdvisor.Business.Database;
using Mystays.TripAdvisor.Business.Database.Models;
using Mystays.TripAdvisor.Business.Helpers;
using System.Collections.Generic;
using System.Linq;


namespace Mystays.TripAdvisor.Peppers.Test
{
    [TestClass]
    public class TestTripAdvisorAPI
    {
        [TestMethod]
        public void TestMethod1()
        {

            //HelpersMethods.SetSettings("e84a5b42-e036-403a-b5a3-ca393296b27a", "TripAdvisorKey");
            //HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}?key={1}&locale={2}", "TripAdvisorLocationURL");
            //HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}/activities?key={1}&locale={2}", "TripAdvisorActivityURL");
            //HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}/attractions?key={1}&locale={2}", "TripAdvisorAttractionsURL");
            //HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}/hotels?key={1}&locale={2}", "TripAdvisorHotelsURL");
            //HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}/restaurants?key={1}&locale={2}", "TripAdvisorRestaurantsURL");
            //HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}/reviews?key={1}&locale={2}", "TripAdvisorReviewsURL");
            //HelpersMethods.SetSettings("60745", "TripAdvisorLocationIDs");
            //HelpersMethods.SetSettings("en-us", "TripAdvisorLanguages");

            //IAPIInvokerService tripAdvisorAPIService = new TripAdvisorAPIService();

            //tripAdvisorAPIService.CallTripAdvisorAPI();

            using (MystaysContext context = new MystaysContext())
            {
                Location location = new Location();
                location.Location_ID = 456;
                location.LocationName = "Kolkotta";
                location.Country = "India";
                location.Activities = new System.Collections.Generic.List<Activity>()
                {
                     new Activity()
                     {
                          ActivityName="Swimming",
                          LocalName="‚Í‚¢‚Â‚Å‚à‚²Ž©—R‚É•ÏX‚Å‚«‚Ü‚·"
                     }
                };
                location.Language = context.Languages.FirstOrDefault(l => l.LanguageCode == "en-us");
                context.Locations.Add(location);
                context.SaveChanges();
            }
        }
    }
}
