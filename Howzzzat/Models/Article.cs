using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Howzzzat.Models
{
    public class Article
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public DateTime DatePublished { get; set; }
        public ArticleStats Stat { get; set; }
    }
}