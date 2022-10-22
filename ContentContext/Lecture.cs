using Objetos.ContentContext.Enums;

namespace Objetos.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; } // Aula 1, 2, 3
        public string? Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}