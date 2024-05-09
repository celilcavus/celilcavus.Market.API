using celilcavus.Market.Model;
using celilcavus.Market.Model.Interfaces;
using celilcavus.Market.Model.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<MarketContext>(x => x.UseSqlServer("Server=91.151.90.223;Database=celil_;User Id=celil;Password=Pq6*k80c7;TrustServerCertificate=True;"));

builder.Services.AddScoped<IProduct, ProductRepository>();
builder.Services.AddScoped<ICategory,CategoryRepository>();
builder.Services.AddScoped<ISeller,SellerRepository>();
builder.Services.AddScoped<MarketContext, MarketContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();

