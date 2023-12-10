namespace Patterns.State;

public class StartedState : State
{

    public StartedState(Leasing leasing) : base(leasing)
    {
        this.Description = "Iniciado";
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