namespace Patterns.State;

public class FinishedState : State
{
    public FinishedState(Leasing leasing) : base(leasing)
    {
        this.Description = "Finalizada";
    }
    public override void Next()
    {
        throw new NotImplementedException();
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