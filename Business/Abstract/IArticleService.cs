using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IArticleService
    {
        Article GetById(int articleId);
        List<Article> GetList();
        Article GetLastArticle();

        void Add(Article article);
        void Delete(Article article);
        void Update(Article article);
    }
}
