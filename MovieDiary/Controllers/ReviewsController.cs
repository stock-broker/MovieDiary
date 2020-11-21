using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MovieDiary.Data;
using MovieDiary.Dtos;
using MovieDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDiary.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewRepo _repository;
        private readonly IMapper _mapper;
        public ReviewsController(IReviewRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [EnableCors("CorsPolicy")]
        [HttpGet]
        public ActionResult<IEnumerable<ReviewReadDto>> GetAllReviews()
        {
            var reviewItems = _repository.GetAllReviews();

            return Ok(_mapper.Map<IEnumerable<ReviewReadDto>>(reviewItems));
        }
        [EnableCors("CorsPolicy")]
        [HttpGet("{id}", Name ="GetReviewById")]
        public ActionResult<ReviewReadDto> GetReviewById(int id)
        {
            var reviewItem = _repository.GetReviewById(id);
            if (reviewItem == null) return NotFound();

            return Ok(_mapper.Map<ReviewReadDto>(reviewItem));
        }
        [EnableCors("CorsPolicy")]
        [HttpPost]
        public ActionResult<ReviewReadDto> CreateReview(ReviewCreateDto reviewCreateDto)
        {
            var reviewModel = _mapper.Map<ReviewModel>(reviewCreateDto);
            _repository.CreateReview(reviewModel);
            _repository.SaveChanges();

            var reviewReadDto = _mapper.Map<ReviewReadDto>(reviewModel);

            return CreatedAtRoute(nameof(GetReviewById), new { Id = reviewReadDto.Id }, reviewReadDto);
        }


    }
}
