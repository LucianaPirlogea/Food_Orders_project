using Food_Orders.Entities;
using Food_Orders.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Services.RestaurantService
{
    public interface IRestaurantService
    {
        Task<RestaurantDTO> GetRestaurantByName(string name);
    }
}
