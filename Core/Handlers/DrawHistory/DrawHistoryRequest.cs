using AutoMapper;
using Core.Interfaces;
using MediatR;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Handlers.DrawHistory
{
    internal class DrawHistoryRequest : IRequestHandler<DrawHistoryParameter, IEnumerable<DrawHistoryDto>>
    {
        private readonly IRepository<Entities.DrawHistory> repository;
        private readonly IMapper mapper;

        public DrawHistoryRequest(IRepository<Entities.DrawHistory> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<DrawHistoryDto>> Handle(DrawHistoryParameter request, CancellationToken cancellationToken)
        {
            var historyEntities = await repository.ListAsync();

            return historyEntities.Select(x => mapper.Map<DrawHistoryDto>(x));
        }
    }
}
