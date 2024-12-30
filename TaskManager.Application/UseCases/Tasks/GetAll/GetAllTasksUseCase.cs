using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute() 
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = 1,
                    Name = "Task Name",
                    Description = "Task Description",
                    Priority = Communication.Enums.PriorityType.Medium,
                    Date = DateTime.UtcNow,
                    Status = Communication.Enums.StatusType.Waiting
                }
            }
        };
    }
}
