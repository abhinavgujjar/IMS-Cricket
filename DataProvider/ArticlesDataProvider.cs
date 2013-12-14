using Howzzzat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class ArticlesDataProvider
    {
        public List<Article> GetAllArticles()
        {
            var articles = new List<Article>(){
                new Article{ 
                    Author = "Abhinav", 
                    Content = "Some contentsadfdsf fdsa asd asdljf dsaf <script>alert('BOOO!')</script>", 
                    Title = "the problem with T20", 
                    Rating = 6},
                new Article{ 
                    Author = "Kapil Dev", Content = "Some other content", Title = "Glorious win of '83", Rating = 9},
                new Article{ 
                    Author = "Harsha Bhogle", Content = "this content", Title = "Why I am losing hair!!", Rating = 2},
            };

            return articles;
        }
    }
}
