using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_crud.Data;

namespace MVC_crud.Controllers
{
    public class CustomerHomeController : Controller
    {
        private readonly MVCDBContext mvcDBContext;

        public CustomerHomeController(MVCDBContext mvcDBContext)
        {
            this.mvcDBContext = mvcDBContext;
        }

        [HttpGet]

        public async Task<IActionResult> ListCust()
        {
            var customers = await mvcDBContext.Customers.ToListAsync();
            return View(customers);
        }
    }
}
