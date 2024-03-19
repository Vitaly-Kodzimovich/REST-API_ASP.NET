using Microsoft.AspNetCore.Mvc;
using Vlog.Contracts.Article;
using Articles.Models;
using Vlog.Services.Articles;

namespace Vlog.Controllers;

[ApiController]
[Route("articles")]
public class ArcticlesController : ControllerBase
{
    private readonly IArticleService _articleService;

    public ArcticlesController(IArticleService articleService)
    {
        _articleService = articleService;
    }

    [HttpPost]
    public IActionResult CreateArticle(CreateArticleRequest request)
    {
        var article = new Article(
            Guid.NewGuid(),
            request.Name,
            request.Description,
            request.PublishDateTime,
            DateTime.UtcNow,
            request.Category,
            request.Tags);

        _articleService.CreateArticle(article);

        var response = new ArticleResponse(
            article.Id,
            article.Name,
            article.Description,
            article.PublishDateTime,
            article.LastModifiedDateTime,
            article.Category,
            article.Tags);

        return CreatedAtAction(
            actionName: nameof(GetArticle),
            routeValues: new {id = article.Id},
            value: response);
    }
    
    [HttpGet("{id:guid}")]
    public IActionResult GetArticle(Guid id)
    {
        Article article = _articleService.GetArticle(id);

        var response = new ArticleResponse(
            article.Id,
            article.Name,
            article.Description,
            article.PublishDateTime,
            article.LastModifiedDateTime,
            article.Category,
            article.Tags);

        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateArticle(Guid id, UpdateArticleRequest request)
    {
        var article = new Article(
            id,
            request.Name,
            request.Description,
            request.PublishDateTime,
            DateTime.UtcNow,
            request.Category,
            request.Tags);

        _articleService.UpdateArticle(article);


        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteArticle(Guid id)
    {
        _articleService.DeleteArticle(id);
        return NoContent();
    }
}