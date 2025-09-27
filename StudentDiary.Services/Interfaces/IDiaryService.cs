using System.Collections.Generic;
using System.Threading.Tasks;
using StudentDiary.Services.DTOs;

namespace StudentDiary.Services.Interfaces;

public interface IDiaryService
{
    Task<DiaryEntryResponse> CreateAsync(CreateDiaryEntryRequest request);
    Task<DiaryEntryResponse?> GetByIdAsync(int id);
    Task<IReadOnlyList<DiaryEntryResponse>> GetByUserAsync(int userId);
    Task<DiaryEntryResponse?> UpdateAsync(UpdateDiaryEntryRequest request);
    Task<bool> DeleteAsync(int id);
}
