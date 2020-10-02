using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//using Microsoft.Practices.Unity;

namespace MVR_Casa_Pronta.DI
{
    public class HttpContextLifetimeManager<T> : Microsoft.Practices.Unity.LifetimeManager
    {
        public override void SetValue(object newValue)
        {
            HttpContext.Current.Items[typeof(T).AssemblyQualifiedName] = newValue;
        }
        public override object GetValue()
        {
            return HttpContext.Current.Items[typeof(T).AssemblyQualifiedName];
        }
        public override void RemoveValue()
        {
            HttpContext.Current.Items.Remove(typeof(T).AssemblyQualifiedName);
        }
    }
}
