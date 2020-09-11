using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace Coders.MVC5.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [MaxLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}
