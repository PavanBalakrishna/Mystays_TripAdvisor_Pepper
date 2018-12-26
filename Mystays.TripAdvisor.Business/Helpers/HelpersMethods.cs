using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mystays.TripAdvisor.Business.Helpers
{
    public static class HelpersMethods
    {
        public static string GetSettings([CallerMemberName]string key="")
        {
            return Environment.GetEnvironmentVariable(key);
        }

        public static void SetSettings(string value, [CallerMemberName]string key = "")
        {
            Environment.SetEnvironmentVariable(key, value);
        }
    }
}
