using Articles.Models;

namespace Vlog.Services.Articles;

public interface IArticleService
{
    //void ArticleResponse(Article article);
    Article GetArticle(Guid id);
    void CreateArticle(Article article);

    void DeleteArticle(Guid id);
    void UpdateArticle(Article article);
}