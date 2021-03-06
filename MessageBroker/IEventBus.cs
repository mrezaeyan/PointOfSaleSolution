using EventContract;

namespace MessageBroker
{
    public interface IEventBus
    {
        void Publish(IEvent @event);
        void Subscribe<T, TH>()
            where T : IEvent
            where TH : IEventHandler<T>;
        void SubscribeDynamic<TH>(string eventName)
            where TH : IDynamicEventHandler;
        void UnsubscribeDynamic<TH>(string eventName)
            where TH : IDynamicEventHandler;
        void Unsubscribe<T, TH>()
            where TH : IEventHandler<T>
            where T : IEvent;
    }
}