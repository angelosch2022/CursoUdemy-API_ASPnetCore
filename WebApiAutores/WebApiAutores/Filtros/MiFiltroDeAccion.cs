using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiAutores.Filtros
{
    public class MiFiltroDeAccion : IActionFilter
    {
        public ILogger<MiFiltroDeAccion> Logger { get; }

        public MiFiltroDeAccion(ILogger<MiFiltroDeAccion> logger)
        {
            Logger = logger;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Logger.LogInformation("Antes de ejecuar la accion");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Logger.LogInformation("Después de ejecuar la accion");

        }

    }
}
