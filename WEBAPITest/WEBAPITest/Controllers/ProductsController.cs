using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBAPITest.Models;
namespace WEBAPITest.Controllers
{
    public class ProductsController : ApiController
    {

        public IEnumerable<Products> GetAllProducts()
        {
            return GetProduct();
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = GetProduct().FirstOrDefault(p => p.Id == id);
            if(product != null)
            {
                return Ok(product);
            }
            return NotFound();
        }


        private static Products[] GetProduct()
        {
            return new Products[]{

                new Products{Id=1, Name="Apple", Category="Groceries", Price=1},
                new Products{Id=2, Name="AeroPlane", Category="Toys", Price=11.2M},
                new Products{Id=3, Name="Watch", Category="Electronics", Price=100},
                new Products{Id=4, Name="Switch", Category="Electrical", Price=10},
            };
        }

    }
}
