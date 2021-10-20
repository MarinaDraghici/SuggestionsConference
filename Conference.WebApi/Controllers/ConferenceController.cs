using Microsoft.AspNetCore.Mvc;
using Conference.Application.Queries;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Conference.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConferenceController : ControllerBase
    {
        private readonly MediatR.IMediator _mediator;

        public ConferenceController(MediatR.IMediator mediator)
        {
            _mediator = mediator;
        }

        /*   [HttpPost]
           [Route("Create")]
           public async Task<string> CreateAccount(MakeNewAccount command, CancellationToken cancellationToken)
           {
               await _mediator.Send(command, cancellationToken);
               return "OK";
           }*/

        [HttpGet]
        [Route("ListOfConferences")]
        // query: http://localhost:5000/api/Account/ListOfAccounts?PersonId=1&Cnp=1961231..
        // route: http://localhost:5000/api/Account/ListOfAccounts/1/1961231..
        public async Task<List<GetConferences.Model>> GetListOfConferences(CancellationToken cancellationToken)
        {
            var query = new GetConferences.Query();
            var result = await _mediator.Send(query, cancellationToken);
            return result;
        }
    }
}
