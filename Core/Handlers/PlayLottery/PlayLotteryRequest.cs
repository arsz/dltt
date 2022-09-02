using AutoMapper;
using Core.Interfaces;
using MediatR;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Handlers.PlayLottery
{
    internal class PlayLotteryRequest : IRequestHandler<PlayLotteryParameter, DrawHistoryDto>
    {
        private readonly IRepository<Entities.DrawHistory> repository;
        private readonly IMapper mapper;

        public PlayLotteryRequest(IRepository<Entities.DrawHistory> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<DrawHistoryDto> Handle(PlayLotteryParameter request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<Entities.DrawHistory>(request.NewDraw);

            if (entity.Id != default)
            {
                throw new InvalidOperationException("Cannot add entity which already has Id {entity.Id}.");
            }

            var result = await repository.AddAsync(entity);

            return mapper.Map<DrawHistoryDto>(result);
        }
    }
}
