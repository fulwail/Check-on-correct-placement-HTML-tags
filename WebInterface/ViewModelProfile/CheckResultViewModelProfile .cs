using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataService.Model;
using WebInterface.ViewModels;
namespace WebInterface.ViewModelProfile
{
    public class CheckResultViewModelProfile: Profile
    {
        public CheckResultViewModelProfile()
        {
            CreateMap<ResultOfCheckingDto, ResultOfCheckingViewModel>()
                .ForMember(x => x.Id, c => c.MapFrom(m => m.Id))
                .ForMember(x => x.DateTime, opt => opt.MapFrom(src => src.DateTime.ToShortDateString()))
                .ForMember(x => x.Result, c => c.MapFrom(m => m.Result))
                .ForMember(x => x.CountToken, c => c.MapFrom(m => m.CountToken));
        }
    }
}