using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APICsharp.Data;
using APICsharp.Models;


namespace APICsharp.Controllers
{
    [ApiController]
    [Route("v1/caegories")]

    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>>  Get([FromServices] DataContext context)

        {
            var categories = await context.Categories.ToListAsync();
            return categories;

        }


        public async Task<ActionResult<Category>> Post ([FromServices] DataContext context,
        [FromBody] Category model)
        {
            if (ModelState.IsValid)
            {

                context.Categories.Add(model);
                await context.SaveChangesAsync();
                return model;

            }
            else
            {
                return BadRequest(ModelState);

            }
        }

    }



}
