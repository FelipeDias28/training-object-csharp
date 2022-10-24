using System;
using Objetos.ContentContext;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();

            articles.Add(new Article("Artigo sobre OOP", "orientacao-objeto"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }

            var courses = new List<Course>();

            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsahp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseDotNet = new Course("Fundamentos .NET", "fundamentos-dotnet");

            courses.Add(courseOOP);
            courses.Add(courseCsahp);
            courses.Add(courseDotNet);

            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");

            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsahp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseDotNet);

            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem);

            careers.Add(careerDotNet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);

                foreach (var item in career.Items.OrderBy(x => x.Ordem)) // Percorrer os itens da carreira
                {
                    Console.WriteLine($"{item.Ordem} - {item.Title}");
                    Console.WriteLine(item.Course?.Title); // interrogação checa se o objeto é nulo
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                }
            }
        }
    }
}