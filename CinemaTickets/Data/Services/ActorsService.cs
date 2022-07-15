using CinemaTickets.Data.Base;
using CinemaTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) : base(context)
        {

        }

    }
}
