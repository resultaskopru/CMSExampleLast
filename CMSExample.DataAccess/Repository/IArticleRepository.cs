using CMSExample.DataAccess.Models;

namespace CMSExample.DataAccess.Repository
{
    public interface IArticleRepository : IRepository<Article>
    {
        Article GetById(int id);
        void Update(object existingArticle);
    }
}
