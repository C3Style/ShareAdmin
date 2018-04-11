using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ShareAdmin.EntityFramework.Repositories
{
    public abstract class ShareAdminRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ShareAdminDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ShareAdminRepositoryBase(IDbContextProvider<ShareAdminDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ShareAdminRepositoryBase<TEntity> : ShareAdminRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ShareAdminRepositoryBase(IDbContextProvider<ShareAdminDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
