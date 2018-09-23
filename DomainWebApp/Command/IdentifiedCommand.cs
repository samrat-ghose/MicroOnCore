using MediatR;
using System;

namespace Microsoft.eShopOnContainers.Services.Ordering.API.Application.Commands
{
    public class IdentifiedCommand<T, R> : IRequest<R>
        where T : IRequest<R>
    {
        public T Command { get; }
        public string Id { get; }
        public IdentifiedCommand(T command, string id)
        {
            Command = command;
            Id = id;
        }
    }
}
