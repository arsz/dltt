using MediatR;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Handlers.PlayLottery
{
    public class PlayLotteryParameter : IRequest<DrawHistoryDto>
    {

        public DrawHistoryDto NewDraw { get; set; }
    }
}
