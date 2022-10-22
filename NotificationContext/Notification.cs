namespace Objetos.NotificationContext
{
    public sealed class Notification // essa classe não pode ser extendida, não pode ser usada como herança
    {
        public Notification()
        {

        }

        public Notification(string property, string message)
        {
            this.Property = property;
            this.Message = message;
        }

        public string? Property { get; set; }
        public string? Message { get; set; }
    }
}