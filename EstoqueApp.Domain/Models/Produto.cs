namespace EstoqueApp.Domain.Models
{
    public class Produto
    {
        #region Propriedades

        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }
        public Guid? EstoqueId { get; set; }

        #endregion

        #region Relacionamentos

        public Estoque? Estoque { get; set; }

        #endregion
    }
}