using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;
using Supermarket.API.Domain.Repositories;

namespace Supermarket.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryrepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryrepository=categoryRepository;
        }
        
        public async Task<IEnumerable<Category>> ListAsync()  // Must implement from ICategoryService:ICategoryService
        {
                //Read the data from repository class
                //Injected the repositiry interface, 
               return await _categoryrepository.ListAsync(); //From CategoryRepository
        }
    }
}