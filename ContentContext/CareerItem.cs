using Objetos.NotificationContext;

namespace Objetos.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int ordem, string title, string description, Course? course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso inválido")); // Pode chamar o método pois Base recebe o Notifiable como herança

            Ordem = ordem;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course? Course { get; set; }
    }
}