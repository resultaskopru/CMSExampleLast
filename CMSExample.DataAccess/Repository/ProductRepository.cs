using CMSExample.DataAccess.Models;
using CMSExample.DataAccess.Data;

namespace CMSExample.DataAccess.Repository
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(object existingProduct)
        {
            throw new NotImplementedException();
        }
    }
}
