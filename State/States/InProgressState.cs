namespace Patterns.State;

public class InProgressState : State
{
    public InProgressState(Leasing leasing) : base(leasing)
    {
        this.Description = "En Cursatura";
    }
    public override void Next()
    {
        this.LeasingOperation.changeStatus(new ApprovedState(this.LeasingOperation));
    }
    public override void Repair()
    {
        this.LeasingOperation.changeStatus(new InRepairState(this.LeasingOperation));
    }
    public override void Refuse()
    {
        this.LeasingOperation.changeStatus(new RefusedState(this.LeasingOperation));
    }

}