using Microsoft.EntityFrameworkCore;
using DavArt.DAL;
using DavArt.DAL.Repositories.Interfaces;
using DavArt.DAL.Repositories;
using DavArt.BLL.Services.Interfaces;
using DavArt.BLL.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DavArtContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DavArtConnection")));
builder.Services.AddScoped<IUnitOfWork, UnitOfwork>();
builder.Services.AddScoped<IParsedProductRepository, ParsedProductRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ISourceRepository, SourceRepository>();
builder.Services.AddScoped<IVendorRepository, VendorRepository>();
builder.Services.AddScoped<IParsedProductRepository, ParsedProductRepository>();
builder.Services.AddScoped<IParserInterface, ParserInterface>();
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
