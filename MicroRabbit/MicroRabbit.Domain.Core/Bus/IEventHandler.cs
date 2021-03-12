using MicroRabbit.Domain.Core.Events;
using Microsoft.VisualStudio;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventHandler <in TEvent> : IEventHandler 
        where TEvent: Event
    {
        Task Handler(TEvent @event);
    }
    public interface IEventHandler
    {

    }
}
