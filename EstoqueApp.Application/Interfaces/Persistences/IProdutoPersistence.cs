using EstoqueApp.Application.Models.Queries;

namespace EstoqueApp.Application.Interfaces.Persistences
{
    public interface IProdutoPersistence : IBasePersistence<ProdutoQuery, Guid>
    {

    }
}