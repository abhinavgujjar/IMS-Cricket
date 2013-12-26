using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Howzzzat.Tests
{
    class FakeResponse : HttpResponseBase
    {
        public override void Write(string s)
        {
            // ...
        }
    }
}
