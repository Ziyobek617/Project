using System.Threading.Tasks;

namespace Project.Domain.Entities;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public IEnumerable<Draft> Projects { get; set; }
    public IEnumerable<Assignment> Tasks { get; set; }
}
