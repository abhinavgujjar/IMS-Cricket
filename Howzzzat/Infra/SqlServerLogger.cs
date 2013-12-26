using System;

namespace Howzzzat.Controllers
{
    public class SqlServerLogger : ILogger
    {
        public void Log(string message)
        {
            // write message to database here ....
        }
    }
}
