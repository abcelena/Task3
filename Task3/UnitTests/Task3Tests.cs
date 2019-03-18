using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Task3Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cl = new Task3.Task3();
            var A = new int[] { -3, -2, 1, 0, 8, 7, 1 };
            int M = 3;


            var actual = cl.solution(A, M);

            Assert.AreEqual(4, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var cl = new Task3.Task3();
            var A = new int[100000];
            int M = 100000;
            for (int i = 0; i < 100000; i++)
            {
                A[i] = i + 1;
            }
            //Act
            var actual = cl.solution(A, M);
            //Assert
            Assert.AreEqual(1, actual);
        }
    }
}
