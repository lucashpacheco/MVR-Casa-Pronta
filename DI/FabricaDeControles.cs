using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;

namespace MVR_Casa_Pronta.DI
{
    public class FabricaDeControles : System.Web.Mvc.DefaultControllerFactory
    {
        protected override System.Web.Mvc.IController GetControllerInstance
            (System.Web.Routing.RequestContext requestContext , Type controllerType)
        {
            if (controllerType != null)
            {
                return (System.Web.Mvc.IController)
                    Container.UnityContainer.Resolve(controllerType);
            }
            return base.GetControllerInstance(requestContext, controllerType);
        }
    }
}