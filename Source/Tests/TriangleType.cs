using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TriangleType
    {
        private KnockKnock.Controllers.TriangleTypeController tt = new KnockKnock.Controllers.TriangleTypeController();

        /*
            2017-04-20T01:01:55,Information,knockknockshearnie,54a507,636282469152579267,0,6164,18,TriangleType: a=-2147483648 b=-2147483648 c=-2147483648,00000000-0000-0000-7f46-0080000000d8
            2017-04-20T01:01:55,Information,knockknockshearnie,54a507,636282469153894897,0,6164,18,TriangleType: a=-1 b=-1 c=-1,00000000-0000-0000-8046-0080000000d8
            2017-04-20T01:01:55,Information,knockknockshearnie,54a507,636282469155144504,0,6164,7,TriangleType: a=-1 b=1 c=1,00000000-0000-0000-8146-0080000000d8
            2017-04-20T01:01:55,Information,knockknockshearnie,54a507,636282469156409553,0,6164,7,TriangleType: a=1 b=-1 c=1,00000000-0000-0000-8246-0080000000d8
            2017-04-20T01:01:55,Information,knockknockshearnie,54a507,636282469157659203,0,6164,7,TriangleType: a=1 b=1 c=-1,00000000-0000-0000-8346-0080000000d8
            2017-04-20T01:01:55,Information,knockknockshearnie,54a507,636282469159064857,0,6164,7,TriangleType: a=0 b=0 c=0,00000000-0000-0000-8446-0080000000d8
            2017-04-20T01:01:56,Information,knockknockshearnie,54a507,636282469160340511,0,6164,7,TriangleType: a=0 b=1 c=1,00000000-0000-0000-8546-0080000000d8
            2017-04-20T01:01:56,Information,knockknockshearnie,54a507,636282469161600376,0,6164,7,TriangleType: a=1 b=0 c=1,00000000-0000-0000-8646-0080000000d8
            2017-04-20T01:01:56,Information,knockknockshearnie,54a507,636282469163162410,0,6164,7,TriangleType: a=1 b=1 c=0,00000000-0000-0000-8746-0080000000d8
            2017-04-20T01:01:56,Information,knockknockshearnie,54a507,636282469164557458,0,6164,7,TriangleType: a=1 b=1 c=2,00000000-0000-0000-8846-0080000000d8
            2017-04-20T01:01:56,Information,knockknockshearnie,54a507,636282469165838226,0,6164,7,TriangleType: a=1 b=2 c=1,00000000-0000-0000-8946-0080000000d8
            2017-04-20T01:01:56,Information,knockknockshearnie,54a507,636282469168519751,0,6164,7,TriangleType: a=2 b=1 c=1,00000000-0000-0000-8a46-0080000000d8
            2017-04-20T01:01:56,Information,knockknockshearnie,54a507,636282469169774389,0,6164,7,TriangleType: a=1 b=2 c=3,00000000-0000-0000-8b46-0080000000d8
            2017-04-20T01:01:57,Information,knockknockshearnie,54a507,636282469171024085,0,6164,7,TriangleType: a=1 b=1 c=2147483647,00000000-0000-0000-8c46-0080000000d8
            2017-04-20T01:01:57,Information,knockknockshearnie,54a507,636282469172188246,0,6164,7,TriangleType: a=1 b=1 c=1,00000000-0000-0000-8d46-0080000000d8
            2017-04-20T01:01:57,Information,knockknockshearnie,54a507,636282469173594196,0,6164,7,TriangleType: a=2 b=2 c=2,00000000-0000-0000-8e46-0080000000d8
            2017-04-20T01:01:57,Information,knockknockshearnie,54a507,636282469174843872,0,6164,7,TriangleType: a=2147483647 b=2147483647 c=2147483647,00000000-0000-0000-8f46-0080000000d8
            2017-04-20T01:01:57,Information,knockknockshearnie,54a507,636282469176093409,0,6164,7,TriangleType: a=2 b=2 c=3,00000000-0000-0000-9046-0080000000d8
            2017-04-20T01:01:57,Information,knockknockshearnie,54a507,636282469177343013,0,6164,20,TriangleType: a=2 b=3 c=2,00000000-0000-0000-9146-0080000000d8
            2017-04-20T01:01:57,Information,knockknockshearnie,54a507,636282469178592598,0,6164,20,TriangleType: a=3 b=2 c=2,00000000-0000-0000-9246-0080000000d8
            2017-04-20T01:01:57,Information,knockknockshearnie,54a507,636282469179842201,0,6164,20,TriangleType: a=2 b=3 c=4,00000000-0000-0000-9346-0080000000d8
            2017-04-20T01:01:58,Information,knockknockshearnie,54a507,636282469181247936,0,6164,7,TriangleType: a=3 b=4 c=2,00000000-0000-0000-9446-0080000000d8
            2017-04-20T01:01:58,Information,knockknockshearnie,54a507,636282469182497617,0,6164,7,TriangleType: a=4 b=2 c=3,00000000-0000-0000-9546-0080000000d8
            2017-04-20T01:01:58,Information,knockknockshearnie,54a507,636282469183747179,0,6164,7,TriangleType: a=4 b=3 c=2,00000000-0000-0000-9646-0080000000d8
            2017-04-20T01:01:58,Information,knockknockshearnie,54a507,636282469184999015,0,6164,20,TriangleType: a=2147483647 b=2147483647 c=2147483647,00000000-0000-0000-9746-0080000000d8
         */

        [TestMethod]
        public void All()
        {
            Assert.AreEqual("Equilateral", tt.Get(1, 1, 1));
            Assert.AreEqual("Error", tt.Get(-1, 1, 1));
            Assert.AreEqual("Error", tt.Get(1, -1, 1));
            Assert.AreEqual("Error", tt.Get(-1, 1, -1));
            Assert.AreEqual("Error", tt.Get(0, 0, 0));
            Assert.AreEqual("Error", tt.Get(0, 1, 0));
            Assert.AreEqual("Error", tt.Get(0, 1, 1));
            Assert.AreEqual("Error", tt.Get(1, 1, 2147483647));
            Assert.AreEqual("Scalene", tt.Get(4, 3, 2));
            Assert.AreEqual("Equilateral", tt.Get(2147483647, 2147483647, 2147483647));
        }
    }
}
