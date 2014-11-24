using Ninject;
using System;
using System.Web.Mvc;
using System.Web.Routing;
using appGuild.Domain.Abstract;
using appGuild.Domain.Concrete;

namespace appGuild.Web.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            // Здесь размещаются дополнительные привязки
            ninjectKernel.Bind<ICharacterRepository>().To<EFCharacterRepository>();
        }
    }
}