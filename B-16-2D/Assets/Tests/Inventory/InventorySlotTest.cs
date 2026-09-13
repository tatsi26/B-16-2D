/*using Inventory;
using Inventory.Container;
using Inventory.Database;
using NUnit.Framework;

namespace Tests.Inventory
{
    public class InventorySlotTest
    {
        private ItemDatabaseObject _database;

        [SetUp]
        public void Setup()
        {
            _database = TestHelper.CreateTestDatabase(10);
        }

      //  [TearDown]
      //  public void TearDown()
      //  {
      //      TestHelper.DestroyDatabase(_database);
      //  }

        [Test]
        public void NewSlot_isEmpty()
        {
            var slot = new InventorySlot();
            
            Assert.AreEqual(-1, slot.ID);
            Assert.AreEqual(0, slot.amount);
        }

        [Test]
        public void UpdateSlot_SetsIdAndAmount()
        {
            var slot = new InventorySlot();

            slot.UpdateSlot(0, 5, _database);
            
            Assert.AreEqual(0, slot.ID);
            Assert.AreEqual(5, slot.amount);
        }

        [Test]
        public void UpdateSlot_InvokeOnChange()
        {
            var slot = new InventorySlot();
            bool changed = false;
            
            slot.OnChanged += () => changed = true;
            
            slot.UpdateSlot(0, 5, _database);
            
            Assert.IsTrue(changed);
        }

        [Test]
        public void AddAmount_IncreaseAmount()
        {
            var slot = new InventorySlot();
            slot.UpdateSlot(0, 5, _database);

            slot.AddAmount(2);
            
            Assert.AreEqual(7, slot.amount);
        }

        [Test]
        public void AddAmount_InvokeOnChange()
        {
            var slot = new InventorySlot();
            slot.UpdateSlot(0, 5, _database);

            int callCount = 0;
            slot.OnChanged += () => callCount ++;

            slot.AddAmount(2);
            
            Assert.AreEqual(1, callCount);
        }

     //   [Test]
     //   public void TryConsume_RemoveOneItem()
     //   {
     //       var slot = new InventorySlot();
     //       slot.UpdateSlot(0, 5, _database);
            
     //       bool result = slot.TryConsume();
            
     //       Assert.IsTrue(result);
     //       Assert.AreEqual(4, slot.amount);
        }

    //     [Test]
    //    public void TryConsume_ReturnFalse_WhenOnlyOneItemLeft()
    //    {
    //        var slot = new InventorySlot();
    //         slot.UpdateSlot(0, 1, _database);
            
    //       bool result = slot.TryConsume();
            
    //       Assert.IsFalse(result);
    //        Assert.AreEqual(1, slot.amount);
    //     }

    //       [Test]
    //      public void TryConsume_ReturnTrue_WhenSlotIsNull()
    //      {
    //         InventorySlot slot = null;

    //       bool result = slot.TryConsume();
            
    //        Assert.IsFalse(result);
    //    }
    //  }
}*/