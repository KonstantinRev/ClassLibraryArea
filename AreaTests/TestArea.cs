using AreaLibraries;

namespace AreaTests
{
    [TestClass]
    public class TestCircleArea
    {
        [TestMethod]
        public void TestCircleArea1()
        {
            double radius = 1;
            double result = AreaLibrary.CircleAreaRadius(radius);
            double must_be = 3.1416;
            Assert.AreEqual(must_be, result);
        }
        [TestMethod]
        public void TestCircleArea25()
        {
            double radius = 25;
            double result = AreaLibrary.CircleAreaRadius(radius);
            double must_be = 1963.4954;
            Assert.AreEqual(must_be, result);
        }
    }
    [TestClass]
    public class TestTriangleArea
    {
        [TestMethod]
        public void TestTriangleArea1()
        {
            double part1 = 12;
            double part2 = 13;
            double part3 = 14;
            double result = AreaLibrary.TriangleArea(part1, part2, part3);
            double must_be = 72.3079;
            Assert.AreEqual(must_be, result);
        }
        [TestMethod]
        public void TestTriangleAreaEqual1()
        {
            double part1 = 12;
            double part2 = 13;
            double part3 = 14;
            bool result = AreaLibrary.IsTriangle90(part1, part2, part3);
            bool must_be = false;
            Assert.AreEqual(must_be, result);
        }
        [TestMethod]
        public void TestTriangleArea2()
        {
            double part1 = 7;
            double part2 = 24;
            double part3 = 25;
            double result = AreaLibrary.TriangleArea(part1, part2, part3);
            double must_be = 84;
            Assert.AreEqual(must_be, result);
        }
        [TestMethod]
        public void TestTriangleAreaEqual2()
        {
            double part1 = 7;
            double part2 = 24;
            double part3 = 25;
            bool result = AreaLibrary.IsTriangle90(part1, part2, part3);
            bool must_be = true;
            Assert.AreEqual(must_be, result);
        }
    }
}

