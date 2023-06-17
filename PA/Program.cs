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

        return WaitingCalls.OrderBy(call => call.Time).FirstOrDefault();
    }
}

class CallCentre
{
    public List<Employee> Employees { get; set; }
    public List<Queue> Queues { get; set; }

   
}