using Microsoft.AspNetCore.Mvc;  
using System.Collections.Generic;  

namespace HybridBusinessPOS.API.Controllers  
{  
    [ApiController]  
    [Route("api/[controller]")]  
    public class ProductsController : ControllerBase  
    {  
        private static List<string> products = new List<string>();  

        [HttpGet]  
        public ActionResult<IEnumerable<string>> GetAllProducts()  
        {  
            return Ok(products);  
        }  

        [HttpPost]  
        public ActionResult AddProduct([FromBody] string product)  
        {  
            products.Add(product);  
            return CreatedAtAction(nameof(GetAllProducts), new { name = product });  
        }  
    }  

    [ApiController]  
    [Route("api/[controller]")]  
    public class CustomersController : ControllerBase  
    {  
        private static List<string> customers = new List<string>();  

        [HttpGet]  
        public ActionResult<IEnumerable<string>> GetAllCustomers()  
        {  
            return Ok(customers);  
        }  

        [HttpPost]  
        public ActionResult AddCustomer([FromBody] string customer)  
        {  
            customers.Add(customer);  
            return CreatedAtAction(nameof(GetAllCustomers), new { name = customer });  
        }  
    }  

    [ApiController]  
    [Route("api/[controller]")]  
    public class OrdersController : ControllerBase  
    {  
        private static List<string> orders = new List<string>();  

        [HttpGet]  
        public ActionResult<IEnumerable<string>> GetAllOrders()  
        {  
            return Ok(orders);  
        }  

        [HttpPost]  
        public ActionResult AddOrder([FromBody] string order)  
        {  
            orders.Add(order);  
            return CreatedAtAction(nameof(GetAllOrders), new { name = order });  
        }  
    }  
}