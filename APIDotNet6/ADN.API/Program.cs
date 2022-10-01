using ADN.Data.Repository;
using ADN.Domain.DTO.Settings;
using ADN.Domain.Interfaces.Repository;
using ADN.Domain.Interfaces.Service;
using ADN.Service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MongoDbStudentSettings>(
    builder.Configuration.GetSection("MongoDbStudentSettings"));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
