using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService,UserService>();
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddDbContext<AppDbContext>(options =>
    { options.UseSqlServer(builder.Configuration.GetConnectionString("SampleConnection")); }
);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#region DataBase Context



#endregion

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();