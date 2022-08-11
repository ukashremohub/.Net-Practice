namespace DapperEx.Model;
public class EmployeeValidater : AbstractValidator<EmployeeModel>
{
    public EmployeeValidater()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull();
        RuleFor(x => x.Name).NotEmpty().NotNull();
        RuleFor(x => x.Role).NotEmpty().NotNull();
        RuleFor(x => x.Email).NotEmpty().NotNull().EmailAddress();
        RuleFor(x => x.Address).NotNull().MaximumLength(20)
            .Must(a => a.ToLower().Contains("number") == true)
            .WithMessage("Address should contain 'Number'");

    }
}
