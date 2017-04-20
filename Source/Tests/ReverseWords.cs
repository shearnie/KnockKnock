using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ReverseWords
    {
        private KnockKnock.Controllers.ReverseWordsController rw = new KnockKnock.Controllers.ReverseWordsController();

        /*
            2017-04-20T01:02:33,Information,knockknockshearnie,54a507,636282469530921674,0,6164,7,ReverseWords: sentence=,00000000-0000-0000-bd48-0080000000d0
            2017-04-20T01:02:33,Information,knockknockshearnie,54a507,636282469533450008,0,6164,7,ReverseWords: sentence=cat,00000000-0000-0000-b246-0080000000d8
            2017-04-20T01:02:33,Information,knockknockshearnie,54a507,636282469534699555,0,6164,20,ReverseWords: sentence=cat and dog,00000000-0000-0000-be48-0080000000d0
            2017-04-20T01:02:33,Information,knockknockshearnie,54a507,636282469535949157,0,6164,20,ReverseWords: sentence=two  spaces,00000000-0000-0000-b346-0080000000d8
            2017-04-20T01:02:33,Information,knockknockshearnie,54a507,636282469537491486,0,6164,7,ReverseWords: sentence= leading space,00000000-0000-0000-bf48-0080000000d0
            2017-04-20T01:02:33,Information,knockknockshearnie,54a507,636282469538741253,0,6164,20,ReverseWords: sentence=trailing space ,00000000-0000-0000-b446-0080000000d8
            2017-04-20T01:02:34,Information,knockknockshearnie,54a507,636282469540303392,0,6164,20,ReverseWords: sentence=Capital,00000000-0000-0000-c048-0080000000d0
            2017-04-20T01:02:34,Information,knockknockshearnie,54a507,636282469541553050,0,6164,7,ReverseWords: sentence=Bang!,00000000-0000-0000-b546-0080000000d8
            2017-04-20T01:02:34,Information,knockknockshearnie,54a507,636282469542834001,0,6164,20,ReverseWords: sentence=¿Qué?,00000000-0000-0000-c148-0080000000d0
            2017-04-20T01:02:34,Information,knockknockshearnie,54a507,636282469544093743,0,6164,7,ReverseWords: sentence=detartrated kayak detartrated,00000000-0000-0000-b646-0080000000d8
            2017-04-20T01:02:34,Information,knockknockshearnie,54a507,636282469545343289,0,6164,20,ReverseWords: sentence=This is a snark: ⸮,00000000-0000-0000-c248-0080000000d0
            2017-04-20T01:02:34,Information,knockknockshearnie,54a507,636282469546608585,0,6164,7,ReverseWords: sentence=  S  P  A  C  E  Y  ,00000000-0000-0000-b746-0080000000d8
            2017-04-20T01:02:34,Information,knockknockshearnie,54a507,636282469547858216,0,6164,20,ReverseWords: sentence=!B!A!N!G!S!,00000000-0000-0000-c348-0080000000d0
            2017-04-20T01:02:34,Information,knockknockshearnie,54a507,636282469549123458,0,6164,7,ReverseWords: sentence=P!u@n#c$t%u^a&t*i(o)n,00000000-0000-0000-b846-0080000000d8
         */

        [TestMethod]
        public void All()
        {
            Assert.AreEqual("", rw.Get(""));
            Assert.AreEqual("tac", rw.Get("cat"));
            Assert.AreEqual("tac dna god", rw.Get("cat and dog"));
            Assert.AreEqual("owt  secaps", rw.Get("two  spaces"));
            Assert.AreEqual(" gnidael ecaps", rw.Get(" leading space"));
            Assert.AreEqual("gniliart ecaps ", rw.Get("trailing space "));
            Assert.AreEqual("?éuQ¿", rw.Get("¿Qué?"));
            Assert.AreEqual("  S  P  A  C  E  Y  ", rw.Get("  S  P  A  C  E  Y  "));
            Assert.AreEqual("!S!G!N!A!B!", rw.Get("!B!A!N!G!S!"));
            Assert.AreEqual("n@u!P", rw.Get("P!u@n"));
        }
    }
}
