using FirstAPiApp.Contexts;
using FirstAPiApp.Interfaces;
using FirstAPiApp.Models;
using FirstAPiApp.Repositories;
using FirstAPiApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Contexts
builder.Services.AddDbContext<HRContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("MyCon"));
});
#endregion

#region Repositories
    builder.Services.AddScoped<IRepository<int,Department>,DepartmentRepository>();
    builder.Services.AddScoped<IRepository<int,Employee>,EmployeeRepository>();
#endregion

#region Mappers
builder.Services.AddAutoMapper(typeof(Department));
builder.Services.AddAutoMapper(typeof(Employee));
#endregion

#region Services
builder.Services.AddScoped<IDepartmentService, DepartmnetService>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
