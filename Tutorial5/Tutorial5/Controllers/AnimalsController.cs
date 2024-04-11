// using Microsoft.AspNetCore.Mvc;
// using Tutorial4.Database;
// using Tutorial4.Models;
//
// namespace Tutorial4.Controllers;
//
// [ApiController]
// [Route("[controller]")]
// public class AnimalsController : ControllerBase
// {
//     [HttpGet]
//     public IActionResult GetAnimals()
//     {
//         // var animals = StaticData.animals;
//         var animals = new MockDb().Animals;
//         return Ok("animals");
//     }
// }