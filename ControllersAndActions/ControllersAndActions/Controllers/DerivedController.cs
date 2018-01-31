using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Linq;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        [ControllerContext]
        public ControllerContext ControllerContext { get; set; }

        public ViewResult Index()
        {
            return View("Result", $"This is a derived controller");
        }

        public ViewResult Headers()
        {
            
            return new ViewResult()
            {
                ViewName = "DictionaryResult",
                ViewData = new ViewDataDictionary(
                        new EmptyModelMetadataProvider(),
                        new ModelStateDictionary())
                        {
                            Model = ControllerContext.HttpContext.Request.Headers.ToDictionary(kvp => kvp.Key, kvp => kvp.Value.First())
                        }
            };
        }
    }
}