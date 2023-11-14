using Project.Domain.Enums;
using System.Threading.Tasks;

namespace Project.Domain.Entities;

public class Assignment
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public TasksStatus Status { get; set; }
    public TasksPriority Priority { get; set; }
    public IEnumerable<Comment> Comments { get; set; }
    public long DraftId { get; set; }
    public Draft Draft { get; set; }
}
