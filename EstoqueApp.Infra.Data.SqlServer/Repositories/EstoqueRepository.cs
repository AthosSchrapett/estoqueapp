using EstoqueApp.Domain.Interfaces.Repositories;
using EstoqueApp.Domain.Models;
using EstoqueApp.Infra.Data.SqlServer.Contexts;

namespace EstoqueApp.Infra.Data.SqlServer.Repositories
{
    public class EstoqueRepository
        : BaseRepository<Estoque, Guid>, IEstoqueRepository
    {
        private readonly DataContext? _dataContext;

        public EstoqueRepository(DataContext? dataContext)
            : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}