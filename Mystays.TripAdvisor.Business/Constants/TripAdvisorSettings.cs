using Mystays.TripAdvisor.Business.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mystays.TripAdvisor.Business.Constants
{
    public static class TripAdvisorSettings
    {
        #region API
        public static string TripAdvisorKey => HelpersMethods.GetSettings();
        public static string TripAdvisorLocationURL => HelpersMethods.GetSettings();
        public static string TripAdvisorActivityURL => HelpersMethods.GetSettings();
        public static string TripAdvisorAttractionsURL => HelpersMethods.GetSettings();
        public static string TripAdvisorHotelsURL => HelpersMethods.GetSettings();
        public static string TripAdvisorRestaurantsURL => HelpersMethods.GetSettings();
        public static string TripAdvisorLocationIDs => HelpersMethods.GetSettings();
        public static string TripAdvisorLanguages => HelpersMethods.GetSettings();
        #endregion API
    }
}
