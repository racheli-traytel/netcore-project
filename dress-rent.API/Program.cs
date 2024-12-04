using dress_rent.core.interfaces;
using dress_rent.core.interfaces.services_interfaces;
using dress_rent.Data;
using dress_rent.Data.Repository;
using dress_rent.entities;
using dress_rent.Servise;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
//Add services to the container.
builder.Services.AddScoped<IRepository<DressEntity>, DressRepository>();
builder.Services.AddScoped<IRepository<orderEntity>, OrderRepository>();
builder.Services.AddScoped<IRepository<Order_DetailsEntity>, Order_detailsRepository>();
builder.Services.AddScoped<IRepository<CustomerEntity>, CustomerRepository>();
builder.Services.AddScoped<IRepository<CriticismEntity>, CriticismRepository>();
builder.Services.AddScoped<ICustomerService,CustomerService>();
builder.Services.AddScoped<IOrderService,OrderService>();
builder.Services.AddScoped<IOrder_DetailsService,Order_DetailsService>();
builder.Services.AddScoped<ICriticismService,CriticismService>();
builder.Services.AddScoped<IDressService,DressService>();
//builder.Services.AddSingleton<DataContext>();


builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer("Data Source = DESKTOP-SSNMLFD; Initial Catalog = dress_rent; Integrated Security = true; ");
}
 );


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

app.UseAuthorization();
app.MapControllers();
app.Run();
