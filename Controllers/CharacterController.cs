using dotnet_udemy_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_udemy_project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
         private static Character knight = new Character(); 

         public IActionResult Get(){
             return Ok(knight);
         }
    }
}