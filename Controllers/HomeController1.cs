using Microsoft.AspNetCore.Mvc;

namespace Taller2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController1 : Controller
    {
        public static List<Class1> ListItem = new List<Class1>()
        {
             new Class1()
            {
                nombre = "Mateo",
                codigo = 12345,
                precio = 4567890,
                estado = true
            },

             new Class1()
            {
                nombre = "Mateocm",
                codigo = 123456789,
                precio = 456789098,
                estado = false
            }
        };
        [HttpGet("Consultar")]
        public List<Class1> Consultar()
        {
            return ListItem;
        }
    } 

}
