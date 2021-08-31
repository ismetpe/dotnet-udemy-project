using System.Collections.Generic;
using dotnet_udemy_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_udemy_project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
         private static List<Character> characters = new List<Character>(){
             new Character(),
             new Character{ Name = "Sam"}

         };
         

        [HttpGet]
         public ActionResult<List<Character> > Get(){
             return Ok(characters);
         }

         [HttpGet]

         public ActionResult<Character> GetSingle(){
             return Ok(characters[0]);
         }
    }
}