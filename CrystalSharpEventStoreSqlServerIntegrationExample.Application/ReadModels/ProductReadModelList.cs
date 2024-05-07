using System.Collections.Generic;

namespace CrystalSharpEventStoreSqlServerIntegrationExample.Application.ReadModels
{
    public class ProductReadModelList
    {
        public IEnumerable<ProductReadModel> Products { get; set; }
    }
}
