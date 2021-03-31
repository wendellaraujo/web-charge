using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Domain.Aggregates.PersonAggregate;

namespace Examples.Charge.Application.AutoMapper
{
    public class PhonePersonProfile : Profile
    {
        public PhonePersonProfile()
        {
            CreateMap<PersonPhone, PersonPhoneDto>()
               .ReverseMap()
               .ForMember(dest => dest.BusinessEntityID, opt => opt.MapFrom(src => src.BusinessEntityID))
               .ForMember(dest => dest.PhoneNumberTypeID, opt => opt.MapFrom(src => src.PhoneNumberTypeID))
               .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber));
        }
    }
}
