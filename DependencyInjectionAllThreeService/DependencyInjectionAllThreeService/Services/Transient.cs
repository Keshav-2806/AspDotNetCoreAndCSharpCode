using DependencyInjectionAllThreeService.Interfaces;

namespace DependencyInjectionAllThreeService.Services
{
    public class Transient : ITransient
    {
        private readonly Guid number;
        public Transient()
        {
                number= Guid.NewGuid();
        }
        public string PrintGuidNumber()
        {
            return number.ToString();
        }
    }
}
