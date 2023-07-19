using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
    [TestClass]
    public class ItemTests : IDisposable
    {
        public void Dispose()
        {
            Item.ClearAll();
        }

    [TestMethod]
    public void ItemConstructor_InstantiateItemClass_Item()
    {
        Item testItem = new Item("water bottle", true, false, 3);
        Assert.AreEqual(typeof(Item), testItem.GetType());
    }

    [TestMethod]
    public void ItemConstructor_FieldUpdates_FieldNames()
    {
        Item testItem = new Item("water bottle", true, false, 3);
        Assert.AreEqual((testItem.Name, testItem.Packed, testItem.Purchased, testItem.Weight), ("water bottle", true, false, 3));
    }

    [TestMethod]

    public void GetAll_GetAListOfItems_list()
    {
        List<Item> myList = new List<Item> { };
        List<Item> testList = Item.GetAll();
        CollectionAssert.AreEqual(myList, testList);
    }
}
}