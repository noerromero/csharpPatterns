namespace Patterns.State;

public class InRepairState : State
{
    public InRepairState(Leasing leasing) : base(leasing)
    {
        this.Description = "En Reparacion";
    }
    public override void Next()
    {
        this.LeasingOperation.changeStatus(new InProgressState(this.LeasingOperation));
    }
    public override void Repair()
    {
        throw new NotImplementedException();
    }
    public override void Refuse()
    {
        throw new NotImplementedException();
    }

}