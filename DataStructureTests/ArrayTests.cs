using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructureTests
{
    [TestClass]
    public class ArraysTests
    {
        [TestMethod]
        public void FindMax_EmptyArray_Success()
        {
            ArrayAlgorithms arrayAlg = new ArrayAlgorithms();

            int[] array = { };
            int response = arrayAlg.FindMax(array);
            Assert.AreEqual(-1, response);
        }

        [TestMethod]
        public void FindMax_NullArray_Success()
        {
            ArrayAlgorithms arrayAlg = new ArrayAlgorithms();

            int[] array = null;
            int response = arrayAlg.FindMax(array);
            Assert.AreEqual(-1, response);
        }

        [TestMethod]
        public void FindMax_OneElement_Success()
        {
            ArrayAlgorithms arrayAlg = new ArrayAlgorithms();

            int[] array = { 2 };
            int response = arrayAlg.FindMax(array);
            Assert.AreEqual(2, response);
        }
        
        [TestMethod]
        public void FindMax_ManyElements_Success()
        {
            ArrayAlgorithms arrayAlg = new ArrayAlgorithms();

            int[] array = { 2, 5, 6, 6};
            int response = arrayAlg.FindMax(array);
            Assert.AreEqual(6, response);
        }
        
        [TestMethod]
        public void FindMaxCompareToAll_EmptyArray_Success()
        {
            ArrayAlgorithms arrayAlg = new ArrayAlgorithms();

            int[] array = { };
            int response = arrayAlg.FindMaxCompareToAll(array);
            Assert.AreEqual(-1, response);
        }

        [TestMethod]
        public void FindMaxCompareToAll_NullArray_Success()
        {
            ArrayAlgorithms arrayAlg = new ArrayAlgorithms();

            int[] array = null;
            int response = arrayAlg.FindMaxCompareToAll(array);
            Assert.AreEqual(-1, response);
        }

        [TestMethod]
        public void FindMaxCompareToAll_OneElement_Success()
        {
            ArrayAlgorithms arrayAlg = new ArrayAlgorithms();

            int[] array = { 2 };
            int response = arrayAlg.FindMaxCompareToAll(array);
            Assert.AreEqual(2, response);
        }
        
        [TestMethod]
        public void FindMaxCompareToAll_ManyElements_Success()
        {
            ArrayAlgorithms arrayAlg = new ArrayAlgorithms();

            int[] array = { 2, 5, 6, 6 };
            int response = arrayAlg.FindMaxCompareToAll(array);
            Assert.AreEqual(6, response);
        }
    }
}
