using System;
using CrystalSharp.Application;
using CrystalSharpEventStoreSqlServerIntegrationExample.Application.Responses;

namespace CrystalSharpEventStoreSqlServerIntegrationExample.Application.Commands
{
    public class DeleteProductCommand : ICommand<CommandExecutionResult<DeleteProductResponse>>
    {
        public Guid GlobalUId { get; set; }
    }
}
