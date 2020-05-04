using Autofac;
using Caliburn.Micro;
using raketero_xamarin.Helpers;
using raketero_xamarin.Services;
using raketero_xamarin.Services.Concrete;
using System.Linq;
using Xamarin.Forms.Internals;

namespace raketero_xamarin
{
    public sealed class Bootstrap : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<App>().AsSelf().SingleInstance();
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<ViewModelNavigator>().As<IViewModelNavigator>().SingleInstance();
            builder.Register(x => { return new RestConfig("http://raketero-app.com/api_stage/api.php", "d5bcb964-968e-8694-ad43-62c0fd90410f"); })
                .As<IRestConfig>()
                .SingleInstance();




            builder.RegisterType<AccountsRepository>().As<IAccountsRepository>().SingleInstance();
            builder.RegisterType<ProfileRepository>().As<IProfileRepository>().SingleInstance();
            builder.RegisterType<SearchRepository>().As<ISearchRepository>().SingleInstance();




            // Registers only classes that match the ViewModel pattern.
            // Registers them as self and as implemented interfaces.
            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ForEach(viewModelType => builder.RegisterType(viewModelType).AsSelf().AsImplementedInterfaces());
        }
    }
}

