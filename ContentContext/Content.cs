namespace Objetos.ContentContext
{
    // Nesta classe vai tudo que é comum dentro de ContentContext (clase base)
    // Por ser abstrata não é possivel instânciar, somente utilizar como herança
    public abstract class Content
    {
        public Content(string title, string url)
        {
            Id = Guid.NewGuid(); // em todas as classes que derivarem dele já cria um novo Id
            Title = title;
            Url = url;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}