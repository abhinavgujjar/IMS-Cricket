using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Howzzzat.Tests
{
    class FakeHttpContext : HttpContextBase
    {
        public override HttpResponseBase Response
        {
            get
            {
                return _fakeResponse;
            }
        }

        HttpResponseBase _fakeResponse = new FakeResponse();
    }
}
