using Inventory.Items.Flags;
using UnityEngine;

namespace Inventory.Items.Toolitem
{
    [CreateAssetMenu(fileName = "New Tool Item", menuName = "Inventory System/Item/ToolItem")]
    public class ToolItemObject : ItemsObject, IToolUsable
        {
            [field: SerializeField] public ToolCapability Capability { get; set; }
            [field: SerializeField] public int Volume { get; private set; }
        }
}