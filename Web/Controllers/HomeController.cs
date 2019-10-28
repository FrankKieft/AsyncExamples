using AsyncExamples.Domain;
using AsyncExamples.Web.Models;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AsyncExamples.Web.Controllers
{
    public class HomeController : Controller
    {
        private CalculationService _service;

        public HomeController()
        {
            _service = new CalculationService();
        }

        public ActionResult Index()
        {
            var model = new CalculationLogModel(242);

            return View(model);
        }
        
        [HttpPost]
        public ActionResult Calculate(CalculationLogModel model)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            var x = model.Number;

            var log = _service.Calculate(x);

            return View("Index", new CalculationLogModel(log, model.Number, "Synchronous calculation", threadId));
        }

        [HttpPost]
        public async Task<ActionResult> AsyncCalculate(CalculationLogModel model)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            var x = model.Number;

            var log = await _service.AsyncCalculate(x);

            return View("Index", new CalculationLogModel(log, model.Number, "Asynchronous calculation", threadId));
        }

        [HttpPost]
        public async Task<ActionResult> AsyncWithTaskCalculate(CalculationLogModel model)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            var x = model.Number;

            var log = await _service.AsyncWithTaskCalculate(x);

            return View("Index", new CalculationLogModel(log, model.Number, "Asynchronous calculation with tasks", threadId));
        }

        [HttpPost]
        public ActionResult ParallelCalculate(CalculationLogModel model)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            var x = model.Number;

            var log = _service.ParallelCalculate(x);

            return View("Index", new CalculationLogModel(log, model.Number, "Parallel calculation", threadId));
        }
    }
}