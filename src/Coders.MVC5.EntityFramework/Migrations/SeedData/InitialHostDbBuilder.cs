using Coders.MVC5.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Coders.MVC5.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MVC5DbContext _context;

        public InitialHostDbBuilder(MVC5DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
