using webapi_cshap.Models.Common;

namespace webapi_cshap.Models;

public class Character : BaseEntity
{
    public string Name { get; set; }
    public string Type { get; set; }
    
    public Character() {}
};