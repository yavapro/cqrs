namespace CQRS.Light.Core.Queries
{
    using System.Threading.Tasks;

    public interface IQueryHandler<in TQuery, TQueryResult> 
        where TQuery : IQuery
    {
        Task<TQueryResult> AskAsync(TQuery query);
    }
}