using Abp.MultiTenancy;
using Coders.MVC5.Authorization.Users;

namespace Coders.MVC5.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}