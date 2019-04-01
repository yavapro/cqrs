namespace CQRS.Light.Core.Commands
{
    using System.Threading.Tasks;

    public interface ICommandHandler<in TCommand, TResult, TError>
        where TCommand : ICommand
    {
        Task<ICommandResult<TResult, TError>> ExecuteAsync(TCommand command);
    }
}