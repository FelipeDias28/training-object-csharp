using Objetos.SharedContext;

namespace Objetos.ContentContext
{
    // Nesta classe vai tudo que é comum dentro de ContentContext (clase base)
    // Por ser abstrata não é possivel instânciar, somente utilizar como herança
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {

            Title = title;
            Url = url;
        }


        public string Title { get; set; }
        public string Url { get; set; }
    }
}