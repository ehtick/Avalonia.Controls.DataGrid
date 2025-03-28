using Avalonia.Automation.Peers;

namespace Avalonia.Controls.Automation.Peers;

#if !DATAGRID_INTERNAL
public
#endif
class DataGridCellAutomationPeer : ContentControlAutomationPeer
{
    public DataGridCellAutomationPeer(DataGridCell owner)
        : base(owner)
    {
    }

    public new DataGridCell Owner => (DataGridCell)base.Owner;

    protected override AutomationControlType GetAutomationControlTypeCore()
    {
        return AutomationControlType.Custom;
    }

    protected override bool IsContentElementCore() => true;

    protected override bool IsControlElementCore() => true;
}
