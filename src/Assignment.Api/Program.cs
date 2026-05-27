using Assignment.Api.Data;
using Assignment.Api.Endpoints;
using Assignment.Api.OpenApi;
using Assignment.Api.Security;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCorsConfiguration();
builder.Services.AddOpenApiConfiguration();

builder.Services.AddDbContext<AssignmentDbContext>(x =>
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")));

var app = builder.Build();

app.UseCors("All");
app.UseHttpsRedirection();

app.MapOpenApiEndpoints();
app.MapAssignmentEndpoints();

app.Run();