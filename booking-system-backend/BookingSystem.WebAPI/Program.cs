using BookingSystem.Application.Logic;
using BookingSystem.Application.LogicContracts;
using BookingSystem.Application.RepositoryContracts;
using BookingSystem.Data.Context;
using BookingSystem.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();
builder.Services.AddScoped<IReservationLogic, ReservationLogic>();
builder.Services.AddScoped<IRoomLogic, RoomLogic>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
