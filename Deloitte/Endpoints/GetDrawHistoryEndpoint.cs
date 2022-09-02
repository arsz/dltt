using Ardalis.ApiEndpoints;
using Core.Handlers.DrawHistory;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace Deloitte.Endpoints
{

    [Route("/history")]
    public class GetDrawHistoryEndpoint : EndpointBaseAsync
       .WithoutRequest
       .WithResult<IEnumerable<DrawHistoryDto>>
    {

        private readonly IMediator mediator;

        public GetDrawHistoryEndpoint(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("draw-by-date")]
        public async override Task<IEnumerable<DrawHistoryDto>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var result = await mediator.Send(new DrawHistoryParameter()).ConfigureAwait(false);

            return result;
        }
    }
}
