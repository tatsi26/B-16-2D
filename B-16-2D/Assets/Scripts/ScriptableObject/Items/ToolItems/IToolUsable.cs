using Inventory.Items.Flags;

namespace Inventory.Items.Toolitem
{
    public interface IToolUsable
    {
        ToolCapability Capability { get; }
        int Volume { get; }
    }
}