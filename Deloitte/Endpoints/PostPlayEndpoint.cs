using Ardalis.ApiEndpoints;
using Core.Handlers.PlayLottery;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace Deloitte.Endpoints
{


    [Route("/play")]
    public class PostPlayEndpoint : EndpointBaseAsync
     .WithRequest<DrawHistoryDto>
     .WithActionResult<DrawHistoryDto>
    {

        private readonly IMediator mediator;

        public PostPlayEndpoint(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("draw-lottary")]
        public async override Task<ActionResult<DrawHistoryDto>> HandleAsync(DrawHistoryDto request, CancellationToken cancellationToken = default)
        {
            var result = await mediator.Send(new PlayLotteryParameter { NewDraw = request }).ConfigureAwait(false);

            return Ok(result);
        }
    }
}
