using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Models;
using Entities.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private IArticleService _articleService;
        private IAuthorService _authorService;
        private ISectionService _sectionService;


        public ArticlesController(IArticleService articleService, IAuthorService authorService, ISectionService sectionService)
        {
            _articleService = articleService;
            _authorService = authorService;
            _sectionService = sectionService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _articleService.GetList();
            if (result.Count>=0)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(ArticleViewModel article)
        {

            try
            {
               _articleService.Add(article.Article);
               var lastArticle = _articleService.GetLastArticle();
               var newSec = new Section
               {
                   ArticleId = lastArticle.ArticleId,
                   Title = article.Section.Title,
                   Description = article.Section.Description
               };
                _sectionService.Add(newSec);
                var newAuthor = new Author
                {
                    ArticleId = lastArticle.ArticleId,
                    FirstName = article.Author.FirstName,
                    LastName = article.Author.LastName
                };
                _authorService.Add(newAuthor);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok();
        }
    }
}
