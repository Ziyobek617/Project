using System.Threading.Tasks;

namespace Project.Domain.Entities;

public class Draft
{
    public string Name { get; set; }
    public string Description { get; set; }
    public IEnumerable<User> TeamMembers { get; set; }
    public IEnumerable<Assignment> Tasks { get; set; }
}
