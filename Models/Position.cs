using Microsoft.Build.Framework;

namespace PestKitAB104.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
