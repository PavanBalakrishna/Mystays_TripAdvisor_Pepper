﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mystays.TripAdvisor.Business.ApiModels
{
    public class APIReturnModel
    {
        public APIReturnModel()
        {
            locationModels = new List<LocationModel>();
        }
        public List<LocationModel> locationModels { get; set; }
    }
}
