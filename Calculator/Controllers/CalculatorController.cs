using Calculator.Services;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("/api/calculator/{action}/{numbers?}")]
    public class CalculatorController
    {
        public CalculatorController(Calculate calculate)
        {
            _calculate = calculate;
        }
        private Calculate _calculate;

        public double Addition(string numbers)
        {
            return _calculate.Sum(numbers);
        }
        public double Subtraction(string numbers)
        {
            return _calculate.Sub(numbers);
        }
        public double Division(string numbers)
        {
            return _calculate.Div(numbers);
        }
        public double Multiplication(string numbers)
        {
            return _calculate.Mul(numbers);
        }
    }
}
