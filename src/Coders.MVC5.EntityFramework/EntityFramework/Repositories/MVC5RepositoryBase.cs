using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Coders.MVC5.EntityFramework.Repositories
{
    public abstract class MVC5RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MVC5DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MVC5RepositoryBase(IDbContextProvider<MVC5DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MVC5RepositoryBase<TEntity> : MVC5RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MVC5RepositoryBase(IDbContextProvider<MVC5DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
