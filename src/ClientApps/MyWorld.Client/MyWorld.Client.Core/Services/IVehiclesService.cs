﻿using MyWorld.Client.Core.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static Newtonsoft.Json.JsonConvert;

namespace MyWorld.Client.Core.Services
{

    public interface IVehiclesService
    {
        Task<IList<Vehicle>> GetVehiclesInArea(string tenantId, double topLatitude, double leftLongitude, double bottomLatitude, double rightLongitude);

        Task<IList<Vehicle>> GetAllVehiclesFromTenant(string tenantId);
    }

}