using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            Bootstrap.Initialize();


        }

        public BaseScreen Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<BaseScreen>();
            }
        }
    }
}
