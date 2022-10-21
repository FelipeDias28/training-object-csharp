namespace Objetos.ContentContext
{
    public class Module
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; } // Modulo 1, 2, 3
        public string? Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }
}