using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Entities.ViewModels
{
   public class ArticleViewModel
    {
        public Article Article { get; set; }
        public Section Section { get; set; }
        public Author Author { get; set; }
    }
}
