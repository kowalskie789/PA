using System;

 class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}
class Agent : Employee
{
    public int SeniorityLevel { get; set; }
}

class Call
{
    public DateTime Time { get; set; }
    public bool Accepted { get; set; }
    public Employee? Agent { get; set; }
}

class Queue
{
    public string Name { get; set; }
    public List<Call>? WaitingCalls { get; set; }
    public List<Agent>? Agents { get; set; }

    public Call GetLongestWaitingCall()
    {
       var Waiting = new List<Call>();
       foreach (Call waiting in WaitingCalls)
        {
            if (!waiting.Accepted)
            {
              Waiting.Add(waiting);
            }
        }
            return Waiting.OrderBy(call => call.Time).FirstOrDefault();
    }
}

class CallCentre
{
    public List<Employee> Employees { get; set; }
    public List<Queue> Queues { get; set; }

    public Queue GetQueueWithMostCalls()
    {
        return Queues.OrderByDescending(q => q.WaitingCalls.Count).FirstOrDefault();
    }
}