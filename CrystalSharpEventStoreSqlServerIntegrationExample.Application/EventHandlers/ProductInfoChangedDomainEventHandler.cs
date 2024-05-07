using System.Threading;
using System.Threading.Tasks;
using CrystalSharp.Domain.Infrastructure;
using CrystalSharpEventStoreSqlServerIntegrationExample.Application.Domain.Aggregates.ProductAggregate.Events;

namespace CrystalSharpEventStoreSqlServerIntegrationExample.Application.EventHandlers
{
    public class ProductInfoChangedDomainEventHandler : ISynchronousDomainEventHandler<ProductInfoChangedDomainEvent>
    {
        public async Task Handle(ProductInfoChangedDomainEvent notification, CancellationToken cancellationToken = default)
        {
            //
        }
    }
}
