using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using StructureMap;

namespace Howzzzat.Controllers
{
    public class MyControllerFactory : DefaultControllerFactory
    {
        //protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        //{
        //    return base.GetControllerInstance(requestContext, controllerType);
        //}

        ////protected override IController GetControllerInstance(Type controllerType)
        ////{
        ////    return ObjectFactory.GetInstance(controllerType) as IController;


        ////    //return Activator.CreateInstance(controllerType,
        ////    //            new SqlServerLogger()) as IController;
        ////}
    }
}
