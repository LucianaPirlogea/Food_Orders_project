using Food_Orders.Entities.DTOs;
using Food_Orders.Repositories.RestaurantRepository;
using Food_Orders.Repositories.Detalii_contactRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Food_Orders.Entities;
using Food_Orders.Repositories.Fel_mancareRepository;
using Food_Orders.Repositories.MeniuRepository;
using Food_Orders.Services.RestaurantService;
using Food_Orders.Models.DTOs;

namespace Food_Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantRepository _repository;
        private readonly IDetalii_contactRepository _repository2;
        private readonly IFel_mancareRepository _repository3;
        private readonly IMeniuRepository _repository4;
        private readonly IRestaurantService _serviceRestaurant;
        public RestaurantController(IRestaurantRepository repository, IDetalii_contactRepository repository2, IFel_mancareRepository repository3, IMeniuRepository repository4, IRestaurantService serviceRestaurant)
        {
            _repository = repository;
            _repository2 = repository2;
            _repository3 = repository3;
            _repository4 = repository4;
            _serviceRestaurant = serviceRestaurant;
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
        public async Task<IActionResult> GetMenuByRestaurantName(string name)
        {
            var restaurant = await _serviceRestaurant.GetRestaurantByName(name);
            var menus = new List<Meniu>();
            menus = await _repository4.GetAllMenusByRestaurantId(restaurant.Id);
            var feluri = new List<Fel_mancareDTO>();

            foreach (var menu in menus)
            {
                var aux_fel_mancare = await _repository3.GetByIdAsync(menu.Fel_mancareId);
                var fel_mancare = new Fel_mancareDTO(aux_fel_mancare);
                feluri.Add(fel_mancare);
            }
            return Ok(feluri);
        }
    }
}
