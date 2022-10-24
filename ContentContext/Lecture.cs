using Objetos.ContentContext.Enums;
using Objetos.SharedContext;

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