using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;

public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityType priority { get; set; }
    public DateTime date { get; set; }
    public StatusType status { get; set; }
}
