using Objetos.SharedContext;

namespace Objetos.SubscriptionContext
{
    public class User : Base
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}