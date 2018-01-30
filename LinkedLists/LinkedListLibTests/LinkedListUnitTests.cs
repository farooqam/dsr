using System;
using FluentAssertions;
using LinkedListLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListLibTests
{
    [TestClass]
    public class LinkedListUnitTests
    {
        [TestMethod]
        public void Add_Single_Node()
        {
            var list = new LinkedList<int>();
            list.AddNode(10);
            list.Head.Data.Should().Be(10);
            list.Search(10).Should().Be(0);
        }

        [TestMethod]
        public void Add_Multiple_Nodes()
        {
            var list = new LinkedList<int>();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);
            list.Head.Data.Should().Be(10);
            list.Search(10).Should().Be(0);
            list.Search(20).Should().Be(1);
            list.Search(30).Should().Be(2);
        }

        [TestMethod]
        public void Search_When_Not_Found_Returns_Minus_One()
        {
            var list = new LinkedList<int>();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);
            list.Search(100).Should().Be(LinkedList<int>.NotFound);
        }

        [TestMethod]
        public void Search_When_List_Empty_Returns_Minus_One()
        {
            var list = new LinkedList<int>();
            list.Search(100).Should().Be(LinkedList<int>.NotFound);
        }

        [TestMethod]
        public void ItemAt_When_List_Empty_Returns_Null()
        {
            var list = new LinkedList<int>();
            list.ItemAt(0).Should().BeNull();
        }

        [TestMethod]
        public void ItemAt_Returns_Node()
        {
            var list = new LinkedList<int>();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);

            list.ItemAt(0).Data.Should().Be(10);
            list.ItemAt(1).Data.Should().Be(20);
            list.ItemAt(2).Data.Should().Be(30);

        }

        [TestMethod]
        public void ItemAt_When_Index_Larger_Than_List_Length_Returns_Last_Node()
        {
            var list = new LinkedList<int>();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);

            list.ItemAt(100).Data.Should().Be(30);
        }

        [TestMethod]
        public void InsertAt_When_List_Empty_Adds_Node_Regardless_Of_Index()
        {
            var list = new LinkedList<int>();
            list.InsertAt(100, 10);
            list.Head.Data.Should().Be(10);
        }

        [TestMethod]
        public void InsertAt_When_Index_Larger_Than_List_Length_Inserts_At_End()
        {
            var list = new LinkedList<int>();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);

            list.InsertAt(100, 40);
            list.Search(40).Should().Be(3);

        }

        [TestMethod]
        public void InsertAt_Inserts_Node()
        {
            var list = new LinkedList<int>();
            list.AddNode(10);
            list.AddNode(20);
            list.AddNode(30);

            list.InsertAt(1, 15);

            var data = list.EnumerateNodes();
            list.Search(15).Should().Be(1);

        }
    }
}
