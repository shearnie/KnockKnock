using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Fibonacci
    {
        private KnockKnock.Controllers.FibonacciController fib = new KnockKnock.Controllers.FibonacciController();

        /*
            2017-04-20T01:01:58,Information,knockknockshearnie,54a507,636282469186339509,0,6164,7,Fibonacci: n=-92,00000000-0000-0000-9846-0080000000d8
            2017-04-20T01:01:58,Information,knockknockshearnie,54a507,636282469187750754,0,6164,7,Fibonacci: n=-47,00000000-0000-0000-9946-0080000000d8
            2017-04-20T01:01:58,Information,knockknockshearnie,54a507,636282469189000383,0,6164,20,Fibonacci: n=-46,00000000-0000-0000-9a46-0080000000d8
            2017-04-20T01:01:59,Information,knockknockshearnie,54a507,636282469190265484,0,6164,7,Fibonacci: n=-7,00000000-0000-0000-9b46-0080000000d8
            2017-04-20T01:01:59,Information,knockknockshearnie,54a507,636282469191524996,0,6164,20,Fibonacci: n=-6,00000000-0000-0000-9c46-0080000000d8
            2017-04-20T01:01:59,Information,knockknockshearnie,54a507,636282469192764585,0,6164,7,Fibonacci: n=-5,00000000-0000-0000-9d46-0080000000d8
            2017-04-20T01:01:59,Information,knockknockshearnie,54a507,636282469194014242,0,6164,7,Fibonacci: n=-4,00000000-0000-0000-9e46-0080000000d8
            2017-04-20T01:01:59,Information,knockknockshearnie,54a507,636282469195263929,0,6164,20,Fibonacci: n=-3,00000000-0000-0000-9f46-0080000000d8
            2017-04-20T01:01:59,Information,knockknockshearnie,54a507,636282469196513450,0,6164,7,Fibonacci: n=-2,00000000-0000-0000-a046-0080000000d8
            2017-04-20T01:01:59,Information,knockknockshearnie,54a507,636282469197870049,0,6164,20,Fibonacci: n=-1,00000000-0000-0000-a146-0080000000d8
            2017-04-20T01:01:59,Information,knockknockshearnie,54a507,636282469198969022,0,6164,7,Fibonacci: n=0,00000000-0000-0000-a246-0080000000d8
            2017-04-20T01:02:00,Information,knockknockshearnie,54a507,636282469200374679,0,6164,20,Fibonacci: n=1,00000000-0000-0000-a346-0080000000d8
            2017-04-20T01:02:00,Information,knockknockshearnie,54a507,636282469201936811,0,6164,20,Fibonacci: n=2,00000000-0000-0000-a446-0080000000d8
            2017-04-20T01:02:00,Information,knockknockshearnie,54a507,636282469203342608,0,6164,7,Fibonacci: n=3,00000000-0000-0000-a546-0080000000d8
            2017-04-20T01:02:00,Information,knockknockshearnie,54a507,636282469204592111,0,6164,7,Fibonacci: n=4,00000000-0000-0000-a646-0080000000d8
            2017-04-20T01:02:00,Information,knockknockshearnie,54a507,636282469206466598,0,6164,7,Fibonacci: n=5,00000000-0000-0000-a746-0080000000d8
            2017-04-20T01:02:00,Information,knockknockshearnie,54a507,636282469208664986,0,6164,7,Fibonacci: n=6,00000000-0000-0000-a846-0080000000d8
            2017-04-20T01:02:00,Information,knockknockshearnie,54a507,636282469209914612,0,6164,7,Fibonacci: n=7,00000000-0000-0000-a946-0080000000d8
            2017-04-20T01:02:01,Information,knockknockshearnie,54a507,636282469211164219,0,6164,7,Fibonacci: n=46,00000000-0000-0000-aa46-0080000000d8
            2017-04-20T01:02:01,Information,knockknockshearnie,54a507,636282469212439828,0,6164,7,Fibonacci: n=47,00000000-0000-0000-ab46-0080000000d8
            2017-04-20T01:02:01,Information,knockknockshearnie,54a507,636282469213689464,0,6164,7,Fibonacci: n=92,00000000-0000-0000-ac46-0080000000d8
            2017-04-20T01:02:01,Information,knockknockshearnie,54a507,636282469214939009,0,6164,7,Fibonacci: n=-93,00000000-0000-0000-ad46-0080000000d8
            2017-04-20T01:02:01,Information,knockknockshearnie,54a507,636282469217781705,0,6164,7,Fibonacci: n=93,00000000-0000-0000-ae46-0080000000d8
            2017-04-20T01:02:02,Information,knockknockshearnie,54a507,636282469223652745,0,6164,7,Fibonacci: n=-2147483648,00000000-0000-0000-b046-0080000000d8
            2017-04-20T01:02:17,Information,knockknockshearnie,54a507,636282469377067828,0,6164,20,Fibonacci: n=2147483647,00000000-0000-0000-bc48-0080000000d0
         */

        [TestMethod]
        public void All()
        {
            Assert.AreEqual(0, fib.Get(0));
            Assert.AreEqual(-7540113804746346429, fib.Get(-92));
            Assert.AreEqual(7540113804746346429, fib.Get(92));
        }
    }
}
