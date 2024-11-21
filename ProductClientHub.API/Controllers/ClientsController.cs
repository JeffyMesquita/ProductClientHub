using Microsoft.AspNetCore.Mvc;
using ProductClientHub.API.UseCases.Clients.Register;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProductClientHub.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ClientsController : ControllerBase
{
  [HttpPost]
  [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)]
  [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
  [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status500InternalServerError)]
  public IActionResult Register([FromBody]RequestClientJson request) {   
    var useCase = new RegisterClientUseCase();

    var response = useCase.Execute(request);

    return Created(string.Empty, response);
  }

  [HttpPut]
  public IActionResult Update() {
    return Ok("Update");
  }

  [HttpGet]
  public IActionResult GetAll() {
    return Ok("Get");
  }

  [HttpGet]
  [Route("{id}")]
  public IActionResult GetById([FromRoute]Guid id) {
    return Ok("Get");
  }

  [HttpDelete]
  public IActionResult Delete() {
    return Ok("Delete");
  }
}


