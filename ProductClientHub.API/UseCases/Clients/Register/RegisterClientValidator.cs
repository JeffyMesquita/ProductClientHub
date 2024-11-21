using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientValidator : AbstractValidator<RequestClientJson>
{
  public RegisterClientValidator() {
    RuleFor(client => client.Name)
        .NotEmpty()
        .WithMessage("O nome não pode ser vazio");
    RuleFor(client => client.Email)
        .NotEmpty()
        .WithMessage("Email não pode ser vazio")
        .EmailAddress()
        .WithMessage("On Email não é válido");
  }
}

