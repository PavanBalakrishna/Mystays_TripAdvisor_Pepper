using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Mystays.TripAdvisor.Business.APIInvoker;
using Mystays.TripAdvisor.Business.ApiModels;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Mystays.TripAdvisor.Lambda.ConsumerService
{
    public class Invoker
    {
        
        public APIReturnModel GetResult()
        {
            return TripAdvisorAPIService.CallTripAdvisorAPI();
        }
    }
}
