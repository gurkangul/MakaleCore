using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.RepositoryBase;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Models;

namespace DataAccess.Concrete
{
  public class SectionDal : EntityRepositoryBase<Section, ArticleContext>, ISectionDal
    {
    }
}
