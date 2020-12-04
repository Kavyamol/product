using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BakedInHeaven.API.Model;
using BakedInHeaven.API.Context;

namespace BakedInHeaven.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("Products")]
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            using var dbContext = new BakeryDbContext();
            return dbContext.Products.ToList();

        }

        [Route("Products")]
        [HttpPost]
        public bool CreateProducts(Product products)
        {
            using var dbContext = new BakeryDbContext();

            dbContext.Products.Add(products);
            dbContext.SaveChanges();

            return true;

        }


    }
}