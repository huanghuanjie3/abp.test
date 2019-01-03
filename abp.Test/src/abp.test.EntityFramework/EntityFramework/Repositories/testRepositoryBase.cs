using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace abp.test.EntityFramework.Repositories
{
    public abstract class testRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<testDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected testRepositoryBase(IDbContextProvider<testDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class testRepositoryBase<TEntity> : testRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected testRepositoryBase(IDbContextProvider<testDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
