using System;
using CrystalSharp.Application;
using CrystalSharpEventStoreSqlServerIntegrationExample.Application.Responses;

namespace CrystalSharpEventStoreSqlServerIntegrationExample.Application.Commands
{
    public class ChangeProductNameCommand : ICommand<CommandExecutionResult<ProductResponse>>
    {
        public Guid GlobalUId { get; set; }
        public string Name { get; set; }
    }
}
