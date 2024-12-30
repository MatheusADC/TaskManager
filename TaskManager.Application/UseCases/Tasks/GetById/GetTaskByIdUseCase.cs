using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Tasks.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
           Id = id,
           Name = "Task Name2",
           Description = "Description Task2",
           Priority = Communication.Enums.PriorityType.Low,
           Date = new DateTime(year: 2024, month: 12, day: 30),
           Status = Communication.Enums.StatusType.Completed
        };
    }
}
