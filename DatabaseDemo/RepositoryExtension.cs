using DatabaseDemo.repository;
using Microsoft.Extensions.DependencyInjection;

namespace DatabaseDemo
{
    public static class RepositoryExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<PostgreDB>();
            services.AddScoped<EmployeesRepository>();
        }
    }
}