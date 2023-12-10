namespace Patterns.State;

public class ApprovedState : State
{
    public ApprovedState(Leasing leasing) : base(leasing)
    {
        this.Description = "Aprobado";
    }
    public override void Next()
    {
        //this.LeasingOperation.changeStatus(new InProgressState(this.LeasingOperation));
    }
    public override void Repair()
    {

    }
    public override void Refuse()
    {

    }

}