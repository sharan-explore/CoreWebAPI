using Supermarket.API.Persistence.Contexts;

namespace Supermarket.API.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;  //Dependency Injectuon

        public BaseRepository(AppDbContext context)//Dependency Injectuon
        {
            _context = context;
        }
    }
}