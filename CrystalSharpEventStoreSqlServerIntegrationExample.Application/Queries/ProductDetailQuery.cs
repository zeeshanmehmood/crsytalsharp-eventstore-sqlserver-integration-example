using System;
using CrystalSharp.Application;
using CrystalSharpEventStoreSqlServerIntegrationExample.Application.ReadModels;

namespace CrystalSharpEventStoreSqlServerIntegrationExample.Application.Queries
{
    public class ProductDetailQuery : IQuery<QueryExecutionResult<ProductReadModel>>
    {
        public Guid GlobalUId { get; set; }
    }
}
