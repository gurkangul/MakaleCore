﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Business.Abstract
{
   public interface ISectionService
    {
        List<Section> GetByArticleId(int sectionId);
        List<Section> GetList();
        void Add(Section section);
        void Delete(Section section);
        void Update(Section section);
    }
}
