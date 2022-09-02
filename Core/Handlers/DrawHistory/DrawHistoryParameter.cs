using MediatR;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Handlers.DrawHistory
{
    public class DrawHistoryParameter : IRequest<IEnumerable<DrawHistoryDto>>
    {
    }
}
