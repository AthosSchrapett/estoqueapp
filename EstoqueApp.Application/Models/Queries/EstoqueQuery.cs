namespace EstoqueApp.Application.Models.Queries
{
    public class EstoqueQuery
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataHoraCriacao { get; set; }
    }
}