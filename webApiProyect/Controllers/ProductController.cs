using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace webApiProyect.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<ProductService>> GetAll()
        {
            return products;
        }

        [HttpGet("{id}")]
        public ActionResult<ProductService> Get(int id)
        {
            return products.Single(x=>x.Id==id);
        }

        [HttpPost]
        public ActionResult Create(ProductService model)
        {
            model.Id = products.Count() + 1;
            products.Add(model);
            return CreatedAtAction(
                "Get",
                new { id = model.Id },
                model);
        }

        [HttpPut("{productId}")]
        public ActionResult update(int productId, ProductService model)
        {
            var originalEntry = products.Single(x => x.Id == productId);
            originalEntry.Name= model.Name;
            originalEntry.Description= model.Description;
            originalEntry.Price= model.Price;

            return NoContent();
        }

        [HttpDelete("{productId}")]
        public ActionResult delete(int productId)
        {
            products= products.Where(x=>x.Id!= productId).ToList();

            return NoContent();
        }





        public static List<ProductService> products = new List<ProductService>()
        {

            new ProductService
            {
                Id=1,
                Name="Guitarra Electrica",
                Price=1200,
                Description="Ideal para tocar jazz"

            },
            new ProductService
            {
                Id=2,
                Name="Amplificador para guitarra electrica",
                Price=1200,
                Description="Amplificador con sonido claro"
            },
        };


    }
}
