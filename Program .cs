using Autoservice_Back;
using Autoservice_Back.Interfaces;
using Autoservice_Back.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(connection));
builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore) ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IClients, ClientRepository>();
builder.Services.AddTransient<ICars, CarRepository>();
builder.Services.AddTransient<IOrders, OrderRepository>();
builder.Services.AddTransient<IOrdersWithoutReg, OrderWithoutRegRepository>();
builder.Services.AddTransient<IOrdersWithoutReg, OrderWithoutRegRepository>();
 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseCors(builder => builder
   .AllowAnyOrigin()
   .AllowAnyMethod()
   .AllowAnyHeader());
    
app.MapControllers();

app.Run();