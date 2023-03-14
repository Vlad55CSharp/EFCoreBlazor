using System.ComponentModel.DataAnnotations.Schema;
namespace EFCoreBlazorMigrations.Models
{
    public class Department
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
    }

    [Table("UserData")]
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public string? Role { get; set; } //новое свойство - роль пользователя в системе
        [Column("Added")]
        public DateTime? CreatedAt { get; set; }
        public Department? Department { get; set; }
    }
}
