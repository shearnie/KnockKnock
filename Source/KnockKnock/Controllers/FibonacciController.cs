using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnock.Controllers
{
    public class FibonacciController : System.Web.Http.ApiController
    {
        public long Get(int n)
        {
            System.Diagnostics.Trace.TraceInformation("Fibonacci: n=" + n);

            var coef = n > 0 ? 1 : -1;

            long f = 0;
            long s = 1;
            long p = f + s;

            if (Math.Abs(n) == 0) return f;
            if (Math.Abs(n) == 1) return s;
            if (Math.Abs(n) == 2) return p;

            for(var i = 0; i < Math.Abs(n) - 2; i++)
            {
                f = s;
                s = p;
                p = f + s;
            }

            return p * coef;
        }     
    }
}
