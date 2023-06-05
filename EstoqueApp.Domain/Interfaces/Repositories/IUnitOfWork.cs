namespace EstoqueApp.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IEstoqueRepository EstoqueRepository { get; }
        IProdutoRepository ProdutoRepository { get; }

        void SaveChanges();
    }
}