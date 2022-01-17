using Food_Orders.Entities;
using Food_Orders.Entities.DTOs;
using Food_Orders.Repositories.Detalii_contactRepository;
using Food_Orders.Repositories.RestaurantRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Services.RestaurantService
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _repository;
        private readonly IDetalii_contactRepository _repository2;

        public RestaurantService(IRestaurantRepository repository, IDetalii_contactRepository repository2)
        {
            _repository = repository;
            _repository2 = repository2;
        }
        public async Task<RestaurantDTO> GetRestaurantByName(string name)
        {
            var restaurant = await _repository.GetByName(name);

            var restaurantToReturn = new RestaurantDTO(restaurant);
            var contact2 = await _repository2.GetByRestaurantId(restaurantToReturn.Id);
            if (contact2 != null)
            {
                var contact = new Detalii_contactDTO(contact2);
                restaurantToReturn.Detalii_Contact = contact;
            }

            return restaurantToReturn;
        }
    }
}
