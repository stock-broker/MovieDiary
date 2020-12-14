using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieDiary.Authentication;
using MovieDiary.Data;
using MovieDiary.Dtos;
using MovieDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDiary.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewRepo _repository;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        public ReviewsController(IReviewRepo repository, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _mapper = mapper;
            _userManager = userManager;

        }
        [EnableCors("CorsPolicy")]
        [HttpGet]
        public  ActionResult<IEnumerable<ReviewReadDto>> GetAllReviews()
        {
            var reviewItems = _repository.GetAllReviews();
            var user = _userManager.GetUserAsync(User);
                    
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
