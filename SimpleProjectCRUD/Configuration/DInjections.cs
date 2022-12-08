using Microsoft.Extensions.DependencyInjection;
using SimpleProjectCRUD.Database;
using SimpleProjectCRUD.Services;
using SimpleProjectCRUD.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProjectCRUD.Configuration
{
    public class DInjections
    {
        public IServiceProvider Provider { get; }
        public DInjections()
        {
            Provider = ConfigureServices();
        }

        private IServiceProvider? ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IMenuService, MenuService>();

            services.AddSingleton<CreateMenuView>();
            services.AddSingleton<CreatePriceView>();
            services.AddSingleton<DeleteView>();
            services.AddSingleton<UpdateView>();
            services.AddSingleton<ReportView>();

            return services.BuildServiceProvider();
        }
    }
}
