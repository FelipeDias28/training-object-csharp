using Objetos.ContentContext.Enums;

namespace Objetos.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>(); // Sempre inicializar outros objetos
        }

        public string? Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}