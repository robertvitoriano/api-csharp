using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APICsharp.Data;
using APICsharp.Models;


namespace APICsharp.Controllers
{
    [ApiController]
    [Route("v1/products")]

    public class ProductController : ControllerBase
    {

    public async Task <ActionResult<List<Product>>> Get([FromServices] DataContext context)
    {
        var products = await context.Products.Include(x => x.Category).ToListAsync();
        
        return products;
    }

    }


 



}