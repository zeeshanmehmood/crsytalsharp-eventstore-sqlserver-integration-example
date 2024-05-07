using System.Threading;
using System.Threading.Tasks;
using CrystalSharp.Domain.Infrastructure;
using CrystalSharpEventStoreSqlServerIntegrationExample.Application.Domain.Aggregates.ProductAggregate.Events;

namespace CrystalSharpEventStoreSqlServerIntegrationExample.Application.EventHandlers
{
    public class ProductNameChangedDomainEventHandler : ISynchronousDomainEventHandler<ProductNameChangedDomainEvent>
    {
        public async Task Handle(ProductNameChangedDomainEvent notification, CancellationToken cancellationToken = default)
        {
            //
        }
    }
}
