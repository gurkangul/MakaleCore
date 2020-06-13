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
            if (result.Count >= 0)
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
                foreach (var item in article.Section)
                {
                    var newSec = new Section
                    {
                        ArticleId = lastArticle.ArticleId,
                        Title = item.Title,
                        Description = item.Description
                    };
                    _sectionService.Add(newSec);
                }

                foreach (var item in article.Author)
                {
                    var newAuthor = new Author
                    {
                        ArticleId = lastArticle.ArticleId,
                        FirstName = item.FirstName,
                        LastName = item.LastName
                    };
                    _authorService.Add(newAuthor);
                }

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult Delete(int articleId)
        {

            try
            {
                var article = _articleService.GetById(articleId);
                var findSection = _sectionService.GetByArticleId(article.ArticleId);
                foreach (var item in findSection)
                {
                    _sectionService.Delete(item);

                }
                var findAuthor = _authorService.GetByArticleId(article.ArticleId);

                foreach (var item in findAuthor)
                {
                    _authorService.Delete(item);

                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            return Ok();
        }
    }
}
