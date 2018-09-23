using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DomainWebApp.DomainEvents;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopOnContainers.Services.Ordering.API.Application.Commands;

namespace DomainWebApp.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FlatController : ControllerBase
    {
        private readonly IMediator _mediator;
        

        public FlatController(IMediator mediator)
        {

            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
  
        }

        [Route("movein")]
        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> MoveIn([FromBody]MoveInCommand command, [FromQuery(Name = "flatNo")] string flatNo)
        {
            bool commandResult = false;
            if ( flatNo != string.Empty)
            {
                var moveInOrder = new IdentifiedCommand<MoveInCommand, bool>(command, flatNo);
                commandResult = await _mediator.Send(moveInOrder);
               
            }

            return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();

        }
    }
}