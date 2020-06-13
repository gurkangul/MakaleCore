using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
   public class Article:IEntity
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }

        public DateTime CreateDate { get; set; }=DateTime.Now;
    }
}
