using Objetos.NotificationContext;

namespace Objetos.SharedContext
{
    // como essa classe serve de base para vários contextos ela fica em um diretório separado
    public class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // em todas as classes que derivarem dele já cria um novo Id
        }
        public Guid Id { get; set; }
    }
}