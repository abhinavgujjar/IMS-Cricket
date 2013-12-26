using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Howzzzat.Models
{
    public class LiveScoreWrapper
    {
        public LiveScoreWrapper()
        {
            Messages = new List<string>();
            Scores = new List<LiveScore>();
        }
        public List<String> Messages { get; set; }
        public List<LiveScore> Scores{ get; set; }
    }
}