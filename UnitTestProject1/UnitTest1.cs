using Lab_5_zavd_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = "IT-Tasks      Berlin    27.04.2012    New_technologies     200";
            string str2 = "Army      Kyiv    12.10.2018  Protection     130"; 
            Meeting[] m = new Meeting[2];
            m[0] = new Meeting(str);
            m[1] = new Meeting(str2);
            var testMeeting = new Meeting();
            int result = testMeeting.MaxParticipants(m);
            Assert.AreEqual(result, 200);
        }
    }
}
