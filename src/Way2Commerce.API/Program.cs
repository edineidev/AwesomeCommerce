using Way2Commerce.Domain.Repositories;
using Way2Commerce.Data.PostgreSQL.Repositories;
using Way2Commerce.Data.PostgreSQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var databaseUrl = builder.Configuration.GetValue<string>("DATABASE_URL_PS");

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    .Replace("%DATABASE_URL_PS%", databaseUrl);

builder.Services.AddDbContext<ProductingContext>(options => options.UseNpgsql(
    connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

builder.Configuration.GetConnectionString("BloggingContext");