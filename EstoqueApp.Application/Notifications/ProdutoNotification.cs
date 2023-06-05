using EstoqueApp.Application.Models.Queries;
using MediatR;

namespace EstoqueApp.Application.Notifications
{
    public class ProdutoNotification : INotification
    {
        public ActionNotification? Action { get; set; }
        public ProdutoQuery? Produto { get; set; }
    }
}