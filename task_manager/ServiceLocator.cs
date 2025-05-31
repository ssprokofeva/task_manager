using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_manager
{
    public class ServiceLocator
    {
        //private static IServiceProvider _provider;
        //public static void ConfigureServices()
        //{
        //    var services = new ServiceCollection();

        //    // Регистрация контекста БД (EF6)
        //    services.AddScoped<AppDbContext>();

        //    // Репозитории
        //    services.AddScoped<ITaskRepository, TaskRepository>();

        //    // Сервисы
        //    services.AddScoped<ITaskService, TaskService>();

        //    // ViewModels
        //    services.AddTransient<MainViewModel>();

        //    _provider = services.BuildServiceProvider();
        //}
        //public static T GetService<T>() => _provider.GetService<T>();
    }
}
