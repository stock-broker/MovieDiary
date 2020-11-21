using AutoMapper;
using MovieDiary.Dtos;
using MovieDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDiary.Profiles
{
    public class ReviewsProfile : Profile
    {
        public ReviewsProfile()
        {
            //Source -> Target
            CreateMap<ReviewModel, ReviewReadDto>();
            CreateMap<ReviewCreateDto, ReviewModel>();
        }
    }
}
