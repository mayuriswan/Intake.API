using Intake.API.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace Intake.Api.Extentions
{
    public static class MigrationExtentions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            using IntakeDbContext dbContext = scope.ServiceProvider.GetRequiredService<IntakeDbContext>();
            dbContext.Database.Migrate();

            // Test

        }
    }
}

