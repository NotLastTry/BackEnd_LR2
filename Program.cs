namespace BackEnd_Нагорнов_А.В._ЛР2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<ITimeService, LongTimeService>(); //Добавляем новый сервис в IServiceCollection
            var app = builder.Build(); //Создание объекта WebApplication
            app.Run(async context =>
            {
                var timeService = app.Services.GetService<ITimeService>();
                await context.Response.WriteAsync($"Time: {timeService?.GetTime()}");
            });
            app.Run();
        }
    }
}
