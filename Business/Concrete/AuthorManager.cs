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

        public Author GetById(int authorId)
        {
            return _authorDal.Get(p => p.AuthorId == authorId);

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
