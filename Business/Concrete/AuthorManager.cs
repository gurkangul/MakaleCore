using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public void Add(Author author)
        {
           _authorDal.Add(author);
        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }

        public List<Author> GetByArticleId(int articleId)
        {
            return _authorDal.GetList(v=>v.ArticleId==articleId).ToList();

        }

        public List<Author> GetList()
        {
            return _authorDal.GetList().ToList();

        }

        public void Update(Author author)
        {
           _authorDal.Update(author);
        }
    }
}
