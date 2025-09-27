using System;

namespace StudentDiary.Services.DTOs;

public record DiaryEntryResponse(int Id, int UserId, string Title, string Content, DateTime CreatedAt, DateTime? UpdatedAt);
public record CreateDiaryEntryRequest(int UserId, string Title, string Content);
public record UpdateDiaryEntryRequest(int Id, string? Title, string? Content);
