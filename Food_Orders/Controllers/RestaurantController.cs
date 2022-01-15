using Food_Orders.Entities.DTOs;
using Food_Orders.Repositories.RestaurantRepository;
using Food_Orders.Repositories.Detalii_contactRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantRepository _repository;
        private readonly IDetalii_contactRepository _repository2;

        public RestaurantController(IRestaurantRepository repository, IDetalii_contactRepository repository2)
        {
            _repository = repository;
            _repository2 = repository2;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRestaurants()
        {
            var restaurants = await _repository.GetAllRestaurantsWithContact();

            var restaurantsToReturn = new List<RestaurantDTO>();

            foreach (var restaurant in restaurants)
            {
                var auxRestaurant = new RestaurantDTO(restaurant);
                var contact2 = await _repository2.GetByRestaurantId(auxRestaurant.Id);
                if(contact2!=null)
                {
                   var contact = new Detalii_contactDTO(contact2);
                   auxRestaurant.Detalii_Contact = contact;
                }
                
                restaurantsToReturn.Add(auxRestaurant);
            }

            return Ok(restaurantsToReturn);
        }

        [HttpGet("{name}")]

        public async Task<IActionResult> GetRestaurantByName(string name)
        {
            var restaurant = await _repository.GetByName(name);

            var restaurantToReturn = new RestaurantDTO(restaurant);
            var contact2 = await _repository2.GetByRestaurantId(restaurantToReturn.Id);
            if (contact2 != null)
            {
                var contact = new Detalii_contactDTO(contact2);
                restaurantToReturn.Detalii_Contact = contact;
            }

            return Ok(restaurantToReturn);
        }
    }
}
