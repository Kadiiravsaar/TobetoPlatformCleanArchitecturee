using Core.Application.Responses;

namespace Application.Features.Exams.Commands.Update;

public class UpdatedExamResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Duration { get; set; }
    public int QuestionCount { get; set; }
    public string QuestionType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}