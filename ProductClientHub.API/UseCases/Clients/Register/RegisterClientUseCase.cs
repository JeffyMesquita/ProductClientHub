using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProductClientHub.API.UseCases.Clients.Register;

public class RegisterClientUseCase
{
  public ResponseClientJson Execute(RequestClientJson request) {
    // Register client
    var validator = new RegisterClientValidator();

    var result = validator.Validate(request);

    if (result.IsValid == false) {
      var errors = result.Errors.Select(elementFailure => elementFailure.ErrorMessage).ToList();

      throw new ErrorOnValidationException(errors);
    } 

    return new ResponseClientJson();
  }
}


