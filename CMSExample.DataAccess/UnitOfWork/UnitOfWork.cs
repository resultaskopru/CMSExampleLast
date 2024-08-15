using CMSExample.DataAccess.Data;
using CMSExample.DataAccess.Repository;

namespace CMSExample.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Articles = new ArticleRepository(_context);

        }

        public IProductRepository Products { get; private set; }
        public IArticleRepository Articles { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
