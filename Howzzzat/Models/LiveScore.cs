using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Howzzzat.Models
{
    public class LiveScore
    {
        public LiveScore()
        {
            ThreadInfo = new List<string>();
        }
        public string MatchName { get; set; }
        public string CurrentScore { get; set; }
        public string ExternalData { get; set; }
        public List<String> ThreadInfo { get; set; }
    }
}