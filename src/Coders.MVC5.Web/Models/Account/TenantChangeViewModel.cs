using Abp.AutoMapper;
using Coders.MVC5.Sessions.Dto;

namespace Coders.MVC5.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}