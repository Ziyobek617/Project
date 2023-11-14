using System.Threading.Tasks;

namespace Project.Domain.Entities;

public class Comment
{
    public string Text { get; set; }
    public long TaskId { get; set; }
    public Assignment Assignment { get; set; }
}
