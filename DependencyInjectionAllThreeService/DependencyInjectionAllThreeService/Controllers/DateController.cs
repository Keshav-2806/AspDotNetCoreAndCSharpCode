using DependencyInjectionAllThreeService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAllThreeService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DateController : ControllerBase
    {
        private readonly ISingleton singleton;
        private readonly ISingleton singleton1;
        private readonly ITransient transient;
        private readonly ITransient transient1;
        private readonly IScoped scoped;
        private readonly IScoped scoped1;

        public DateController(ISingleton singleton,ISingleton singleton1,ITransient transient ,ITransient transient1,
            IScoped scoped,IScoped scoped1)
        {
            this.singleton = singleton;
            this.singleton1 = singleton1;
            this.transient = transient;
            this.transient1 = transient1;
            this.scoped = scoped;
            this.scoped1 = scoped1;
        }

        //GET: api/<DateController>
        [HttpGet]
        public DateResponse Get() 
        {
          var response = new DateResponse();
            response.Singleton = singleton.PrintGuidNumber();
            response.Singleton1 = singleton1.PrintGuidNumber();
            response.Transient = transient.PrintGuidNumber();
            response.Transient1 = transient1.PrintGuidNumber();
            response.Scoped = scoped.PrintGuidNumber();
            response.Scoped1 = scoped1.PrintGuidNumber();

            return response;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
