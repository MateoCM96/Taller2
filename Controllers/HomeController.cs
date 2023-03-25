using Microsoft.AspNetCore.Mvc;

namespace Taller2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {

        public static List<Class> ListItem = new List<Class>()
        {

            new Class()
            {
                nombre = "cindy",
                cc = 123,
                direccion = "cra 62 calle 12",
                tel = "7654",
                fn = DateTime.Parse("2012-07-12")

    },

            new Class()
            {
                nombre = "entes",
                cc = 1234,
                direccion = "cra 6 calle 12",
                tel = "76548",
                fn = DateTime.Now

            }


        };

        [HttpGet("Consultar")]
        public List<Class> Consultar()
        {
            return ListItem;
        }
    }
}
