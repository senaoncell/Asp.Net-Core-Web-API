﻿using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;
using System.Runtime.InteropServices;

namespace WebApi.Utitlities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDtoForUpdate, Book>().ReverseMap();
            CreateMap<BookDtoForInsertion, Book>();
            CreateMap<Book, BookDto>();
            CreateMap<UserForRegistrationDto, User>();  
        }
    }
}
