using BlazorApartman.Infrastructure.Data;
using Core;
using MediatR;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();
builder.Services.AddMvcCore().AddApiExplorer();
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
builder.Services.AddMediatR(typeof(MappingProfile).Assembly);
builder.Services.AddControllers(options =>
{
    options.UseNamespaceRouteToken();
});

string connectionString = builder.Configuration.GetConnectionString("DeloitteConnection");
builder.Services.AddDatabaseConfigureServices(connectionString);
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Lottary", Version = "v1" });
});
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllers();
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());


app.Run();
