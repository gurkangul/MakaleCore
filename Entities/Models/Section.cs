using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
   public class Section:IEntity
    {

        public int SectionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ArticleId { get; set; }
    }
}
