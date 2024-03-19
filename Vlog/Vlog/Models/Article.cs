namespace Articles.Models;

public class Article
{
    public Guid Id{get;}
    public string Name{get;}
    public string Description{get;}
    public DateTime PublishDateTime{get;}
    public DateTime LastModifiedDateTime{get;}
    public List<string> Category{get;}
    public List<string> Tags {get;}

    public Article(
        Guid id,
        string name, 
        string description,
        DateTime publishDateTime,
        DateTime lastModifiedDateTime,
        List<string> category,
        List<string> tags)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
        this.PublishDateTime = publishDateTime;
        this.LastModifiedDateTime = lastModifiedDateTime;
        this.Category = category;
        this.Tags = tags;
    }
}