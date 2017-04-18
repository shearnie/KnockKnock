using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnock.Controllers
{
    public class TriangleTypeController : System.Web.Http.ApiController
    {
        public string Get(int a, int b, int c)
        {
            if (((b + c) < a) || ((a + c) < b) || ((a + b) < c))
                return "Error";

            if (a == b && b == c)
                return "Equilateral";

            if ((a == b && b != c)
                ||
                (a == c && c != b)
                ||
                (b == c && c != a))
                return "Isosceles";

            if (a != b && b != c)
                return "Scalene";

            return "Error";
        }
    }
}
