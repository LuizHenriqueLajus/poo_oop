using p.o.o.NotificationContext;
using System;

namespace p.o.o.SharedContext

{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); //SPOF - Single Point of Failure
        }
        public Guid Id { get; set; }
    }
}
