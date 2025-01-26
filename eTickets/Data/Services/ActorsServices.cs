using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eTickets.Data.Services
{
    public class ActorsServices: EntityBaseRepository<Actor>, IActorsServices
    {
       
        public ActorsServices(AppDbContext context): base(context)
        {

        }

       
    }
} 
