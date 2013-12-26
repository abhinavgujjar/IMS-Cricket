using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;

namespace Howzzzat.Tests
{
    class FakeRequestContext : RequestContext
    {
        public FakeRequestContext()
            : base(new FakeHttpContext(), new RouteData())
        {

        }
    }
}
