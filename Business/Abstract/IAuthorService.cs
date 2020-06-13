using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Business.Abstract
{
   public interface IAuthorService
    {
        Author GetById(int authorId);
        List<Author> GetList();
        void Add(Author author);
        void Delete(Author author);
        void Update(Author author);
    }
}
