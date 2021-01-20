using Autofac;
using shitAPp.Data;
using shitAPp.ViewModel;

namespace shitAPp.Startup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();

            builder.RegisterType<AppDataService>().As<IAppDataService>();
            
            return builder.Build();
        }
    }
}
