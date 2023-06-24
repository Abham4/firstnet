using Microsoft.AspNetCore.Mvc;

namespace firstnet;

[ApiController]
[Route("[controller]")]

public class FirstCalc:ControllerBase
{
    [HttpPost]
    public ActionResult<int> Calculater(int num1, int num2) {
        var sum = 0;
        sum = num1 + num2;

       return Ok(sum);
    }
}