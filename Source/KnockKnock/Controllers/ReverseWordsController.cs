using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace KnockKnock.Controllers
{
    public class ReverseWordsController : System.Web.Http.ApiController
    {
        public string Get(string sentence)
        {
            System.Diagnostics.Trace.TraceInformation("ReverseWords: sentence=" + sentence);

            var ret = new List<string>();
            foreach(var word in sentence.Split(" ".ToCharArray()).ToList())
            {
                ret.Add(new string(word.Reverse().ToArray()));                
            }

            return string.Join(" ", ret);
        }
    }
}
