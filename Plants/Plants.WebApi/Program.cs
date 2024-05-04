using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Plants.Persistent;
using Plants.Persistent.Migrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(o =>
        o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())
    );
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Host
    .ConfigureServices((ctx, services) =>
    {
        //services.AddApplicationServices(ctx.Configuration);

        var dbSettings = ctx.Configuration.GetRequiredSection("PgsSettings").Get<PgsSettings>();
        services.AddSingleton<PgsSettings>(dbSettings);
        services.AddDbContext<PlantsDbContext>(options =>
            options.UseNpgsql(dbSettings.ConnectionString));
    });

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

await app.MigrateDbAsync();

app.Run();