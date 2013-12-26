using Howzzzat.Controllers;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Howzzzat.Infra
{
    public class CustomControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            var controllerObject = ObjectFactory.GetInstance(controllerType) as IController;

            return controllerObject;
        }
    }
}