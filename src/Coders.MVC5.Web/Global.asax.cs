using System;
using System.IdentityModel.Claims;
using System.Net;
using System.Threading;
using System.Web.Helpers;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Abp.WebApi.Validation;
using Castle.Facilities.Logging;

namespace Coders.MVC5.Web
{
    public class MvcApplication : AbpWebApplication<MVC5WebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {

            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
            // ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );
            
            base.Application_Start(sender, e);
        }
    }
}
