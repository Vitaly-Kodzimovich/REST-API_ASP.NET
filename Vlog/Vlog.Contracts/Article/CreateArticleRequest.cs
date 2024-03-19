namespace Vlog.Contracts.Article{

public record CreateArticleRequest(
    string Name,
    string Description,
    DateTime PublishDateTime,
    List<string> Category,
    List<string> Tags
    );
}
