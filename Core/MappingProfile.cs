using AutoMapper;
using Core.Entities;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<DrawHistory, DrawHistoryDto>().ReverseMap();
        }
    }
}
