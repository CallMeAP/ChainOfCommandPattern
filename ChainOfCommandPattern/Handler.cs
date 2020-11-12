namespace ChainOfCommandPattern
{
    public abstract class Handler<T> : IHandler<T> where T : class
    {
        private IHandler<T> Next { get; set; }
        
        //virtual: Kann in einer derived class überschrieben (override) werden
        public virtual void Handle(T request)
        {
            Next?.Handle(request);
        }

        public IHandler<T> SetNext(IHandler<T> next)
        {
            Next = next;
            return Next;
        }
    }

    public interface IHandler<T> where T : class
    {
        //append handler to queue
        IHandler<T> SetNext(IHandler<T> next);
        
        //handle current handler and call next handler in queue
        void Handle(T request);
    }
}
