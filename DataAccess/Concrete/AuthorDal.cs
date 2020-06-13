using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.RepositoryBase;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Models;

namespace DataAccess.Concrete
{
  public class AuthorDal : EntityRepositoryBase<Author, ArticleContext>, IAuthorDal
    {
    }
}
