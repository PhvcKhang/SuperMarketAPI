using SuperMarketAPI.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SuperMarketAPI.Infracstrure.Repositories
{
    public class BaseRepository : IRepository
    {
        protected ApplicationDbContext _context;
        public IUnitOfWork UnitOfWork => _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
