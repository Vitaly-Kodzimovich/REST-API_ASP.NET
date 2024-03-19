namespace Vlog.Contracts.Article{

public record UpdateArticleRequest(
    string Name,
    string Description,
    DateTime PublishDateTime,
    List<string> Category,
    List<string> Tags
    );
}
