using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;

namespace EstoqueApp.Application.Interfaces.Services
{
    public interface IProdutoAppService
    {
        Task<ProdutoQuery> Create(ProdutoCreateCommand command);
        Task<ProdutoQuery> Update(ProdutoUpdateCommand command);
        Task<ProdutoQuery> Delete(ProdutoDeleteCommand command);

        List<ProdutoQuery> GetAll();
        ProdutoQuery GetById(Guid? id);
    }
}