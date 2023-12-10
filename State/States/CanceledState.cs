namespace Patterns.State;

public class CanceledState : State
{
    public CanceledState(Leasing leasing) : base(leasing)
    {
        this.Description = "Cancelada";
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