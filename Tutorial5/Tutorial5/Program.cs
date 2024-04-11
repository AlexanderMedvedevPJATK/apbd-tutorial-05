using Microsoft.AspNetCore.Http.HttpResults;
using Tutorial4.Database;
// using Tutorial4.Endpoints;
using Tutorial4.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers(); // Controllers
// builder.Services.AddSingleton<MockDb>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/animals/", () => Results.Ok(StaticData.Animals));

app.MapGet("/animals/{id}", (int id) =>
{
    var animal = StaticData.Animals.FirstOrDefault(animal => animal.Id == id);
    return animal != null ? Results.Ok(animal) : Results.NotFound();
});

// POST
app.MapPost("/animals", (Animal animal) =>
{
    StaticData.Animals.Add(animal);
    Results.Created("", animal);
});

app.MapPut("/animals/{id}", (int id, Animal editedAnimal) =>
{
    var index = StaticData.Animals.FindIndex(animal => animal.Id == id);
    if (index == -1)
    {
        return Results.NotFound();
    }
    editedAnimal.Id = id;
    StaticData.Animals[index] = editedAnimal;
    return Results.Ok(editedAnimal);
});

app.MapDelete("/animals/{id}", (int id) =>
{
    var index = StaticData.Animals.FindIndex(animal => animal.Id == id);
    if (index == -1)
    {
        return Results.NotFound();
    }
    var animal = StaticData.Animals[index];
    StaticData.Animals.RemoveAt(index);
    return Results.Ok(animal);
});

app.MapGet("/visits/animal/{id}", (int id) =>
{
    var visits = StaticData.Visits.FirstOrDefault(visit => visit.Animal.Id == id);
    return visits != null ? Results.Ok(visits) : Results.NotFound();
});

app.MapPost("/visits", (Visit visit) =>
{
    StaticData.Visits.Add(visit);
    Results.Created("", visit);
});

// Controllers
app.MapControllers();

app.Run();