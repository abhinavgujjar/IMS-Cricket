using Howzzzat.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howzzzat.Tests
{
    class FakeLogger : ILogger
    {
        public void Log(string message)
        {
            LogResult = message;
        }

        public string LogResult { get; set; }
    }
}
