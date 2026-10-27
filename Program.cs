using Ecotech.Models;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(options =>
    options.UseInMemoryDatabase("TodoList")
);
builder.Services.AddDbContext<ElectronicEquipmentContext>(options =>
    options.UseInMemoryDatabase("ElectronicEquipment")
);
builder.Services.AddDbContext<PersonContext>(options =>
    options.UseInMemoryDatabase("Person")
);
builder.Services.AddDbContext<FavoriteContext>(options =>
    options.UseInMemoryDatabase("Favorite")
);
builder.Services.AddDbContext<AdvertisementContext>(options =>
    options.UseInMemoryDatabase("Advertisement")
);
builder.Services.AddDbContext<IdentityContext>(options =>
    options.UseInMemoryDatabase("Identity")
);
builder.Services.AddDbContext<OrderContext>(options =>
    options.UseInMemoryDatabase("Order")
);

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
