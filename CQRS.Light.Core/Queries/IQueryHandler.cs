namespace CQRS.Light.Core.Queries
{
    using System.Threading.Tasks;

    public interface IQueryHandler<in TQuery, TResult> 
        where TQuery : IQuery
    {
        Task<TResult> AskAsync(TQuery query);
    }
    
    public interface IQueryHandler<in TQuery, TResult, TError> 
        where TQuery : IQuery
    {
        Task<IQueryResult<TResult, TError>> AskAsync(TQuery query);
    }
}