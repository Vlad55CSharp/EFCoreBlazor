using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBlazorMigrations.Models
{
	[NotMapped] //исключили сущность из модели
	public class Address
	{
		public int Id { get; set; }
		public string? PostIndex { get; set; }
		public string? City { get; set; }
		public string? Street { get; set; }
	}
}
