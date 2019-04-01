namespace CQRS.Core.Commands
{
    public interface ICommandResult<TResult, TError>
    {
        bool Success { get; set; }
        
        TResult Data { get; set; }
        
        TError Error { get; set; }
    }
}