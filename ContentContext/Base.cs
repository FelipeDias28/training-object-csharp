using Objetos.NotificationContext;

namespace Objetos.ContentContext
{
    public class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // em todas as classes que derivarem dele já cria um novo Id
        }
        public Guid Id { get; set; }
    }
}