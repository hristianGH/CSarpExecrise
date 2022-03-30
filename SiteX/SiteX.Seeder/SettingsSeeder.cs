using SiteX.Data.Data;

namespace SiteX.Seeder
{
    public class SettingsSeeder
    {
        internal class SettingsSeeder : ISeeder
        {
            public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
            {
                if (dbContext.Settings.Any())
                {
                    return;
                }

                await dbContext.Settings.AddAsync(new Setting { Name = "Setting1", Value = "value1" });
                
            }
        }
}