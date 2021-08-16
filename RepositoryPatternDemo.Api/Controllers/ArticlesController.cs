using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.Core.Interfaces;
using RepositoryPatternDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        protected IBaseRepository<Article> _articleRepository;

        public ArticlesController(IBaseRepository<Article> articleRepository)
        {
            _articleRepository = articleRepository;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_articleRepository.GetById(1));
        }


        [HttpGet ("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_articleRepository.Find(a=>a.Title == "Why Facts Dont Change Our Minds"));
        }
    }
}
