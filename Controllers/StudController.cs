using firstnet.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace firstnet.Model;

[ApiController]

[Route("Stud")]

public class StudController:ControllerBase {
    private readonly IStud stu;
    public StudController(IStud s) {
        stu = s;
    }
    [HttpGet]
    public ActionResult<List<Stud>> GetAll() {
        return Ok(stu.GetAll());
    }
    [HttpGet("{id}")]
    public ActionResult<Stud> GetById(int id) {
        return Ok(stu.GetById(id));
    }
    [HttpPost]
    public ActionResult<List<Stud>> Add(Stud stud) {
        return Ok(stu.Add(stud));
    }
    [HttpPut]
    public ActionResult<List<Stud>> Edit(Stud stud) {
        return Ok(stu.Edit(stud));
    }
    [HttpDelete("{id}")]
    public ActionResult<List<Stud>> Delete(int id) {
        return Ok(stu.Delete(id));
    }

}
