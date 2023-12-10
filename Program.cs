using Patterns.State;

var newLeasingOperation = new Leasing();
Console.WriteLine($"Estado {newLeasingOperation.GetStatus()}");

newLeasingOperation.GoNextStatus();
Console.WriteLine($"Estado {newLeasingOperation.GetStatus()}");

newLeasingOperation.CancelOperation();
Console.WriteLine($"Estado {newLeasingOperation.GetStatus()}");

newLeasingOperation.GoNextStatus();
Console.WriteLine($"Estado {newLeasingOperation.GetStatus()}");