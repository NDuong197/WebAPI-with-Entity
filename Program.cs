using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Data;
using System;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

if (1 < 0) // Gán cứng bằng lệnh
{
    builder.Services.AddDbContext<StudentContext>(options =>
        options.UseSqlServer("Server=Gia\\SQLEXPRESS;Database=CMCUni2;Integrated Security=True;TrustServerCertificate=True"));
}
else
{
    builder.Services.AddDbContext<StudentContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDBConnectionString")));
}

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SchemaFilter<IgnoreIdSchemaFilter>();
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();