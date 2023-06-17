using System.Collections.Concurrent;

// Creating employees
Agent agent1 = new Agent();
agent1.Id = 1;
agent1.Name = "Agent 1";
agent1.SeniorityLevel = 1;

Agent agent2 = new Agent { Id = 2, Name = "Agent 2", SeniorityLevel = 2 };
Agent agent3 = new Agent { Id = 3, Name = "Agent 3", SeniorityLevel = 3 };
Employee manager1 = new Employee { Id = 4, Name = "Manager 1" };

// Creating queues
Queue highPriorityQueue = new Queue();
highPriorityQueue.Name = "High Prriority";
highPriorityQueue.Agents = new List<Agent>();
highPriorityQueue.WaitingCalls = new List<Call>();

highPriorityQueue.Agents.Add(agent1);

Queue normalQueue = new Queue();
normalQueue.Name = "Normal Priority";
normalQueue.Agents = new List<Agent>();
normalQueue.WaitingCalls = new List<Call>();
normalQueue.Agents.Add(agent1);
normalQueue.Agents.Add(agent2);
normalQueue.Agents.Add(agent3);

// Creating calls
var call1 = new Call { Time = DateTime.Now, Accepted = true, Agent = agent1 };
var call2 = new Call { Time = DateTime.Now.AddMinutes(-10), Accepted = true, Agent = agent2 };
var call3 = new Call { Time = DateTime.Now.AddMinutes(-5), Accepted = false };

// Adding calls to queues
highPriorityQueue.WaitingCalls.Add(call1);
normalQueue.WaitingCalls.Add(call2);
normalQueue.WaitingCalls.Add(call3);

// Creating call center
CallCentre callCentre = new CallCentre();
callCentre.Employees = new List<Employee>();
callCentre.Queues = new List<Queue>();
callCentre.Employees.Add(agent1);
callCentre.Employees.Add(agent2);
callCentre.Employees.Add(agent3);
callCentre.Employees.Add(manager1);
callCentre.Queues.Add(highPriorityQueue);
callCentre.Queues.Add(normalQueue);

Console.WriteLine("Longest waiting call:");

DateTime date1 = DateTime.Now;
DateTime date2 = normalQueue.GetLongestWaitingCall().Time;
TimeSpan difference = date1 - date2;
Console.WriteLine(difference.Minutes + " Minutes");

        
     