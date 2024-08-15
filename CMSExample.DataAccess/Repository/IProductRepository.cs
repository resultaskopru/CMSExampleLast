using CMSExample.DataAccess.Models;

namespace CMSExample.DataAccess.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetById(int id);
        void Update(object existingProduct);
    }
}
