using firstnet.Application.Interface;
using firstnet.Application.Apply;
using Microsoft.EntityFrameworkCore;
using firstnet.Infrastracture.Interface;
using firstnet.Infrastracture.Apply;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var mysql = builder.Configuration.GetConnectionString("JoshuaBackEnd");
builder.Services.AddDbContext<firstnet.Data.Context>(c  => {
    c.UseMySql(mysql,ServerVersion.AutoDetect(mysql));
});
builder.Services.AddScoped(typeof(IBaseRepositery<>),typeof(BaseRepositery<>));
builder.Services.AddScoped<IMemberRepositery,MemberRepositery>();
builder.Services.AddScoped<IMember,ApplyMember>();
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
