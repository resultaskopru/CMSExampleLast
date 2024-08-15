using CMSExample.DataAccess.Models;
using CMSExample.DataAccess.Data;

namespace CMSExample.DataAccess.Repository
{
    public class ArticleRepository:Repository<Article>,IArticleRepository
    {
        public ArticleRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Article GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(object existingArticle)
        {
            throw new NotImplementedException();
        }
    }
}
