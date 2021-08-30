namespace CQRS.Light.Core.Queries
{
    public interface IQueryResult<TResult, TError>
    {
        bool Success { get; set; }
        
        TResult Data { get; set; }
        
        TError Error { get; set; }
    }
}