using EstoqueApp.Application.Notifications;
using MediatR;

namespace EstoqueApp.Application.Handlers.Notifications
{
    public class ProdutoNotificationHandler
        : INotificationHandler<ProdutoNotification>
    {
        public Task Handle(ProdutoNotification notification, CancellationToken cancellationToken)
        {
            //TODO enviar para o MongoDB
            throw new NotImplementedException();
        }
    }
}