using ItemService.Infrastructure;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddTransient<IItemRepository, ItemRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationInsightsTelemetry();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

var pathBase = builder.Configuration.GetValue<string>("PathBase");
if (!String.IsNullOrEmpty(pathBase))
{
    app.UsePathBase(pathBase);
}

app.UseSwagger(c =>
{
    c.PreSerializeFilters.Add((swaggerDoc, httpReq) =>
    {
        if (httpReq.Headers.TryGetValue("X-Forwarded-Host", out var host))
        {
            swaggerDoc.Servers = new List<OpenApiServer> { new OpenApiServer { Url = $"https://{host}{pathBase}" } };
        }
    });
});

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint(pathBase + "/swagger/v1/swagger.json", "Item Service API V1");
    c.RoutePrefix = string.Empty;
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
