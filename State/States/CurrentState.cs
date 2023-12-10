namespace Patterns.State;

public class CurrentState : State
{
    public CurrentState(Leasing leasing) : base(leasing)
    {
        this.Description = "Vigente";
    }
    public override void Next()
    {
        this.LeasingOperation.changeStatus(new FinishedState(this.LeasingOperation));
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