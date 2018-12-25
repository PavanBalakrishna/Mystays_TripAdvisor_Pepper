using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Mystays.TripAdvisor.ConsumerService.Models.Activity;

namespace Mystays.TripAdvisor.ConsumerService.APIInvoker
{
    public static class TripAdvisorAPIService
    {
        public static string GetActivities()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string url = "http://api.tripadvisor.com/api/partner/2.0/location/60745/attractions?key=e84a5b42-e036-403a-b5a3-ca393296b27a";
                var response = httpClient.GetAsync(url).Result;
                ActivityRootObject activityRootObject = JsonConvert.DeserializeObject<ActivityRootObject>(response.Content.ReadAsStringAsync().Result);
                return activityRootObject.data[0].description;
            }
        }
    }
}
