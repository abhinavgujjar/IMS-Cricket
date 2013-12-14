using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Howzzzat
{
    public class DataAccess
    {
        public string GetArticleContent(int id)
        {
            return "This is the content for article : " + id;
        }
    }
}