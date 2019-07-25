using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;
namespace Supermarket.API.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController
    {
        private readonly ICategoryService _categoryservice;

        public CategoriesController(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;

        }


       
       [HttpGet]
    
        public async Task<IEnumerable<Category>> GetAllAsync()

        {
            var categories=await _categoryservice.ListAsync();
            return categories;
        }

        

    }
}