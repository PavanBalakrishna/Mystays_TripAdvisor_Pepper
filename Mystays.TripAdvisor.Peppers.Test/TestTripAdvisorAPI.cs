using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mystays.TripAdvisor.Business.API.APIInvoker;
using Mystays.TripAdvisor.Business.Helpers;

namespace Mystays.TripAdvisor.Peppers.Test
{
    [TestClass]
    public class TestTripAdvisorAPI
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            HelpersMethods.SetSettings("e84a5b42-e036-403a-b5a3-ca393296b27a", "TripAdvisorKey");
            HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}?key={1}&locale={2}", "TripAdvisorLocationURL");
            HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}/activities?key={1}&locale={2}", "TripAdvisorActivityURL");
            HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}/attractions?key={1}&locale={2}", "TripAdvisorAttractionsURL");
            HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}/hotels?key={1}&locale={2}", "TripAdvisorHotelsURL");
            HelpersMethods.SetSettings("http://api.tripadvisor.com/api/partner/2.0/location/{0}/restaurants?key={1}&locale={2}", "TripAdvisorRestaurantsURL");
            HelpersMethods.SetSettings("60745|60747|60750|60748|60746|60741|60742|60743|60744|60745", "TripAdvisorLocationIDs");
            HelpersMethods.SetSettings("en-us|ja-jp|zh-cn|zh-tw|ko-kr", "TripAdvisorLanguages");

            IAPIInvokerService tripAdvisorAPIService = new TripAdvisorAPIService();

            tripAdvisorAPIService.CallTripAdvisorAPI();
        }
    }
}
