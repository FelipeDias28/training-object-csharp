namespace Objetos.NotificationContext
{
    public abstract class Notifiable // não é possível criar uma instância dessa classe
    {
        protected Notifiable()
        {
            Notifications = new List<Notification>();
        }

        List<Notification> Notifications { get; set; }

        public void Add(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddRange(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}