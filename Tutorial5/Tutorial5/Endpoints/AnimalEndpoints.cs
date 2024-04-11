// using Tutorial4.Models;
//
// namespace Tutorial4.Endpoints;
//
// public static class AnimalEndpoints
// {
//     public static void MapAnimalsEndpoints(this WebApplication app)
//     {
//         // Minimal API
//         // GET
//         app.MapGet("/animals-minimalapi/{id}", (int id) =>
//         {
//             if (id != 1)
//             {
//                 Results.NotFound();
//             }
//             // process data
//             Results.Ok("animals");
//         });
//         // 200 - Ok
//
//         // POST
//         app.MapPost("/animals-minimalapi", (Animal animal) =>
//         {
//             // process data
//             Results.Created("", animal);
//         });
//     }
// }