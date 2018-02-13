using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TensorFlow;

namespace webapi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TensorController : Controller
    {

        public TensorController(ILogger<TensorController> logger)
        {
            _logger = logger;
        }

        private readonly ILogger _logger;
        [HttpGet]
        public object Calculate(int p1, int p2)
        {
            using (var session = new TFSession())
            {
                var graph = session.Graph;

                var a = graph.Const(p1);
                var b = graph.Const(p2);
                _logger.LogInformation("a=2 b=3");

                // Add two constants
                var addingResults = session.GetRunner().Run(graph.Add(a, b));
                _logger.LogInformation("a+b={0}", addingResults.GetValue());

                // Multiply two constants
                var multiplyResults = session.GetRunner().Run(graph.Mul(a, b));
                _logger.LogInformation("a*b={0}", multiplyResults.GetValue());
                return Ok($"a+b={addingResults.GetValue()} a*b={multiplyResults.GetValue()}");
            }

            
        }

    }
}