namespace TestTC
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Assert.AreEqual(666, 666);
        }
        [Test] 
        public void Test2() 
        {
            Assert.AreNotEqual(2 * 2, 666);
        }
        [Test]
        public void Test3()
        {
            Assert.IsTrue(true);
        }
    }
}