using FluentValidation;

namespace DockerApp
{
    public class SearchRequestValidator : AbstractValidator<SearchModel>
    {
        public SearchRequestValidator()
        {
            RuleFor(x => x.Keyword).NotEmpty().NotNull();
            RuleFor(x => x.Url).NotEmpty().NotNull();
        }
    }
}
