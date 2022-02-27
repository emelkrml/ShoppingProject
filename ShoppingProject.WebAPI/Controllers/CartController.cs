using Microsoft.AspNetCore.Mvc;
using ShoppingProject.Business.Abstract;
using ShoppingProject.Entity.Data;
using ShoppingProject.Entity.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShoppingProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private IDatabaseBUsiness database;
        private ILogBusinesss log;

        public CartController(IDatabaseBUsiness _database, ILogBusinesss _log)
        {
            database = _database;
            log = _log;
        }

        // GET: api/<CartController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CartController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CartController>
        [HttpPost]
        public void Post(int productId)
        {

        }


        [HttpPut("{productId}/{selectedProduct}")]
        // selectedProduct: seçilen ürün miktarı
        public IActionResult Put(int productId, short selectedProduct)
        {
            GeneralLog generallog = new GeneralLog();

            var getResult = database.Product.GetByID(productId);

            if (getResult.Success && getResult.Data != null)
            {
                int stock = getResult.Data.UnitsInStock - selectedProduct;
                getResult.Data.UnitsInStock = (short)stock;
                var updateResult = database.Product.Update(getResult.Data);
                database.SaveChanges();

                log.GeneralLog.Add(new GeneralLog
                {
                    Date = DateTime.Now,
                    LogInfo = "[Cart/productId/selectedProduct] " + productId.ToString() + " ürünün stoğundan " + selectedProduct.ToString() + " tane ürün düşüldü.",
                    LogName = "INFO"
                });

                return Ok(updateResult.Message);
            }

            log.GeneralLog.Add(new GeneralLog
            {
                Date = DateTime.Now,
                LogInfo = "[Cart/productId/selectedProduct] getResult success dönmedi",
                LogName = "ERROR"
            });

            generallog.Date = DateTime.Now;

            return BadRequest(getResult.Message);
        }

        // DELETE api/<CartController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
