using Project.Domain.Commons;

namespace Project.Domain.Entities;

public class Asset : Auditable
{
    public string Path { get; set; }
}
