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
            return Fibonaci.Nth((long) n);            
        }
    }
}
