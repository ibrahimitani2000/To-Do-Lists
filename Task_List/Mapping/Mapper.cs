using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_List.ViewModel;

namespace Task_List.Mapping
{
    public class Mapper : Profile
    {
        public Mapper()
        {

            CreateMap<Models.Task, AlterTaskViewModel>().ReverseMap();
        }

    }
}
