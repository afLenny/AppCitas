using AppCitas.DTOs;
using AppCitas.Entities;
using AutoMapper;

namespace AppCitas.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>();
            CreateMap<Photo, PhotoDto>();
        }
    }
}
