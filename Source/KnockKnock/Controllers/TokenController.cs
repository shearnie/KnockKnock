using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnock.Controllers
{
    public class TokenController : System.Web.Http.ApiController
    {
        public string Get()
        {
            System.Diagnostics.Trace.TraceInformation("Token");

            return "Here is a token";
        }
    }
}
