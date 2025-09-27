using System;
using System.Collections.Generic;

namespace StudentDiary.Infrastructure.Entities;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;

    // Authentication fields
    public string PasswordHash { get; set; } = string.Empty;
    public string PasswordSalt { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Navigation
    public ICollection<DiaryEntry> DiaryEntries { get; set; } = new List<DiaryEntry>();
}
