using Articles.Models;


namespace Vlog.Services.Articles;

public class ArticleService : IArticleService
{
    private static readonly Dictionary<Guid, Article> _articles = new();

    public void CreateArticle(Article article)
    {
        _articles.Add(article.Id, article);
    }

    public Article GetArticle(Guid id)
    {
        return _articles[id];
    }

    public void DeleteArticle(Guid id)
    {
        _articles.Remove(id);
    }
    public void UpdateArticle(Article article)
    {
        _articles[article.Id] = article;
    }
}