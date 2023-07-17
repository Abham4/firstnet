using firstnet.Application.Interface;
using firstnet.Model;
using Microsoft.AspNetCore.Mvc;

namespace firstnet.Controllers;

[ApiController]

[Route("Check")]

public class CheckController:ControllerBase {
    private readonly ICheck check;
    public CheckController(ICheck che) {
        check = che;
    }
     [HttpGet]
 public ActionResult<List<Check>> Get(){
  return Ok(check.Get());
 } 
 


[HttpGet("{id}")]
public ActionResult<Check> GetById(int id) {
   return check.GetById(id);
}

[HttpDelete("{id}")]

public ActionResult<List<Check>> Delete(int id) {
   return Ok(check.Delete(id));
}
[HttpPut]
public ActionResult<List<Check>> Edit(Check c) {
   return Ok(check.Edit(c));
}
[HttpPost]
public ActionResult<List<Check>> Add(Check c) {
   return Ok(check.Add(c));
}

}