using EstoqueApp.Application.Models.Queries;
using MediatR;

namespace EstoqueApp.Application.Models.Commands
{
    public class ProdutoDeleteCommand : IRequest<ProdutoQuery>
    {
        public Guid? Id { get; set; }
    }
}