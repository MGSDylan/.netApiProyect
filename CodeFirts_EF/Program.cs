using CodeFirts_EF;
using CodeFirts_EF.data;
using CodeFirts_EF.PeliculaRepository;
using CodeFirts_EF.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPeliculaRepository, PeliculaRepository>();  

builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();
builder.Services.AddScoped<IUniToWork, UniToWork>();
builder.Services.AddScoped<InsertPeliculaWthGeneroService>();

builder.Services.AddDbContext<DbAppContext>(op=>
op
//.UseLazyLoadingProxies()

.UseLazyLoadingProxies()
.AddInterceptors(new ReadExampleInterceptor())
.UseMySql(builder.Configuration.GetConnectionString("conex"),
    new MySqlServerVersion(new Version(8, 0, 23)))
    
);

builder.Services.Configure<JsonOptions>(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<DbAppContext>();
    context.Database.Migrate();

}

app.UseAuthorization();

app.MapControllers();

app.Run();
