using DependencyInjectionAllThreeService.Interfaces;

namespace DependencyInjectionAllThreeService.Services
{
    public class Singletons : ISingleton
    {
        private readonly Guid number;
        public Singletons()
        {
                number = Guid.NewGuid();
        }
        public string PrintGuidNumber()
        {
            return number.ToString();
        }
    }
}
