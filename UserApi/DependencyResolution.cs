namespace UserApi
{
    public static class DependencyResolution
    {
        public static IServiceCollection AddUserServices(this IServiceCollection services)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }

        public static WebApplication MapUserControllers(this WebApplication webApplication)
        {
            webApplication.MapControllers();
            return webApplication;
        }
    }
}
