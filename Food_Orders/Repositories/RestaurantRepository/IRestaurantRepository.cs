using Food_Orders.Entities;
using Food_Orders.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Repositories.RestaurantRepository
{
    public interface IRestaurantRepository: IGenericRepository<Restaurant>
    {
        Task<Restaurant> GetByName(string name);
        Task<List<Restaurant>> GetAllRestaurantsWithContact();
    }
}
