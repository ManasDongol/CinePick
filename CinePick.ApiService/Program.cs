using CinePick.ApiService;
using CinePick.ApiService.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//for database
builder.Services.AddDbContext<CinePickDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();


builder.Services.AddIdentityCore<ApplicationUsers>(options =>
    {
        options.User.RequireUniqueEmail = true;
    })
    .AddEntityFrameworkStores<CinePickDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.MapOpenApi();

    const string scalarUiPath = "/api-reference";
    
    app.MapPost("/migrate-db", (CinePickDbContext dbContext) => dbContext.Database.MigrateAsync());

    app.MapScalarApiReference(scalarUiPath,
        options => options
            .WithTitle("CineP Api Reference")
            .WithFavicon("https://scalar.com/logo-light.svg")
            .WithTheme(ScalarTheme.DeepSpace)
            .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient));
            

    app.MapGet("/", () => Results.Redirect(scalarUiPath, permanent: true))
        .ExcludeFromDescription();
}



app.MapControllers();
app.MapDefaultEndpoints();


app.Run();

