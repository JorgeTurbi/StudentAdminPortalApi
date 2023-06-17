using AutoMapper;
using StudentAdminPortal.Api.DataModels;
using DomainModels = StudentAdminPortal.Api.DomainModels;
namespace StudentAdminPortal.Api.Profiles
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, DomainModels.Student>().ReverseMap();
            CreateMap<Gender, DomainModels.Gender>().ReverseMap();
            CreateMap<Address, DomainModels.Address>().ReverseMap();
        }
    }
}
