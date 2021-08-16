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
    public class AuthorsController : ControllerBase
    {
        private readonly IBaseRepository<Author> _authorsRepository;

        public AuthorsController(IBaseRepository<Author> authorsRepository)
        {
            _authorsRepository = authorsRepository;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_authorsRepository.GetById(1));
        }

        [HttpGet ("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            return Ok(await _authorsRepository.GetByIdAsync(1));
        }

        [HttpGet ("GetAllAuthors")]
        public IActionResult GetAll()
        {
           return Ok(  _authorsRepository.GetAll());
        }
    }
}
