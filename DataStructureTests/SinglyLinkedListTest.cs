using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;

namespace DataStructureTests
{
    [TestClass]
    public class SinglyLinkedListTest
    {
        [TestMethod]
        public void AddToTheEnd_EmptyList_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(10);

            Assert.IsNotNull(list.Head);
            Assert.AreEqual(10, list.Head.Data);
        }

        [TestMethod]
        public void AddToTheEnd_NotEmptyList_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(10);
            list.AddToTheEnd(20);

            Assert.IsNotNull(list.Head.Next);
            Assert.AreEqual(20, list.Head.Next.Data);
        }

        [TestMethod]
        public void Find_EmptyList_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            ListNode<int> result = list.FindElement(10);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Find_ElementIsFirst_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(10);
            list.AddToTheEnd(20);
            list.AddToTheEnd(30);
            ListNode<int> result = list.FindElement(10);
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Data);
        }

        [TestMethod]
        public void Find_ElementIsMiddle_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(10);
            list.AddToTheEnd(20);
            list.AddToTheEnd(30);
            ListNode<int> result = list.FindElement(20);
            Assert.IsNotNull(result);
            Assert.AreEqual(20, result.Data);
        }

        [TestMethod]
        public void Find_ElementIsLast_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(10);
            list.AddToTheEnd(20);
            list.AddToTheEnd(30);
            ListNode<int> result = list.FindElement(20);
            Assert.IsNotNull(result);
            Assert.AreEqual(20, result.Data);
        }

        [TestMethod]
        public void Find_ElementDoesNotExist_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(10);
            list.AddToTheEnd(20);
            list.AddToTheEnd(30);
            ListNode<int> result = list.FindElement(50);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Insert_EmptyList_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.Insert(10);
            Assert.IsNotNull(list.Head);
            Assert.AreEqual(10, list.Head.Data);
        }

        [TestMethod]
        public void Insert_NotEmptyList_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(20);
            list.Insert(10);
            Assert.IsNotNull(list.Head);
            Assert.AreEqual(10, list.Head.Data);
            Assert.IsNotNull(list.Head.Next);
            Assert.AreEqual(20, list.Head.Next.Data);
        }

        [TestMethod]
        public void Delete_EmptyList_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            bool result = list.DeleteNode(20);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Delete_OneElementList_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(20);
            bool result = list.DeleteNode(20);
            Assert.IsTrue(result);
            Assert.IsNull(list.Head);
        }

        [TestMethod]
        public void Delete_FirstElement_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(10);
            list.AddToTheEnd(20);
            bool result = list.DeleteNode(10);
            Assert.IsTrue(result);
            Assert.IsNotNull(list.Head);
            Assert.AreEqual(20, list.Head.Data);
        }

        [TestMethod]
        public void Delete_LastElement_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(10);
            list.AddToTheEnd(20);
            bool result = list.DeleteNode(20);
            Assert.IsTrue(result);
            Assert.IsNotNull(list.Head);
            Assert.IsNull(list.Head.Next);
        }

        [TestMethod]
        public void Delete_MiddleElement_Success()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();
            list.AddToTheEnd(10);
            list.AddToTheEnd(20);
            list.AddToTheEnd(30);
            bool result = list.DeleteNode(20);
            Assert.IsTrue(result);
            Assert.IsNotNull(list.Head);
            Assert.IsNotNull(list.Head.Next);
            Assert.AreEqual(30, list.Head.Next.Data);
        }
    }
}
