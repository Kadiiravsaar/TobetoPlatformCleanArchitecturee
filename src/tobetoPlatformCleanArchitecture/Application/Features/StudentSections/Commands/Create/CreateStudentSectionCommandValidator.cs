using FluentValidation;

namespace Application.Features.StudentSections.Commands.Create;

public class CreateStudentSectionCommandValidator : AbstractValidator<CreateStudentSectionCommand>
{
    public CreateStudentSectionCommandValidator()
    {
        RuleFor(c => c.SectionId).NotEmpty();
        RuleFor(c => c.StudentId).NotEmpty();
      
    }
}