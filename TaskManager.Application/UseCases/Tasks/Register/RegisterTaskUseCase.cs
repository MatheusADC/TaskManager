using TaskManager.Communication.Responses;
using TaskManager.Communication.Requests;

namespace TaskManager.Application.UseCases.Tasks.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisteredTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseRegisteredTaskJson
        {
            Id = 1,
            Name = request.Name,
            Description = request.Description,
            Priority = request.priority,
            Date = request.date,
            Status = request.status,
        };
    }
}
