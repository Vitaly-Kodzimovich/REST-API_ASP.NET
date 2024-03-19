namespace Vlog.Contracts.Article{

public record ArticleResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime PublishDateTime,
    DateTime LastModifiedDateTime,
    List<string> Category,
    List<string> Tags
    );
}