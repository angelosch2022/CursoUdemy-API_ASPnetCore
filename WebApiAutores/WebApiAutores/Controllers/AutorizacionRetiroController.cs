using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/autorizacionretiro")]
    public class AutorizacionRetiroController
    {
        [HttpGet]
        public async Task<List<AutorizacionRetiro>> GetAll()
        {
            using(var db = new AlcosaEntities())
            {
                return await db.AutorizacionRetiros.OrderByDescending(x => x.IdAutorizacionRetiro).Where(x => x.IdAutorizacionRetiro == 2600).ToListAsync();
            }
        }
    }
}
