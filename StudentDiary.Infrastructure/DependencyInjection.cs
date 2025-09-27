using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentDiary.Infrastructure.Data;

namespace StudentDiary.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection")
            ?? "Data Source=studentdiary.db";

        services.AddDbContext<StudentDiaryContext>(options =>
            options.UseSqlite(connectionString));

        return services;
    }
}
