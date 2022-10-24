using Objetos.NotificationContext;
using Objetos.SharedContext;

namespace Objetos.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public User? User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if (isPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já possui uma assinatura ativa"));
                return; // somente para sair da função
            }

            Subscriptions.Add(subscription);
        }

        public bool isPremium => Subscriptions.Any(x => !x.IsInactive); // Se não tiver nenhuma assinatura ativa
    }
}