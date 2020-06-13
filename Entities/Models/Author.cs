using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
  public class Author:IEntity
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ArticleId { get; set; }
    }
}
