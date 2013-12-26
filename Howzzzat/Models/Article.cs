using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Howzzzat.Models
{
    public class Article
    {
        public int id { get; set; }

        [Required]
        public string Title { get; set; }

        [AllowHtml]
        public string Content { get; set; }

        public string Author { get; set; }
        public int Rating { get; set; }
    }
}