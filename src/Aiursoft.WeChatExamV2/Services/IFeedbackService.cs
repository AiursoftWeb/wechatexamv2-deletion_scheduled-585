using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Services;

public interface IFeedbackService
{
    Task<Feedback> SubmitFeedbackAsync(string userId, string content, string? contact, FeedbackType type);
    Task<List<Feedback>> GetUserFeedbacksAsync(string userId);
    Task<(List<Feedback> items, int totalCount)> SearchFeedbacksAsync(int page, int pageSize, FeedbackStatus? status = null, FeedbackType? type = null);
    Task<Feedback?> GetFeedbackByIdAsync(int id);
    Task UpdateFeedbackStatusAsync(int id, FeedbackStatus status);
    Task DeleteFeedbackAsync(int id);
}
