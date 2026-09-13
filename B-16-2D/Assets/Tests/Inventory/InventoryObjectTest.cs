/*using Inventory;
using Inventory.Container;
using Inventory.Database;
using Inventory.Items;
using NUnit.Framework;
using UnityEditor;

namespace Tests.Inventory
{
    public class InventoryObjectTest
    {
        private ItemDatabaseObject _database;
        private InventoryObject _inventory;

        [SetUp]
        public void Setup()
        {
            _database = TestHelper.CreateTestDatabase( 10, 1);
            _inventory = TestHelper.CreateTestInventory(_database, 3);
        }

        [TearDown]
        public void TearDown()
        {
            TestHelper.Destroy( _inventory);
            TestHelper.DestroyDatabase(_database);
        }

        private Progress.Item GetItem(int id)
        {
            return _database.GetItem[id].CreateItem();
        }

        [Test]
        public void AddItem_PutsItemInToEmptySlot()
        {
            var item = GetItem(0);
            
            _inventory.AddItem(item, 3);
            
            Assert.AreEqual(0, _inventory.container.Items[0].ID);
            Assert.AreEqual(3, _inventory.container.Items[0].amount);
        }

        [Test]
        public void AddItem_AddsToExistingStack()
        {
            _inventory.container.Items[0].UpdateSlot(0, 4, _database);
            var item = GetItem(0);
            
            _inventory.AddItem(item, 3);
            
            Assert.AreEqual(7, _inventory.container.Items[0].amount);
        }

        [Test]
        public void AddItem_CreateNewStack_WhenCurrentStackIsFull()
        {
            _inventory.container.Items[0].UpdateSlot(0, 4, _database);
            var item = GetItem(0);
            
            _inventory.AddItem(item, 5);
            
            Assert.AreEqual(10, _inventory.container.Items[0].amount);
            Assert.AreEqual(0, _inventory.container.Items[1].ID);
            Assert.AreEqual(4, _inventory.container.Items[0].amount);
        }

        [Test]
        public void AddItem_SplitsItemsBetweenSlots()
        {
            var item = GetItem(0);
            
            _inventory.AddItem(item, 25);
            
            Assert.AreEqual(10, _inventory.container.Items[0].amount);
            Assert.AreEqual(10, _inventory.container.Items[1].amount);
            Assert.AreEqual(5, _inventory.container.Items[2].amount);
        }

        [Test]
        public void AddItem_DoesNothing_IfInventoryIsFull()
        {
            var item = GetItem(0);

            for (int i = 0; i < 3; i++)
            {
                _inventory.container.Items[i].UpdateSlot(1, 1, _database);
            }
            
            Assert.DoesNotThrow(() => _inventory.AddItem(item, 5));
        }

        [Test]
        public void MoveItem_SwapDifferentItems()
        {
            _inventory.container.Items[0].UpdateSlot(0, 4, _database);
            _inventory.container.Items[1].UpdateSlot(1, 1, _database);

            _inventory.MoveItem(_inventory.container.Items[0], _inventory.container.Items[1]);
            
            Assert.AreEqual(1, _inventory.container.Items[0].ID);
            Assert.AreEqual(1, _inventory.container.Items[0].amount);
            Assert.AreEqual(1, _inventory.container.Items[1].ID);
            Assert.AreEqual(1, _inventory.container.Items[0].amount);
        }
    }
}*/