using Microsoft.AspNetCore.Mvc;

namespace SquareCalc.Controllers
{
    public class CalcController : Controller
    {
        public ActionResult Sqrt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sqrt(string firstnumber, string secondnumber)
        {
            try
            {
                double number1 = System.Math.Sqrt(int.Parse(firstnumber));
                double number2 = System.Math.Sqrt(int.Parse(secondnumber));
                if (number1 > number2)
                {
                    string result1 = ($"The number {firstnumber} with square root {number1} has a higher square root than the number {secondnumber} with square root {number2}");
                    ViewBag.Result = result1;
                }
                if (number2 > number1)
                {
                    string result2 = ($"The number {secondnumber} with square root {number2} has a higher square root than the number {firstnumber} with square root {number1}");
                    ViewBag.Result = result2;
                }
                if (number1 == number2)
                {
                    string result3 = ("Enter 2 different values Please");
                    ViewBag.Result = result3;
                }
                if (int.Parse(firstnumber) <= 0 || int.Parse(secondnumber) < 0)
                {
                    string result5 = ("Error: +ve values only");
                    ViewBag.Result = result5;
                }
            }
            catch (System.Exception)
            {
                string result4 = ("Error");
                ViewBag.Result = result4;
                throw;
            }
           
            return View();
        }
    }
}