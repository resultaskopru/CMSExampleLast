using CMSExample.DataAccess.Repository;
using System;
namespace CMSExample.DataAccess.UnitOfWork

{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        int Complete();
        IArticleRepository Articles { get; }
    }
}
