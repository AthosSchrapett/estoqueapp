using EstoqueApp.Application.Models.Queries;
using MediatR;

namespace EstoqueApp.Application.Notifications
{
    public class EstoqueNotification : INotification
    {
        public ActionNotification? Action { get; set; }
        public EstoqueQuery? Estoque { get; set; }
    }
}