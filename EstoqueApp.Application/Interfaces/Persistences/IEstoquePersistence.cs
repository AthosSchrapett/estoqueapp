using EstoqueApp.Application.Models.Queries;

namespace EstoqueApp.Application.Interfaces.Persistences
{
    public interface IEstoquePersistence : IBasePersistence<EstoqueQuery, Guid>
    {

    }
}