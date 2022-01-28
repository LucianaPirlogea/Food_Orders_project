using Food_Orders.Models.Entities;
using Food_Orders.Repositories.ClientRepository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _repository;
        
        public ClientController(IClientRepository repository)
        {
            _repository = repository;
        }

    }
}
