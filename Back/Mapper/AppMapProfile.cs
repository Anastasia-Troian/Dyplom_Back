using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back.Data.Entities.Identity;
using Back.Models;

namespace Back.Mapper
{
    public class AppMapProfile : Profile
    {
        public AppMapProfile()
        {
            CreateMap<AppUser, UserItemViewModel>()
                .ForMember(x => x.Image, opt => opt.MapFrom(x => "images/" 
                    + (string.IsNullOrEmpty(x.Photo) ? "noimage.jpg" : x.Photo)));

            CreateMap<RegisterViewModel, AppUser>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(x =>x.Email));
        }
    }
}
