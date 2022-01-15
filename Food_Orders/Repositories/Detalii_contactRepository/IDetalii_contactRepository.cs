using Food_Orders.Entities;
using Food_Orders.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Orders.Repositories.Detalii_contactRepository
{
    public interface IDetalii_contactRepository : IGenericRepository<Detalii_contact>
    {
        Task<Detalii_contact> GetByRestaurantId(int id);
    }
}
