﻿namespace EFCoreBlazorMigrations.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public string? Role { get; set; } //новое свойство - роль пользователя в системе
        public DateTime? CreatedAt { get; set; }
    }
}
