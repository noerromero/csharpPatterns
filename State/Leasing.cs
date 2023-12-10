namespace Patterns.State;

public class Leasing
{

    public int OperationNumber { get; set; }

    public State Status { get; set; }

    public Leasing()
    {
        Status = new StartedState(this);
    }

    public void changeStatus(State status)
    {
        Status = status;
    }

    public void GoNextStatus()
    {
        Status.Next();
    }

    public void RepairOperation()
    {
        Status.Repair();
    }

    public void RefuseOperation()
    {
        Status.Refuse();
    }

    public void CancelOperation()
    {
        Status.Cancel();
    }

    public string GetStatus()
    {
        return this.Status.Description;
    }
}