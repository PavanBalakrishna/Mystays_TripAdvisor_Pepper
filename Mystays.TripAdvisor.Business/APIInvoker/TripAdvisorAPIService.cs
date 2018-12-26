using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System;
using Mystays.TripAdvisor.Business.Models.Activity;

namespace Mystays.TripAdvisor.Business.APIInvoker
{
    public static class TripAdvisorAPIService
    {
        public static string GetActivities()
        {
            string TAkey = Environment.GetEnvironmentVariable("TAKey");
            using (var httpClient = new HttpClient())
            {
                
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string url = string.Format("http://api.tripadvisor.com/api/partner/2.0/location/60745/attractions?key={0}",TAkey);
                var response = httpClient.GetAsync(url).Result;
                ActivityRootObject activityRootObject = JsonConvert.DeserializeObject<ActivityRootObject>(response.Content.ReadAsStringAsync().Result);
                return activityRootObject.data[0].description;
            }
        }
    }
}
