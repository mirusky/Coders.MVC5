using System.Data.Common;
using System.Data.Entity;
using Abp.DynamicEntityParameters;
using Abp.Zero.EntityFramework;
using Coders.MVC5.Authorization.Roles;
using Coders.MVC5.Authorization.Users;
using Coders.MVC5.MultiTenancy;

namespace Coders.MVC5.EntityFramework
{
    public class MVC5DbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MVC5DbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MVC5DataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MVC5DbContext since ABP automatically handles it.
         */
        public MVC5DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MVC5DbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MVC5DbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DynamicParameter>().Property(p => p.ParameterName).HasMaxLength(250);
            modelBuilder.Entity<EntityDynamicParameter>().Property(p => p.EntityFullName).HasMaxLength(250);
        }
    }
}
