using firstnet.Application.Interface;
using firstnet.Model;
using Microsoft.AspNetCore.Mvc;

namespace firstnet.Controllers;
[ApiController]
[Route("Staff")]
public class StaffController:ControllerBase {
    private readonly IStaff staff;
    public StaffController(IStaff sta) {
        staff = sta;
    }
    [HttpGet]
    public ActionResult<List<Staff>> GetAll() {
        return Ok(staff.GetAll());
    }
    [HttpGet("{id}")]
    public ActionResult<Staff> GetById(int id) {
        return Ok(staff.GetById(id));
    }
    [HttpPost]
    public ActionResult<List<Staff>> Add(Staff staf) {
        return Ok(staff.Add(staf));
    }
    [HttpDelete]
    public ActionResult<List<Staff>> Delete(int id) {
        return Ok(staff.Delete(id));
    }
    [HttpPut]
    public ActionResult<Staff> Edit(Staff staf) {
        return Ok(staff.Edit(staf));
    }
}