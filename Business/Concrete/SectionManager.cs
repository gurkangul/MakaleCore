using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace Business.Concrete
{
    public class SectionManager : ISectionService
    {
        private ISectionDal _sectionDal;

        public SectionManager(ISectionDal sectionDal)
        {
            _sectionDal = sectionDal;
        }

        public void Add(Section section)
        {
           _sectionDal.Add(section);
        }

        public void Delete(Section section)
        {
            _sectionDal.Delete(section);
        }

        public List<Section> GetByArticleId(int articleId)
        {
            return _sectionDal.GetList(v => v.ArticleId == articleId).ToList();


        }

        public List<Section> GetList()
        {
            return _sectionDal.GetList().ToList();

        }

        public void Update(Section section)
        {
            _sectionDal.Update(section);
        }
    }
}
