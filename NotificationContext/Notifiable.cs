namespace Objetos.NotificationContext
{
    public abstract class Notifiable // não é possível criar uma instância dessa classe
    {
        protected Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public List<Notification> Notifications { get; set; }

        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        public bool IsInvalid => Notifications.Any(); // Se tiver notificação ele é inválido
    }
}