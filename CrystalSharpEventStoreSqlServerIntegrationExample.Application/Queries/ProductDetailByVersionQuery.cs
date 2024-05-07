using System;
using CrystalSharp.Application;
using CrystalSharpEventStoreSqlServerIntegrationExample.Application.ReadModels;

namespace CrystalSharpEventStoreSqlServerIntegrationExample.Application.Queries
{
    public class ProductDetailByVersionQuery : IQuery<QueryExecutionResult<ProductReadModel>>
    {
        public Guid GlobalUId { get; set; }
        public long Version { get; set; }
    }
}
