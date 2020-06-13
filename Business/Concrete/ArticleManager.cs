using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void Add(Article article)
        {
            _articleDal.Add(article);

        }

        public void Delete(Article article)
        {
            _articleDal.Delete(article);
        }

        public Article GetById(int articleId)
        {
            return  _articleDal.Get(p => p.ArticleId == articleId);

        }

        public List<Article> GetList()
        {
            return _articleDal.GetList().ToList();

        }

        public void Update(Article article)
        {
            _articleDal.Update(article);

        }
    }
}
