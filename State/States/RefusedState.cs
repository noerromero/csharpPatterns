namespace Patterns.State;

public class RefusedState : State
{
    public RefusedState(Leasing leasing) : base(leasing)
    {
        this.Description = "Rechazada";
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