using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Fibonacci;

namespace KnockKnock.Controllers
{
    public class FibonacciController : System.Web.Http.ApiController
    {
        public long Get(int n)
        {
            long f = 0;
            long s = 1;
            long p = f + s;

            if (n == 0) return f;
            if (n == 1) return s;
            if (n == 2) return p;

            for(var i = 0; i < n - 2; i++)
            {
                f = s;
                s = p;
                p = f + s;
            }

            return p;
        }        
    }
}
