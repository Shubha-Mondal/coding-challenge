using CodingChallenge.Data;
using CodingChallenge.GraphQL;
using CodingChallenge.Interfaces;
using CodingChallenge.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();

// Register custom services for the superheroes
builder.Services.AddScoped<IOfficeRepository, OfficeRepository>();
builder.Services.AddGraphQLServer().AddQueryType<Query>();

// Add Application Db Context options
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.MapControllers();
app.MapGraphQL("/graphql", "");

app.Run();
