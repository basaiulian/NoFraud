using FraudPredictorML.Model;
using Microsoft.AspNetCore.Mvc;

namespace FraudPredictor.Controllers
{
    public class FraudController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ModelOutput Index(ModelInput input)
        {
            var prediction = ConsumeModel.Predict(input);
            //ViewBag.Result = prediction;
            return prediction;

            //return View();
        }
    }
}
