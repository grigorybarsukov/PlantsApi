using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Plants.Persistent.Migrations;

public static class WebApplicationMigrationExtension
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        await using var scope = app.Services.CreateAsyncScope();
        await using var db = scope.ServiceProvider.GetService<PlantsDbContext>();
        await db!.Database.MigrateAsync();
    }
}