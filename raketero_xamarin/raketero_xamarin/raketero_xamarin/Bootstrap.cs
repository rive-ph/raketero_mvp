using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using raketero_xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin
{
    public sealed class Bootstrap 
    {

        public static void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<BaseScreen>().AsSelf();
            IContainer container = builder.Build();

            AutofacServiceLocator asl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => asl);
        }

    }
}