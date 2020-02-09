using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Core
{
    public interface IHelperResourceFactory
    {
        T GetInstance<T>() where T : IHelper;
    }

    public abstract class HelperResourceFactoryBase : IHelperResourceFactory
    {
        // Helpers
        protected IDictionary<string, Type> Helpers = new Dictionary<string, Type>();

        public virtual TIHelper GetInstance<TIHelper>()
            where TIHelper : IHelper
        {
            return (TIHelper)Activator.CreateInstance(Helpers[typeof(TIHelper).Name]);
        }
    }
}
