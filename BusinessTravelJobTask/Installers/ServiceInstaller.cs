﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessTravelJobTask.Factories;
using BusinessTravelJobTask.Services;
using BusinessTravelJobTask.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static BusinessTravelJobTask.ViewModels.SearchVm;

namespace BusinessTravelJobTask.Installers
{
    public class ServiceInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(ITravelDataService<,>), typeof(TravelDataService<,>));//param less ctor fixed error!            
        }
    }
}
