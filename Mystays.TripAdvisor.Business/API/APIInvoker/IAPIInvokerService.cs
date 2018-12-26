using Mystays.TripAdvisor.Business.API.ApiModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mystays.TripAdvisor.Business.API.APIInvoker
{
    /// <summary>
    /// Interface used to fetch data from trip advisor
    /// </summary>
    public interface IAPIInvokerService
    {
        APIReturnModel CallTripAdvisorAPI();
    }
}
