namespace webapi_cshap.Models.Common;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
};