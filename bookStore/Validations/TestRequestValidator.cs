using BookStore.Models.Models.Users;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace bookStore.Validations
{
    public  class TestRequestValidator 
        : AbstractValidator<Library>
    {
        public TestRequestValidator() 
        {
            RuleFor(x => x.Id).NotNull().GreaterThanOrEqualTo(1);

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(50);
        }
    }
}
