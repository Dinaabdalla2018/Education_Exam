using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quize.BAL.Services;
using Quize.DAL.Models;

namespace JwtWebApiTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionsService _questionService;

        public QuestionController(IQuestionsService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet, Authorize]
        public IActionResult Get()
        {
           return Ok(_questionService.GetAll());
        }

        [HttpGet("{id}"), Authorize]
        public IActionResult Get(int id)
        {
            var Question = _questionService.GetById(id);
            if (Question == null)
                return NotFound();

            return Ok(Question);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Post([FromBody]Questions question)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _questionService.Insert(question);
            return Ok(question);

        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public IActionResult Put([FromBody] Questions question)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var Exist = _questionService.GetByIdAsNoTracking(question.Id);
            if (Exist == null)
            {
                return NotFound("Book Not found");
            }

            _questionService.Update(question);
            return Ok(question);

        }

        [HttpDelete("{id}")]
        [Authorize(Roles ="Admin")]
        public IActionResult Delete(int id)
        {
            _questionService.Delete(id);
            return Ok(id);
        }
    }
}
