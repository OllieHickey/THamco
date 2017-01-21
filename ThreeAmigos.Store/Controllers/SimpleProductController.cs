/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ThreeAmigos.Store.DAL;
using ThreeAmigos.Store.Models;

namespace ThreeAmigos.Store.Controllers
{
    public class SimpleProductController : ApiController
    {
        List<ProductViewModel> products = new List<ProductViewModel>();

        public SimpleProductController() { }

        public SimpleProductController(List<ProductViewModel> products)
        {
            this.products = products;
        }

        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            return products;
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllProductsAsync()
        {
            return await Task.FromResult(GetAllProducts());
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.ID == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        public async Task<IHttpActionResult> GetProductAsync(int id)
        {
            return await Task.FromResult(GetProduct(id));
        }
    }
}
*/