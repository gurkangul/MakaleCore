using Autofac;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Module = Autofac.Module;

namespace Business.Dependency.Autofac
{
   public class AutofacModule: Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArticleManager>().As<IArticleService>();
            builder.RegisterType<ArticleDal>().As<IArticleDal>();

            builder.RegisterType<AuthorManager>().As<IAuthorService>();
            builder.RegisterType<AuthorDal>().As<IAuthorDal>();

            builder.RegisterType<SectionManager>().As<ISectionService>();
            builder.RegisterType<SectionDal>().As<ISectionDal>();


        }
    }
}
