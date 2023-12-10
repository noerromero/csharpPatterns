namespace Patterns.State;
public abstract class State
{

    protected State(Leasing leasingOperation)
    {
        LeasingOperation = leasingOperation;
    }
    protected Leasing LeasingOperation { get; set; }
    public string Description { get; set; } = string.Empty;
    public abstract void Next();
    public abstract void Repair();
    public abstract void Refuse();
    public void Cancel()
    {
        if (this.LeasingOperation.Status.Description == "Cancelada")
            return;
        this.LeasingOperation.changeStatus(new CanceledState(this.LeasingOperation));
    }
}