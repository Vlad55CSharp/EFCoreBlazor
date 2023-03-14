using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreBlazorMigrations.Models
{
	public class Address
	{
		public int Id { get; set; }
		//[Column("postal_index")] //изменили имя столбца в таблице БД
		public string? PostIndex { get; set; }
		public string? City { get; set; }
		public string? Street { get; set; }
		
	    public string? FullAddress 
		{ 
			get 
			{ 
				return $"{PostIndex}, {City}, {Street}"; 
			} 
		}
	}
}
