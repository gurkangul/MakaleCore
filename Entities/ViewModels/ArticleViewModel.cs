using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Entities.ViewModels
{
   public class ArticleViewModel
    {
        public Article Article { get; set; }
        public List<Section> Section { get; set; }
        public List<Author> Author { get; set; }
    }
}
