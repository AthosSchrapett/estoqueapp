using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Application.Models.Queries;

namespace EstoqueApp.Application.Interfaces.Services
{
    public interface IEstoqueAppService
    {
        Task<EstoqueQuery> Create(EstoqueCreateCommand command);
        Task<EstoqueQuery> Update(EstoqueUpdateCommand command);
        Task<EstoqueQuery> Delete(EstoqueDeleteCommand command);

        List<EstoqueQuery> GetAll();
        EstoqueQuery GetById(Guid? id);
    }
}