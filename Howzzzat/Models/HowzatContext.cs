using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Howzzzat.Models
{
    public class HowzatContext : DbContext
    {
        public DbSet<Article> Articles{ get; set; }
    }
}