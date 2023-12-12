﻿using API.Entities;
using AutoMapper;

namespace API.Helpers;

public class AutoMapperProfiles : Profile
{
  public AutoMapperProfiles()
  {
    CreateMap<AppUser, MemberDto>()
    .ForMember(dest => dest.PhotoUrl, opt=> opt.MapFrom(source => source.Photos.FirstOrDefault(x => x.IsMain).Url))
    .ForMember(dest => dest.Age, opt=> opt.MapFrom(source => source.DateOfBirth.CalculateAge()));
    
    CreateMap<Photo, PhotoDto>();
  }
}
